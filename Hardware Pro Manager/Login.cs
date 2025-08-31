using System;
using System.Windows.Forms;

namespace Hardware_Pro_Manager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBuL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UnameTbL.Text) || string.IsNullOrWhiteSpace(PwordTbL.Text))
            {
                MessageBox.Show("Please enter both a username and password.");
                return; // Stop the method here
            }

            // Cleaned-up login logic. 
            // NOTE: In a real application, you should check credentials against a database.
            // This is still insecure but fixes the merge conflicts and code structure.
            if ((UnameTbL.Text == "Mohit" && PwordTbL.Text == "1234") ||
                (UnameTbL.Text == "Hardik" && PwordTbL.Text == "1234"))
            {
                Items itemsForm = new Items();
                itemsForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }
        }

        private void ContinueAsSellerLaL_Click(object sender, EventArgs e)
        {
            // This allows non-admin users to go directly to the billing form
            Billing billingForm = new Billing();
            billingForm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e) // Exit button
        {
            Application.Exit();
        }

        // --- Unused Event Handlers ---
        private void label1_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}