using System;
using System.Windows.Forms;

namespace Hardware_Pro_Manager
{
    public partial class Feedbacks : Form
    {
        public Feedbacks()
        {
            InitializeComponent();
            FillGrid(); // Load data when the form opens
        }

        // Load all saved feedback into the grid
        void FillGrid()
        {
            string query = "SELECT FId, CustName, Feedback FROM FeedbackTbl";
            FeedbackDGV.DataSource = DbHelper.ExecuteQuery(query);
        }

        // --- NAVIGATION ---
        private void label2_Click(object sender, EventArgs e) { new Sales().Show(); this.Hide(); }
        private void label1_Click(object sender, EventArgs e) { new Customers().Show(); this.Hide(); }
        private void label3_Click(object sender, EventArgs e) { new Items().Show(); this.Hide(); }
        private void label5_Click(object sender, EventArgs e) { Application.Exit(); }
        private void label10_Click(object sender, EventArgs e) { new Login().Show(); this.Hide(); }

        // --- Unused / Renamed ---
        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}