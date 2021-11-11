using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaPOO
{
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Welcome goBack = new Welcome();
            goBack.Show();
            this.Hide();
        }

        private void AboutUs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
