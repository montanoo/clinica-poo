using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace ClinicaPOO
{
    public partial class SignUp : Form
    {
        //to connect
        private SqlConnection connector;
        private SqlCommand insertcommand;
        private string sqlConn;

        //for password
        public Boolean WeakPassword ()
        {
            int countnumbers=0;
            for (int i = 0; i < txtPassword.TextLength; i++)
            {
                countnumbers += 1;
            }
            if(countnumbers<8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public SignUp()
        {
            InitializeComponent();
            Connection access = new Connection();
            access.Connect();
            sqlConn = access.WindowsAuth;
            connector = new SqlConnection(sqlConn);
            connector.Open();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login Gotologin=new Login();
              Gotologin.Show();
              this.Close();
            
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtLastname.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" ||
                txtDUI.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Complete all fields please", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtName.Text == "Type here..." || txtLastname.Text == "Type here..." ||
                txtEmail.Text == "Type here..." || txtPassword.Text == "Password" ||
                txtDUI.Text == "Type here..." || txtPhone.Text == "Type here...")
            {
                MessageBox.Show("Complete all fields please", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(WeakPassword()==true)
            {
                MessageBox.Show("Password must have more than 8 characters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    InsertInto();
                    insertcommand.ExecuteNonQuery();
                    connector.Close();
                    Menu ShowMenu=new Menu();
                     ShowMenu.Show();
                     this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error has ocurred: {ex.Message}", "Warning",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void InsertInto()
        {
            string insertuser;

            insertuser = "INSERT INTO patient (name, lastname, email, password, dui, phone, birthdate )";
            insertuser += "VALUES (@pname, @plastname, @pemail, @ppassword,@pdui,@pphone,@pbirthdate)";
            insertcommand = new SqlCommand(insertuser, connector);
            insertcommand.Parameters.Add(new SqlParameter("@pname", SqlDbType.VarChar));
            insertcommand.Parameters["@pname"].Value = txtName.Text;
            insertcommand.Parameters.Add(new SqlParameter("@plastname", SqlDbType.VarChar));
            insertcommand.Parameters["@plastname"].Value = txtLastname.Text;
            insertcommand.Parameters.Add(new SqlParameter("@pemail", SqlDbType.VarChar));
            insertcommand.Parameters["@pemail"].Value = txtEmail.Text;
            insertcommand.Parameters.Add(new SqlParameter("@ppassword", SqlDbType.VarChar));
            insertcommand.Parameters["@ppassword"].Value = txtPassword.Text;
            insertcommand.Parameters.Add(new SqlParameter("@pdui", SqlDbType.VarChar));
            insertcommand.Parameters["@pdui"].Value = txtDUI.Text;
            insertcommand.Parameters.Add(new SqlParameter("@pphone", SqlDbType.VarChar));
            insertcommand.Parameters["@pphone"].Value = txtPhone.Text;
            insertcommand.Parameters.Add(new SqlParameter("@pbirthdate", SqlDbType.Date));
            insertcommand.Parameters["@pbirthdate"].Value = dTPbirth.Text;
        }

        private void btnSignUp_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            btnSignUp.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0, 255);
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            if(txtName.Text=="Type here...")
            { txtName.Text = ""; }
            
        }

        private void txtLastname_Click(object sender, EventArgs e)
        {
            if (txtLastname.Text == "Type here...")
            { txtLastname.Text = ""; }
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Type here...")
            { txtEmail.Text = ""; }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Type here...")
            { txtPassword.Text = ""; }
        }

        private void txtDUI_Click(object sender, EventArgs e)
        {
            if (txtDUI.Text == "Type here...")
            { txtDUI.Text = ""; }
        }

        private void txtPhone_Click(object sender, EventArgs e)
        {
            if (txtPhone.Text == "Type here...")
            { txtPhone.Text = ""; }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) 
            {
            if(txtLastname.Text=="Type here...")
                {
                    txtLastname.Text = "";
                    txtLastname.Focus();
                }
                else
                {
                    txtLastname.Focus();
                }
            }
        }

        private void txtLastname_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtEmail.Text == "Type here...")
                {
                    txtEmail.Text = "";
                    txtEmail.Focus();
                }
                else
                {
                    txtEmail.Focus();
                }
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtPassword.Text == "Type here...")
                {
                    txtPassword.Text = "";
                    txtPassword.Focus();
                }
                else
                {
                    txtPassword.Focus();
                }
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtDUI.Text == "Type here...")
                {
                    txtDUI.Text = "";
                    txtDUI.Focus();
                }
                else
                {
                    txtDUI.Focus();
                }
            }
        }
        public static bool validdui(string pdui)
        {
           
            string duistring = "([0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9])-([0-9])$";
   
            if (Regex.IsMatch(pdui, duistring))
            {
                if (Regex.Replace(pdui, duistring, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void txtDUI_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtPhone.Text == "Type here...")
                {
                    txtPhone.Text = "";
                    txtPhone.Focus();
                }
                else
                {
                    txtPhone.Focus();
                }
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login Gotologin=new Login();
             Gotologin.Show();
             this.Close();
        }

        private void txtDUI_Leave(object sender, EventArgs e)
        {
            if (validdui(txtDUI.Text))
            {
                //si es correcto no debe hacer nada
            }
            else
            {
                MessageBox.Show("Invalid DUI");
                txtDUI.SelectAll(); //selecciona todo lo de la casilla
                txtDUI.Focus(); //se posiciona ahí de nuevo
            }

        }
        public static bool validemail(string pemail)
        {
            
            string expression = @"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$";
         
            if (Regex.IsMatch(pemail, expression))
            {
             if (Regex.Replace(pemail, expression, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (validemail(txtEmail.Text))
            {
             
            }
            else
            {
                MessageBox.Show("Invalid email");
                txtEmail.SelectAll();
                txtEmail.Focus(); 
            }
        }
    }
}
