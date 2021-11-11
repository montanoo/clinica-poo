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
        private string sqlConn;


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
            try
            {
                SignUpUser objSignUp = new SignUpUser();
                bool parameter = objSignUp.SignUp(txtUsername, txtName, txtLastname, txtEmail, txtPassword, txtDUI, txtPhone, dTPbirth);
                if (parameter)
                {
                    InsertUserIDSignUp objUserid = new InsertUserIDSignUp();
                    bool parameter2 = objUserid.Updatepatient(txtUsername, txtEmail);
                    if (parameter2)
                    {
                         Login Gotologin=new Login();
                      Gotologin.Show();
                      this.Close();
                    }      
                }    
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            

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
            if(txtName.Text=="Name")
            { txtName.Text = ""; }
            
        }

        private void txtLastname_Click(object sender, EventArgs e)
        {
            if (txtLastname.Text == "Lastname")
            { txtLastname.Text = ""; }
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            { txtEmail.Text = ""; }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Type here...")
            { txtPassword.Text = ""; }
        }

        private void txtDUI_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPhone_Click(object sender, EventArgs e)
        {

        }

        private void txtName_Enter(object sender, EventArgs e)
        {

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) 
            {
            if(txtLastname.Text=="Lastname")
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
                if (txtEmail.Text == "Email")
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
                    txtDUI.Focus();
            }
            
        }

        private void txtDUI_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void txtDUI_Leave(object sender, EventArgs e)
        {

        }
        public bool validemail(string pemail)
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

        private void SignUp_Load_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            { txtUsername.Text = ""; }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Name")
            {
                txtName.Clear();
                txtName.Focus();
            }
        }
    }
}
