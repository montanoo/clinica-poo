using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace ClinicaPOO
{
    public partial class AdminEditDentist : Form
    {
        public AdminEditDentist()
        {
            InitializeComponent();
        }

        private void AdminEditDentist_Load(object sender, EventArgs e)
        {
            EditOrDeleteDentist update = new EditOrDeleteDentist();
            update.Update(cmbDentistEmail);
        }

        private void AdminEditDentist_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cmbDentistEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection sqlVariables = new Connection();
            sqlVariables.Connect();
            string connectString = sqlVariables.WindowsAuth;
            SqlConnection windowsAuthConn = new SqlConnection(connectString);
            windowsAuthConn.Open();

            SqlCommand command = new SqlCommand($"SELECT * FROM dentist WHERE email = '{cmbDentistEmail.SelectedItem}'", windowsAuthConn);
            SqlDataReader readData = command.ExecuteReader();

            while (readData.Read())
            {
                AddDentist dentistInfo = new AddDentist()
                {
                    Name = readData["name"].ToString(),
                    Specialty = readData["specialty"].ToString(),
                    Status = int.Parse(readData["status"].ToString()),
                    Phone = readData["phone"].ToString(),
                    Email = readData["email"].ToString()
                };
                txtName.Text = dentistInfo.Name;
                txtPhone.Text = dentistInfo.Phone;
                txtSpecialty.Text = dentistInfo.Specialty;
                txtStatus.Text = dentistInfo.Status.ToString();
                txtEmail.Text = dentistInfo.Email;
            }
            windowsAuthConn.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cmbDentistEmail.SelectedIndex == -1)
                MessageBox.Show("Please, select an item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                EnterEdit();
        }

        private void backToMenu_Click(object sender, EventArgs e)
        {
            AdminMenu goToMenu = new AdminMenu();
            goToMenu.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetInitial();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            EditOrDeleteDentist edit = new EditOrDeleteDentist();
            bool success = edit.Edit(txtName, txtSpecialty, txtStatus, txtEmail, txtPhone, cmbDentistEmail);
            if (success)
            {
                Clear();
                edit.Update(cmbDentistEmail);
                ResetInitial();
            }
        }
        private void ResetInitial()
        {
            txtName.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtSpecialty.ReadOnly = true;
            txtStatus.ReadOnly = true;
            txtEmail.ReadOnly = true;

            btnEdit.Visible = true;
            btnDelete.Visible = true;
            btnConfirm.Visible = false;
            btnCancel.Visible = false;

            txtName.BackColor = Color.FromName("Control");
            txtPhone.BackColor = Color.FromName("Control");
            txtSpecialty.BackColor = Color.FromName("Control");
            txtStatus.BackColor = Color.FromName("Control");
            txtEmail.BackColor = Color.FromName("Control");

        }
        private void EnterEdit()
        {
            txtName.ReadOnly = false;
            txtPhone.ReadOnly = false;
            txtSpecialty.ReadOnly = false;
            txtStatus.ReadOnly = false;
            txtEmail.ReadOnly = false;

            btnEdit.Visible = false;
            btnDelete.Visible = false;
            btnConfirm.Visible = true;
            btnCancel.Visible = true;

            txtName.BackColor = Color.White;
            txtPhone.BackColor = Color.White;
            txtSpecialty.BackColor = Color.White;
            txtStatus.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
        }
        private void linkSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login signOut = new Login();
            this.Hide();
            signOut.Show();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            EditOrDeleteDentist delete = new EditOrDeleteDentist();
            delete.Delete(cmbDentistEmail);
            delete.Update(cmbDentistEmail);
            Clear();
        }
        private void Clear()
        {
            txtEmail.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtSpecialty.Clear();
            txtStatus.Clear();
            cmbDentistEmail.Text = "";
        }

        private void txtStatus_Leave(object sender, EventArgs e)
        {
            if (validemail(txtEmail.Text)) { }
            else
            {
                MessageBox.Show("Invalid email", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.SelectAll();
                txtEmail.Focus();
            }
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
    }
}
