using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hardware_Pro_Manager
{
    public partial class InstantFeedback : Form
    {
        public InstantFeedback()
        {
            InitializeComponent();
            LoadCustomers();
        }

        // Load customer data into the ComboBox
        private void LoadCustomers()
        {
            string query = "SELECT CustId, CustName FROM CustomerTbl";
            DataTable dt = DbHelper.ExecuteQuery(query);

            // Configure the ComboBox
            CustNameCb.DataSource = dt;
            CustNameCb.DisplayMember = "CustName"; // The text to show to the user
            CustNameCb.ValueMember = "CustId";     // The hidden value (the ID) for each customer
            CustNameCb.SelectedIndex = -1; // Deselect any default item
            CustNameCb.Text = "Choose a customer name:";
        }

        // --- Event Handlers ---

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CustNameCb.SelectedIndex == -1 || string.IsNullOrWhiteSpace(FeedbackRtb.Text))
            {
                MessageBox.Show("Please select a customer and provide feedback.");
                return;
            }

            try
            {
                // Safely insert the feedback into the new table
                string query = "INSERT INTO FeedbackTbl (CustId, CustName, Feedback) VALUES (@CustId, @CustName, @Feedback)";

                SqlParameter[] parameters = {
                    new SqlParameter("@CustId", CustNameCb.SelectedValue),
                    new SqlParameter("@CustName", CustNameCb.Text),
                    new SqlParameter("@Feedback", FeedbackRtb.Text)
                };

                DbHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Thank you for your feedback!");

                // Return to the Billing screen
                Billing bl = new Billing();
                bl.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void label5_Click(object sender, EventArgs e) // Exit button
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e) // Back button
        {
            Billing bl = new Billing();
            bl.Show();
            this.Hide();
        }

        // --- Renamed Controls and Unused Event Handlers ---

        // NOTE: You may need to rename your controls in the designer to match this code.
        // - ComboBox:  (Name) should be CustNameCb
        // - RichTextBox: (Name) should be FeedbackRtb
        // - Button:    (Name) should be SaveBtn

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
    }
}