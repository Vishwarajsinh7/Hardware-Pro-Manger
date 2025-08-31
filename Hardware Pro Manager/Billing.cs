using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Hardware_Pro_Manager
{
    public partial class Billing : Form
    {
        int key = 0, stock = 0, custKey = 0;
        int n = 0, GrdTotal = 0;
        
        public Billing()
        {
            InitializeComponent();
            FillItemGrid();
            FillCustomerGrid();
            // Clear any temporary data from a previous session on startup
            DeleteTempBillData();
        }

        // --- DATA & HELPER METHODS ---

        void FillItemGrid()
        {
            string query = "SELECT * FROM ItemTbl";
            ItemDGV.DataSource = DbHelper.ExecuteQuery(query);
        }

        void FillCustomerGrid()
        {
            string query = "SELECT * FROM CustomerTbl";
            CustomerDGV.DataSource = DbHelper.ExecuteQuery(query);
        }

        void Reset()
        {
            ProdQtyTb.Text = "";
            ProdPriceTb.Text = "";
            CustNameTb.Text = "";
            ProdNameTb.Text = "";
            BillDGV.Rows.Clear();
            GrdTotal = 0;
            TotalLbl.Text = "Rs. 0";
            n = 0;
            key = 0;
            stock = 0;
            custKey = 0;
        }

        void UpdateItem(int itemId, int quantitySold)
        {
            try
            {
                // This query safely decrements the stock in the database directly
                string query = "UPDATE ItemTbl SET ItQty = ItQty - @QuantitySold WHERE ItId = @ItemId";
                SqlParameter[] parameters = {
                    new SqlParameter("@QuantitySold", quantitySold),
                    new SqlParameter("@ItemId", itemId)
                };
                DbHelper.ExecuteNonQuery(query, parameters);
                FillItemGrid(); // Refresh the grid
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating item stock: {ex.Message}");
            }
        }

        // --- REFACTORED BILLING & REPORTING LOGIC ---

        void DeleteTempBillData()
        {
            string query = "DELETE FROM TempBillTbl";
            DbHelper.ExecuteNonQuery(query);
        }

        void SaveToTempBill(DataGridViewRow row)
        {
            try
            {
                // Extract values from the DataGridView row
                string prodName = row.Cells[1].Value.ToString();
                int price = Convert.ToInt32(row.Cells[2].Value);
                int qty = Convert.ToInt32(row.Cells[3].Value);
                int total = Convert.ToInt32(row.Cells[4].Value);
                int billProductId = Convert.ToInt32(row.Cells[0].Value);

                string query = "INSERT INTO TempBillTbl (BId, CustId, CustName, ProductName, ProductPrice, ProductQty, Amount) VALUES (@BId, @CustId, @CustName, @ProdName, @Price, @Qty, @Total)";
                SqlParameter[] parameters = {
                    new SqlParameter("@BId", billProductId),
                    new SqlParameter("@CustId", custKey),
                    new SqlParameter("@CustName", CustNameTb.Text),
                    new SqlParameter("@ProdName", prodName),
                    new SqlParameter("@Price", price),
                    new SqlParameter("@Qty", qty),
                    new SqlParameter("@Total", total)
                };
                DbHelper.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving temporary bill data: {ex.Message}");
            }
        }

        // --- EVENT HANDLERS ---

        private void AddToBillBtn_Click(object sender, EventArgs e)
        {
            if (key == 0 || string.IsNullOrWhiteSpace(ProdQtyTb.Text))
            {
                MessageBox.Show("Please select a product and enter a quantity.");
                return;
            }
            if (custKey == 0)
            {
                MessageBox.Show("Please select a customer.");
                return;
            }

            int requestedQty;
            if (!int.TryParse(ProdQtyTb.Text, out requestedQty) || requestedQty <= 0)
            {
                MessageBox.Show("Please enter a valid positive quantity.");
                return;
            }

            if (requestedQty > stock)
            {
                MessageBox.Show("Insufficient stock available.");
                return;
            }

            int price = Convert.ToInt32(ProdPriceTb.Text);
            int total = requestedQty * price;

            // Add to visual grid
            BillDGV.Rows.Add(n + 1, ProdNameTb.Text, price, requestedQty, total);
            
            // Update total
            GrdTotal += total;
            TotalLbl.Text = "Rs. " + GrdTotal;
            n++;

            // Update inventory in the database
            UpdateItem(key, requestedQty);
        }

        private void button2_Click(object sender, EventArgs e) // Print Button
        {
            if (BillDGV.Rows.Count == 0)
            {
                MessageBox.Show("The bill is empty. Please add items first.");
                return;
            }

            // 1. Clear previous temporary data
            DeleteTempBillData();

            // 2. Save current bill items to the temporary table
            foreach (DataGridViewRow row in BillDGV.Rows)
            {
                if (row.IsNewRow) continue;
                SaveToTempBill(row);
            }
            
            // 3. Save the final bill to the main BillTbl
            try
            {
                string query = "INSERT INTO BillTbl (CustId, CustName, Amount) VALUES (@CustId, @CustName, @Amount)";
                SqlParameter[] parameters = {
                    new SqlParameter("@CustId", custKey),
                    new SqlParameter("@CustName", CustNameTb.Text),
                    new SqlParameter("@Amount", GrdTotal)
                };
                DbHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Bill saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving final bill: {ex.Message}");
                return; // Stop if we can't save the bill
            }
            
            // 4. Show the Crystal Report
            ViewBills reportForm = new ViewBills(true); // Pass true to show report immediately
            reportForm.Show();
            this.Hide();
        }

        private void ItemDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ProdNameTb.Text = ItemDGV.Rows[e.RowIndex].Cells["NameDGV"].Value.ToString();
                ProdPriceTb.Text = ItemDGV.Rows[e.RowIndex].Cells["PriceDGV"].Value.ToString();
                key = Convert.ToInt32(ItemDGV.Rows[e.RowIndex].Cells["IDDGV"].Value);
                stock = Convert.ToInt32(ItemDGV.Rows[e.RowIndex].Cells["QtyDGV"].Value);
            }
        }

        private void CustomerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CustNameTb.Text = CustomerDGV.Rows[e.RowIndex].Cells["CustNameDGV"].Value.ToString();
                custKey = Convert.ToInt32(CustomerDGV.Rows[e.RowIndex].Cells["CustIDDGV"].Value);
            }
        }
        
        private void button4_Click(object sender, EventArgs e) // Reset Button
        {
            Reset();
        }
        
        // --- NAVIGATION ---
        private void label5_Click(object sender, EventArgs e) { Application.Exit(); }
        private void label10_Click(object sender, EventArgs e) { new Login().Show(); this.Hide(); }
        private void button3_Click(object sender, EventArgs e) { new InstantFeedback().Show(); this.Hide(); }
        private void ViewSells_Click(object sender, EventArgs e) { new ViewBills().Show(); this.Hide(); }

        // --- Unused Event Handlers ---
        private void label9_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void Billing_Load(object sender, EventArgs e) { }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) { }
    }
}