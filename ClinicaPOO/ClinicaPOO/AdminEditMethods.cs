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

namespace ClinicaPOO
{
    public partial class AdminEditMethods : Form
    {
        public AdminEditMethods()
        {
            InitializeComponent();
        }

        private void AdminEditMethods_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ResetInitial()
        {
            txtName.ReadOnly = true;
            txtPrice.ReadOnly = true;
            txtDescription.ReadOnly = true;

            btnEdit.Visible = true;
            btnDelete.Visible = true;
            btnConfirm.Visible = false;
            btnCancel.Visible = false;

            txtName.BackColor = Color.FromName("Control");
            txtPrice.BackColor = Color.FromName("Control");
            txtDescription.BackColor = Color.FromName("Control");

        }
        private void EnterEdit()
        {
            txtName.ReadOnly = false;
            txtPrice.ReadOnly = false;
            txtDescription.ReadOnly = false;

            btnEdit.Visible = false;
            btnDelete.Visible = false;
            btnConfirm.Visible = true;
            btnCancel.Visible = true;

            txtName.BackColor = Color.White;
            txtPrice.BackColor = Color.White;
            txtDescription.BackColor = Color.White;
        }
        private void Clear()
        {
            txtName.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            cmbMethod.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetInitial();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            EditOrDeleteMethod edit = new EditOrDeleteMethod();
            bool success = edit.Edit(txtName, txtDescription, txtPrice, cmbMethod);
            if (success)
            {
                Clear();
                edit.Update(cmbMethod);
                ResetInitial();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cmbMethod.SelectedIndex == -1)
                MessageBox.Show("Please, select an item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                EnterEdit();
        }

        private void cmbMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection sqlVariables = new Connection();
            sqlVariables.Connect();
            string connectString = sqlVariables.WindowsAuth;
            SqlConnection windowsAuthConn = new SqlConnection(connectString);
            windowsAuthConn.Open();

            SqlCommand command = new SqlCommand($"SELECT * FROM methods WHERE name = '{cmbMethod.SelectedItem}'", windowsAuthConn);
            SqlDataReader readData = command.ExecuteReader();

            while (readData.Read())
            {
                AddMethods methodInfo = new AddMethods()
                {
                    Name = readData["name"].ToString(),
                    Description = readData["description"].ToString(),
                    Price = double.Parse(readData["price"].ToString())
                };
                txtName.Text = methodInfo.Name;
                txtDescription.Text = methodInfo.Description;
                txtPrice.Text = methodInfo.Price.ToString();
            }
            windowsAuthConn.Close();
        }

        private void backToMenu_Click(object sender, EventArgs e)
        {
            AdminMenu goBack = new AdminMenu();
            goBack.Show();
            this.Hide();
        }

        private void AdminEditMethods_Load(object sender, EventArgs e)
        {
            EditOrDeleteMethod update = new EditOrDeleteMethod();
            update.Update(cmbMethod);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EditOrDeleteMethod delete = new EditOrDeleteMethod();
            delete.Delete(cmbMethod);
            delete.Update(cmbMethod);
            Clear();
        }
        private void txtPrice_KeyDown(object sender, KeyEventArgs e){ }
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPrice.ReadOnly == false)
            {
                //condicion para solo números
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                //para tecla backspace
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                /*verifica que pueda ingresar punto y también que solo pueda 
               ingresar un punto*/
                else if ((e.KeyChar == '.') && (!txtPrice.Text.Contains(".")))
                {
                    e.Handled = false;
                }
                //si no se cumple nada de lo anterior entonces que no lo deje pasar
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Only numbers are allowed", "Number validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else { }
        }

        private void linkSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login signOut = new Login();
            signOut.Show();
            this.Hide();
        }
    }
}
