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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutUs showAbout = new AboutUs();
            showAbout.Show();
            this.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Login changeToLogin = new Login();
            changeToLogin.Show();
            this.Hide();
        }

        private void btnStart_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            btnStart.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0, 255);
        }

        private void Welcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
