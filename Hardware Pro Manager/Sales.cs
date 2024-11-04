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
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> eb0c822c4d08bda6e7c8a308d2cfb34688a97f2e
>>>>>>> 6c129b3f57ab73fabecd057b034226bfac8da464
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
=======
>>>>>>> c95f7139356dc744dc5fab087756fd21e09633a6
>>>>>>> eb0c822c4d08bda6e7c8a308d2cfb34688a97f2e
>>>>>>> 6c129b3f57ab73fabecd057b034226bfac8da464

namespace Hardware_Pro_Manager
{
    public partial class Sales : Form
    {
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> eb0c822c4d08bda6e7c8a308d2cfb34688a97f2e
>>>>>>> 6c129b3f57ab73fabecd057b034226bfac8da464
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataGridViewCellEventArgs es;

        private CrystalDecisions.CrystalReports.Engine.ReportDocument cr = new CrystalDecisions.CrystalReports.Engine.ReportDocument();



        static string Crypath = "";

        

<<<<<<< HEAD
        String s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\SEM 5\HARDWARE PRO MANAGER\Hardware Pro Manager\Hardware Pro Manager\HardwareProDb.mdf;Integrated Security=True";
=======
        String s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects\Hardware Pro Manager\Hardware Pro Manager\HardwareProDb.mdf;Integrated Security=True";
>>>>>>> 6c129b3f57ab73fabecd057b034226bfac8da464

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
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
=======
        public Sales()
        {
            InitializeComponent();
>>>>>>> c95f7139356dc744dc5fab087756fd21e09633a6
>>>>>>> eb0c822c4d08bda6e7c8a308d2cfb34688a97f2e
>>>>>>> 6c129b3f57ab73fabecd057b034226bfac8da464
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
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> eb0c822c4d08bda6e7c8a308d2cfb34688a97f2e
>>>>>>> 6c129b3f57ab73fabecd057b034226bfac8da464

        private void CrystallReportOfBill_Click(object sender, EventArgs e)
        { 
            try
            {
                da = new SqlDataAdapter("SELECT * FROM BillTbl", conn);
                ds = new DataSet();
                da.Fill(ds);
<<<<<<< HEAD
                string xml = @"C:/SEM 5/HARDWARE PRO MANAGER/Hardware Pro Manager/SalesData/data.xml";
                ds.WriteXmlSchema(xml);

                Crypath = @"C:/SEM 5/HARDWARE PRO MANAGER/Hardware Pro Manager/Hardware Pro Manager/CrystalReport1.rpt";
=======
                string xml = @"D:/Projects/Hardware Pro Manager/SalesData/data.xml";
                ds.WriteXmlSchema(xml);

                Crypath = @"D:/Projects/Hardware Pro Manager/Hardware Pro Manager/CrystalReport1.rpt";
>>>>>>> 6c129b3f57ab73fabecd057b034226bfac8da464

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
