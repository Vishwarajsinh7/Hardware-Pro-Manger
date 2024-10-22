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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


=======
>>>>>>> c95f7139356dc744dc5fab087756fd21e09633a6

namespace Hardware_Pro_Manager
{
    public partial class Sales : Form
    {
<<<<<<< HEAD
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataGridViewCellEventArgs es;

        private CrystalDecisions.CrystalReports.Engine.ReportDocument cr = new CrystalDecisions.CrystalReports.Engine.ReportDocument();



        static string Crypath = "";

        

        String s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects\Hardware Pro Manager\Hardware Pro Manager\HardwareProDb.mdf;Integrated Security=True";

        void Connection()
        {
            conn = new SqlConnection(s);
            conn.Open();
        }


        void FillSalesGrid()
        {
            Connection();
            string query = "SELECT * FROM BillTbl";
            da = new SqlDataAdapter(query, conn);

            DataTable dt = new DataTable();
            da.Fill(dt);
            SalesDGV.DataSource = dt;
            conn.Close();
        }



        public Sales()
        {
            InitializeComponent();
            FillSalesGrid();
=======
        public Sales()
        {
            InitializeComponent();
>>>>>>> c95f7139356dc744dc5fab087756fd21e09633a6
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Feedbacks fd = new Feedbacks();
            fd.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Customers cu = new Customers();
            cu.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Items itm = new Items();
            itm.Show();
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
<<<<<<< HEAD

        private void CrystallReportOfBill_Click(object sender, EventArgs e)
        { 
            try
            {
                da = new SqlDataAdapter("SELECT * FROM BillTbl", conn);
                ds = new DataSet();
                da.Fill(ds);
                string xml = @"D:/Projects/Hardware Pro Manager/SalesData/data.xml";
                ds.WriteXmlSchema(xml);

                Crypath = @"D:/Projects/Hardware Pro Manager/Hardware Pro Manager/CrystalReport1.rpt";

                crystalReportViewer1.Visible = true;

                cr.Load(Crypath);
                cr.SetDataSource(ds);
                cr.Database.Tables[0].SetDataSource(ds);
                cr.Refresh();
                crystalReportViewer1.ReportSource = cr;

            }
            catch(CrystalReportsException ees)
            {
                MessageBox.Show(ees.ToString());
            }
            Connection();

            conn.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }
=======
>>>>>>> c95f7139356dc744dc5fab087756fd21e09633a6
    }
}
