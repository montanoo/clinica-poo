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
    public partial class AdminAddMethods : Form
    {
        public AdminAddMethods()
        {
            InitializeComponent();
        }

        private void AdminAddMethods_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void backToMenu_Click(object sender, EventArgs e)
        {
            AdminMenu goBack = new AdminMenu();
            goBack.Show();
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            AddMethods newMethod = new AddMethods();
            bool returned = newMethod.AddNewMethod(txtName, txtDescription, txtPrice);

            if (returned)
            {
                if (MessageBox.Show("Method added with success!",
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

        private void linkSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login newLogin = new Login();
            newLogin.Show();
            this.Hide();
        }

        private void SaysTypeHere(TextBox pText)
        {
            if (pText.Text == "Type here...")
            {
                pText.Text = "";
            }
        }

        private void AdminAddMethods_Load(object sender, EventArgs e)
        {

        }
    }
}
