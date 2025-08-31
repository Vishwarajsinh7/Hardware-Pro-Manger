using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hardware_Pro_Manager
{
    public partial class Customers : Form
    {
        // 'key' will store the ID of the selected customer for updates/deletes.
        int key = 0;

        public Customers()
        {
            InitializeComponent();
            FillGrid(); // Load data when the form opens
        }

        // --- DATA & HELPER METHODS ---

        void FillGrid()
        {
            string query = "SELECT CustId, CustName, CustPhone FROM CustomerTbl";
            // Use our DbHelper to safely get the data
            CustomerDGV.DataSource = DbHelper.ExecuteQuery(query);
        }

        void Reset()
        {
            CustNameTb.Text = "";
            CustPhoneTb.Text = "";
            key = 0; // Reset the selected key
        }

        void SaveCustomer()
        {
            // The query uses placeholders (@CustName, @CustPhone) for security
            string query = "INSERT INTO CustomerTbl (CustName, CustPhone) VALUES (@CustName, @CustPhone)";
            
            // Create parameters to safely pass the values from textboxes
            SqlParameter[] parameters = {
                new SqlParameter("@CustName", CustNameTb.Text),
                new SqlParameter("@CustPhone", CustPhoneTb.Text)
            };
            
            // Execute the query using our central helper class
            DbHelper.ExecuteNonQuery(query, parameters);
            
            MessageBox.Show("Customer Saved!");
            FillGrid(); // Refresh the grid with the new data
            Reset();
        }

        void UpdateCustomer()
        {
            // Secure query with placeholders
            string query = "UPDATE CustomerTbl SET CustName = @CustName, CustPhone = @CustPhone WHERE CustId = @Key";
            
            // Create parameters to pass values safely
            SqlParameter[] parameters = {
                new SqlParameter("@CustName", CustNameTb.Text),
                new SqlParameter("@CustPhone", CustPhoneTb.Text),
                new SqlParameter("@Key", key)
            };
            
            DbHelper.ExecuteNonQuery(query, parameters);

            MessageBox.Show("Customer Updated!");
            FillGrid();
            Reset();
        }

        void DeleteCustomer()
        {
            // Secure query with a placeholder
            string query = "DELETE FROM CustomerTbl WHERE CustId = @Key";
            
            // Create a parameter for the key
            SqlParameter[] parameters = {
                new SqlParameter("@Key", key)
            };
            
            DbHelper.ExecuteNonQuery(query, parameters);

            MessageBox.Show("Customer Deleted!");
            FillGrid();
            Reset();
        }

        // --- EVENT HANDLERS ---

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CustNameTb.Text) || string.IsNullOrWhiteSpace(CustPhoneTb.Text))
            {
                MessageBox.Show("Please enter all customer details.");
            }
            else
            {
                SaveCustomer();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Please select a customer from the list to update.");
            }
            else
            {
                UpdateCustomer();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Please select a customer from the list to delete.");
            }
            else
            {
                DeleteCustomer();
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void CustomerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // This event populates the textboxes when you click on a cell in the grid
            if (e.RowIndex >= 0) // Ensure a valid row is clicked
            {
                CustNameTb.Text = CustomerDGV.Rows[e.RowIndex].Cells["NameDGV"].Value.ToString();
                CustPhoneTb.Text = CustomerDGV.Rows[e.RowIndex].Cells["PhoneDGV"].Value.ToString();
                key = Convert.ToInt32(CustomerDGV.Rows[e.RowIndex].Cells["IDDGV"].Value);
            }
        }

        // --- NAVIGATION ---

        private void label3_Click(object sender, EventArgs e) { new Items().Show(); this.Hide(); }
        private void label2_Click(object sender, EventArgs e) { new Sales().Show(); this.Hide(); }
        private void label4_Click(object sender, EventArgs e) { new Feedbacks().Show(); this.Hide(); }
        private void label5_Click(object sender, EventArgs e) { Application.Exit(); }
        private void label10_Click(object sender, EventArgs e) { new Login().Show(); this.Hide(); }

        // --- Unused Event Handlers ---
        private void label6_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void Customers_Load(object sender, EventArgs e) { }
        private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}