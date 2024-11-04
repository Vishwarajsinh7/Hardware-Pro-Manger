using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using System.Data.SqlClient;
=======
>>>>>>> c95f7139356dc744dc5fab087756fd21e09633a6

namespace Hardware_Pro_Manager
{
    public partial class Customers : Form
    {
<<<<<<< HEAD

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


        void SaveCustomer()
        {
            Connection();

            try
            {
                string query = "INSERT INTO CustomerTbl VALUES('" + CustNameTb.Text + "', '" + CustPhoneTb.Text + "')";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer ('" + CustPhoneTb.Text + "') Saved!");
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
            string query = "SELECT * FROM CustomerTbl";
            da = new SqlDataAdapter(query, conn);

            DataTable dt = new DataTable();
            da.Fill(dt);
            CustomerDGV.DataSource = dt;
            conn.Close();
        }

        void Reset()
        {

            CustNameTb.Text = "";
            CustPhoneTb.Text = "";
            key = 0;
        }

        void UpdateCustomer()
        {
            Connection();

            try
            {
                string query = "UPDATE CustomerTbl SET CustName = '" + CustNameTb.Text + "', CustPhone = '" + CustPhoneTb.Text + "' WHERE CustId = '" + key + "';";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer ('" + CustNameTb.Text + "') Updated!");
                FillGrid();
                Reset();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            conn.Close();
        }


        void DeleteCustomer()
        {
            Connection();

            try
            {
                string query = "DELETE FROM CustomerTbl WHERE CustId = '" + key + "';";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer ('" + CustNameTb.Text + "') Deleted!");
                FillGrid();
                Reset();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            conn.Close();
        }



=======
>>>>>>> c95f7139356dc744dc5fab087756fd21e09633a6
        public Customers()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Items itm = new Items();
            itm.Show();
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

        private void label1_Click(object sender, EventArgs e)
        {

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
<<<<<<< HEAD

        private void ItemDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Connection();

            CustNameTb.Text = (CustomerDGV.Rows[e.RowIndex].Cells["NameDGV"].Value).ToString();

            CustPhoneTb.Text = (CustomerDGV.Rows[e.RowIndex].Cells["PhoneDGV"].Value).ToString();


            if (CustNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt16(CustomerDGV.Rows[e.RowIndex].Cells["IDDGV"].Value);
            }

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CustNameTb.Text == "" || CustPhoneTb.Text == "")
            {
                MessageBox.Show("Please fill and select all parameter!");
            }
            else
            {
                SaveCustomer();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            FillGrid();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Please choose any row from data!");
            }
            else
            {
                DeleteCustomer();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (CustNameTb.Text == "" || CustPhoneTb.Text == "")
            {
                MessageBox.Show("Please choose any row from data!");
            }
            else
            {
                UpdateCustomer();
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
=======
>>>>>>> c95f7139356dc744dc5fab087756fd21e09633a6
>>>>>>> eb0c822c4d08bda6e7c8a308d2cfb34688a97f2e
>>>>>>> 6c129b3f57ab73fabecd057b034226bfac8da464
    }
}
