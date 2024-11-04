using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace Hardware_Pro_Manager
{
    public partial class Billing : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataGridViewCellEventArgs es;
        int key = 0, stock = 0, custKey = 0, newStock = 0;
        int n = 0, total = 0, GrdTotal = 0;
        int BillProductId = 1;

        String s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects\Hardware Pro Manager\Hardware Pro Manager\HardwareProDb.mdf;Integrated Security=True";

        private CrystalDecisions.CrystalReports.Engine.ReportDocument cr = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

        static string Crypath = "";

        void Connection()
        {
            conn = new SqlConnection(s);
            conn.Open();
        }

        void FillItemGrid()
        {
            Connection();
            string query = "SELECT * FROM ItemTbl";
            da = new SqlDataAdapter(query, conn);

            DataTable dt = new DataTable();
            da.Fill(dt);
            ItemDGV.DataSource = dt;
            conn.Close();
        }

        void FillCustomerGrid()
        {
            Connection();
            string query = "SELECT * FROM CustomerTbl";
            da = new SqlDataAdapter(query, conn);

            DataTable dt = new DataTable();
            da.Fill(dt);
            CustomerDGV.DataSource = dt;
            conn.Close();
        }

        void Reset()
        {
            ProdQtyTb.Text = "";
            ProdPriceTb.Text = "";
            CustNameTb.Text = "";
            ProdNameTb.Text = "";
        }



        void UpdateItem()
        {
            Connection();

            try
            {

                newStock = 0;
                newStock = stock - Convert.ToInt32(ProdQtyTb.Text);
                string query = "UPDATE ItemTbl SET ItQty = " + newStock + " WHERE ItId = '" + key + "';";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Item ('" + ProdNameTb.Text + "') Updated!");
                FillItemGrid();
                stock = 0;
               

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            conn.Close();
        }


        void UpdateInventory()
        {
                UpdateItem();            
        }

        void DeleteOldRecords()
        {
            Connection();

            try
            {
                string query = "DELETE FROM TempBillTbl";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                
                
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            conn.Close();
        }



        void TempBillSave()
        {
            

            Connection();

            try
            {
                
                total = Convert.ToInt32(ProdQtyTb.Text) * Convert.ToInt32(ProdPriceTb.Text);

                string query = "INSERT INTO TempBillTbl VALUES('" + BillProductId + "', '" + custKey + "', '" + CustNameTb.Text + "','" + ProdNameTb.Text + "', '" + Convert.ToInt32(ProdPriceTb.Text) + "', '" + Convert.ToInt32(ProdQtyTb.Text) + "', '" + total + "')";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                
                da = new SqlDataAdapter("SELECT * FROM TempBillTbl", conn);
                ds = new DataSet();
                da.Fill(ds);
                string xml = @"D:/Projects/Hardware Pro Manager/SalesData/Bill.xml";
                ds.WriteXmlSchema(xml);


                Crypath = @"D:/Projects/Hardware Pro Manager/Hardware Pro Manager/CrystalReport4.rpt";
                cr.Load(Crypath);
                cr.SetDataSource(ds);
                cr.Database.Tables[0].SetDataSource(ds);
                cr.Refresh();
                crystalReportViewer1.ReportSource = cr;

                BillProductId = BillProductId + 1;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            conn.Close();

        }




        public Billing()
        {
            InitializeComponent();
            FillItemGrid();
            FillCustomerGrid();
            DeleteOldRecords();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Connection();

            try
            {
                string query = "INSERT INTO BillTbl VALUES('" + custKey + "', '" + CustNameTb.Text + "', '"+GrdTotal+"')";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bill Saved!");
               
                
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            conn.Close();

            


            crystalReportViewer1.Visible = true;


            DeleteOldRecords();
            BillProductId = 0;


        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Login ln = new Login();
            ln.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InstantFeedback ifk = new InstantFeedback();
            ifk.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Billing_Load(object sender, EventArgs e)
        {
            FillItemGrid();
            FillCustomerGrid();
        }

        

        private void ViewSells_Click(object sender, EventArgs e)
        {
            ViewBills vb = new ViewBills();
            vb.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void CustomerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Connection();

            CustNameTb.Text = (CustomerDGV.Rows[e.RowIndex].Cells["CustNameDGV"].Value).ToString();


            if (CustNameTb.Text == "")
            {
                custKey = 0;
            }
            else
            {
                custKey = Convert.ToInt32(CustomerDGV.Rows[e.RowIndex].Cells["CustIDDGV"].Value);
            }

            conn.Close();
        }

        private void AddToBillBtn_Click(object sender, EventArgs e)
        {
            if(ProdQtyTb.Text == "")
            {
                MessageBox.Show("⚠️Please choose any product from Product list!");
            }
            else if(Convert.ToInt32(ProdQtyTb.Text) > stock)
            {
                MessageBox.Show("Insufficient quantity! or rechoose the product!");
            }
            else
            {
                

                total = Convert.ToInt32(ProdQtyTb.Text)*Convert.ToInt32(ProdPriceTb.Text);


                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = ProdNameTb.Text;
                newRow.Cells[2].Value = ProdPriceTb.Text;
                newRow.Cells[3].Value = ProdQtyTb.Text;
                newRow.Cells[4].Value = total;
                BillDGV.Rows.Add(newRow);

                GrdTotal = GrdTotal + total;
                TotalLbl.Text = "Rs."+GrdTotal.ToString();
                n++;
                




                TempBillSave();

                UpdateInventory();

            }
        }

        private void ItemDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Connection();

            ProdNameTb.Text = (ItemDGV.Rows[e.RowIndex].Cells["NameDGV"].Value).ToString();

            ProdPriceTb.Text = (ItemDGV.Rows[e.RowIndex].Cells["PriceDGV"].Value).ToString();

            


            if (ProdNameTb.Text == "")
            {
                key = 0;
                stock = 0;
            }
            else
            {
                stock = 0;
                key = Convert.ToInt32(ItemDGV.Rows[e.RowIndex].Cells["IDDGV"].Value);
                stock = Convert.ToInt32(ItemDGV.Rows[e.RowIndex].Cells["QtyDGV"].Value);

            }

            conn.Close();
        }
    }
}
