using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_Pro_Manager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(UnameTbL.Text == "" || PwordTbL.Text == "")
            {
                MessageBox.Show("Please enter username and password both!");
            }
            else if (UnameTbL.Text == "Mohit" && PwordTbL.Text == "1234")
            {
                Items itm = new Items();
                itm.Show();
                this.Hide();
            }
            else if (UnameTbL.Text == "Hardik" && PwordTbL.Text == "1234")
            {
                Items itm = new Items();
                itm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalide Username or Password!");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Billing bl = new Billing();
            bl.Show();
            this.Hide();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
