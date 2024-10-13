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
    public partial class Customers : Form
    {
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
    }
}
