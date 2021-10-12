using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaPOO
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            Login showLogin = new Login();
            showLogin.Show();
            this.Hide();
        }
        private void btnStart_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.White;
            btnStart.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0, 255);
        }
    }
}
