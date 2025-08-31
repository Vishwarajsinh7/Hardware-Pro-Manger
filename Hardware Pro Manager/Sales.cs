using System;
using System.Windows.Forms;

namespace Hardware_Pro_Manager
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
            FillSalesGrid();
        }

        void FillSalesGrid()
        {
            // The report viewer and its button are not needed here anymore.
            crystalReportViewer1.Visible = false;
            CrystallReportOfBill.Visible = false;

            string query = "SELECT * FROM BillTbl";
            SalesDGV.DataSource = DbHelper.ExecuteQuery(query);
        }

        // --- NAVIGATION ---
        private void label4_Click(object sender, EventArgs e) { new Feedbacks().Show(); this.Hide(); }
        private void label1_Click(object sender, EventArgs e) { new Customers().Show(); this.Hide(); }
        private void label3_Click(object sender, EventArgs e) { new Items().Show(); this.Hide(); }
        private void label5_Click(object sender, EventArgs e) { Application.Exit(); }
        private void label10_Click(object sender, EventArgs e) { new Login().Show(); this.Hide(); }
        
        // --- Unused Event Handlers ---
        private void CrystallReportOfBill_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void crystalReportViewer1_Load(object sender, EventArgs e) { }
    }
}