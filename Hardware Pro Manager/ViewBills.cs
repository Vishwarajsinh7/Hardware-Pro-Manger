using System;
using System.Data;
using System.Data.SqlClient;
using System.IO; // Required for Path
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Hardware_Pro_Manager
{
    public partial class ViewBills : Form
    {
        // Default constructor for viewing all sales
        public ViewBills()
        {
            InitializeComponent();
            FillSalesGrid();
        }

        // New constructor to handle immediate report generation
        public ViewBills(bool showReportImmediately)
        {
            InitializeComponent();
            if (showReportImmediately)
            {
                LoadAndShowReport();
            }
            else
            {
                FillSalesGrid();
            }
        }

        void FillSalesGrid()
        {
            // Hide the report viewer and show the grid
            crystalReportViewer1.Visible = false;
            SalesDGV.Visible = true;
            CrystallReportOfBill.Visible = false; // Hide button, it's not needed anymore

            string query = "SELECT * FROM BillTbl";
            SalesDGV.DataSource = DbHelper.ExecuteQuery(query);
        }

        void LoadAndShowReport()
        {
            try
            {
                // Hide the grid and show the report viewer
                SalesDGV.Visible = false;
                crystalReportViewer1.Visible = true;
                CrystallReportOfBill.Visible = false;

                // 1. Define the report path relative to the application's executable
                // This assumes CrystalReport4.rpt is in your project's main directory
                // and its "Copy to Output Directory" property is set to "Copy if newer".
                string reportPath = Path.Combine(Application.StartupPath, "CrystalReport4.rpt");

                if (!File.Exists(reportPath))
                {
                    MessageBox.Show("Crystal Report file (CrystalReport4.rpt) not found. Please ensure it is in the application directory and set to 'Copy if newer'.");
                    return;
                }

                // 2. Get the data for the report from the TempBillTbl
                string query = "SELECT * FROM TempBillTbl";
                DataTable reportData = DbHelper.ExecuteQuery(query);

                if (reportData.Rows.Count == 0)
                {
                    MessageBox.Show("No data found for the report.");
                    return;
                }
                
                // 3. Load the report and set its data source
                ReportDocument cr = new ReportDocument();
                cr.Load(reportPath);
                cr.SetDataSource(reportData);

                crystalReportViewer1.ReportSource = cr;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while generating the report: {ex.Message}");
            }
        }

        // --- NAVIGATION & EVENT HANDLERS ---

        private void label10_Click(object sender, EventArgs e) // Back button
        {
            Billing bl = new Billing();
            bl.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e) // Exit button
        {
            Application.Exit();
        }

        // The old button is no longer needed with this new design, but we keep the event handler empty
        private void CrystallReportOfBill_Click(object sender, EventArgs e)
        {
            // This button is now hidden and this logic is handled automatically.
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}