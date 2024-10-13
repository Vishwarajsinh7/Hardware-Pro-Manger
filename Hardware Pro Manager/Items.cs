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

        String s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\SEM 5\HARDWARE PRO MANAGER\Hardware Pro Manager\Hardware Pro Manager\HardwareProDb.mdf;Integrated Security=True";


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
            FillGrid();
        }

        private void Items_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
    }
}
