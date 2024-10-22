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


namespace Hardware_Pro_Manager
{
    public partial class Items : Form
    {

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataGridViewCellEventArgs es;
        int key = 0;

        String s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects\Hardware Pro Manager\Hardware Pro Manager\HardwareProDb.mdf;Integrated Security=True";


        void Connection()
        {
            conn = new SqlConnection(s);
            conn.Open();
        }


        void SaveItem()
        {
            Connection();

            try
            {
                string query = "INSERT INTO ItemTbl VALUES('" + ItName.Text + "', '" + CatCp.SelectedItem.ToString() + "', '" + TypeCb.SelectedItem.ToString() + "', '" + PriceTb.Text + "', '" + QtyTb.Text + "')";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item ('" + ItName.Text + "') Saved!");
                FillGrid();
                Reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            conn.Close();
        }


        void FillGrid()
        {
            Connection();
            string query = "SELECT * FROM ItemTbl";
            da = new SqlDataAdapter(query, conn);

            DataTable dt = new DataTable();
            da.Fill(dt);
            ItemDGV.DataSource = dt;
            conn.Close();
        }

        void FillGridByCategory()
        {
            Connection();

            string query;
            if (FilterCat.SelectedItem.ToString() == "All")
            {
                query = "SELECT * FROM ItemTbl";
            }
            else
            {
                query = "SELECT * FROM ItemTbl WHERE ItCat = '" + FilterCat.SelectedItem.ToString() + "';";
            }
            
            da = new SqlDataAdapter(query, conn);

            DataTable dt = new DataTable();
            da.Fill(dt);
            ItemDGV.DataSource = dt;
            conn.Close();
        }


        void FillGridByType()
        {
            Connection();

            string query;
            if (FilterType.SelectedItem.ToString() == "All")
            {
                query = "SELECT * FROM ItemTbl";
            }
            else
            {
                query = "SELECT * FROM ItemTbl WHERE ItType = '" + FilterType.SelectedItem.ToString() + "';";
            }

            da = new SqlDataAdapter(query, conn);

            DataTable dt = new DataTable();
            da.Fill(dt);
            ItemDGV.DataSource = dt;
            conn.Close();
        }


        void Reset()
        {

            ItName.Text = "";
            CatCp.SelectedIndex = -1;
            TypeCb.SelectedIndex = -1;
            PriceTb.Text = "";
            QtyTb.Text = "";
            key = 0;
        }

        void UpdateItem()
        {
            Connection();

            try
            {
                string query = "UPDATE ItemTbl SET ItName = '" + ItName.Text + "', ItCat = '" + CatCp.SelectedItem.ToString() + "', ItType = '" + TypeCb.SelectedItem.ToString() + "', ItQty = '" + QtyTb.Text + "', ItPrice = '" + PriceTb.Text + "' WHERE ItId = '" + key + "';";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item ('" + ItName.Text + "') Updated!");
                FillGrid();
                Reset();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            conn.Close();
        }


        void DeleteItem()
        {
            Connection();

            try
            {
                string query = "DELETE FROM ItemTbl WHERE ItId = '" + key + "';";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item ('" + ItName.Text + "') Deleted!");
                FillGrid();
                Reset();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            conn.Close();
        }


        public Items()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Customers cu = new Customers();
            cu.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Customers cu = new Customers();
            cu.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Sales sl = new Sales();
            sl.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Feedbacks fd = new Feedbacks();
            fd.Show();
            this.Hide();
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

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(ItName.Text == "" || PriceTb.Text == "" || QtyTb.Text == "" || CatCp.SelectedIndex == -1 || TypeCb.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill and select all parameter!");
            }
            else
            {
                SaveItem();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Items_Load(object sender, EventArgs e)
        {
            FillGrid();

        }
        
        private void ItemDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
       

        private void ItemDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Connection();

            ItName.Text = (ItemDGV.Rows[e.RowIndex].Cells["NameDGV"].Value).ToString();
            CatCp.SelectedItem = (ItemDGV.Rows[e.RowIndex].Cells["CatDGV"].Value).ToString();

            TypeCb.SelectedItem = (ItemDGV.Rows[e.RowIndex].Cells["TypeDGV"].Value).ToString();

            PriceTb.Text = (ItemDGV.Rows[e.RowIndex].Cells["PriceDGV"].Value).ToString();

            QtyTb.Text = (ItemDGV.Rows[e.RowIndex].Cells["QtyDGV"].Value).ToString();


            if(ItName.Text=="")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt16(ItemDGV.Rows[e.RowIndex].Cells["IDDGV"].Value);
            }

            conn.Close();

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Please choose any row from data!");
            }
            else
            {
                DeleteItem();
            }
        }

        
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (ItName.Text == "" || PriceTb.Text == "" || QtyTb.Text == "" || CatCp.SelectedIndex == -1 || TypeCb.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose any row from data!");
            }
            else
            {
                UpdateItem();
            }
        }

        private void FilterCat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FillGridByCategory();
        }

        private void FilterType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FillGridByType();
        }
    }
}
