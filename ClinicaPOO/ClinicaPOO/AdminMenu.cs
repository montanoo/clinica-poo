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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void AdminMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAddDentists_Click(object sender, EventArgs e)
        {
            AdminAddDentist addNewDentist = new AdminAddDentist();
            addNewDentist.Show();
            this.Hide();
        }

        private void btnEditOrDel_Click(object sender, EventArgs e)
        {
            AdminEditDentist newEdit = new AdminEditDentist();
            newEdit.Show();
            this.Hide();
        }

        private void btnAppointAdmin_Click(object sender, EventArgs e)
        {
            AdminListOfAppointments showList = new AdminListOfAppointments();
            showList.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminAddMethods newMethod = new AdminAddMethods();
            newMethod.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdminEditMethods editMethods = new AdminEditMethods();
            editMethods.Show();
            this.Hide();
        }

        private void linkSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login signOut = new Login();
            signOut.Show();
            this.Hide();
        }
    }
}
