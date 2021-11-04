using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaPOO
{
    public partial class AdminAddDentist : Form
    {
        public AdminAddDentist()
        {
            InitializeComponent();
        }

        private void AdminAddDentist_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            AddDentist newDentist = new AddDentist();
            bool returned = newDentist.SignUpDentist(txtName, txtSpecialty, txtEmail, txtPhone);

            if (returned)
            {
                if (MessageBox.Show("Dentist added with success!",
                               "Success!",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information,
                               MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    AdminMenu returnToMenu = new AdminMenu();
                    returnToMenu.Show();
                    this.Hide();
                }
            }
        }

        private void backToMenu_Click(object sender, EventArgs e)
        {
            AdminMenu returnToMenu = new AdminMenu();
            returnToMenu.Show();
            this.Hide();
        }
        public static bool validemail(string pEmail)
        {
            string expression = @"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$";

            if (Regex.IsMatch(pEmail, expression))
            {
                if (Regex.Replace(pEmail, expression, string.Empty).Length == 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (validemail(txtEmail.Text)) { }
            else
            {
                MessageBox.Show("Invalid email", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.SelectAll();
                txtEmail.Focus();
            }
        }
    }
}
