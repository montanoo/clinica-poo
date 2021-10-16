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
    public partial class Login : Form
    {
        int clickCounter = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Se encargará de verificar si se ha cerrado el Form y de ser así, cerrará la app.
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Connection sqlVariables = new Connection();
                sqlVariables.Connect();
                string connectString = sqlVariables.WindowsAuth;

                SqlConnection windowsAuthConn = new SqlConnection(connectString);
                windowsAuthConn.Open();

                string verify = "SELECT email, password FROM patient WHERE email = @vEmail AND password = @vPassword";
                SqlCommand command = new SqlCommand(verify, windowsAuthConn);
                command.Parameters.AddWithValue("@vEmail", txtEmail.Text);
                command.Parameters.AddWithValue("@vPassword", txtPassword.Text);

                SqlDataReader readData = command.ExecuteReader();

                if (readData.Read())
                {
                    windowsAuthConn.Close();
                    MessageBox.Show("User is correct");
                    Menu enterMenu = new Menu(txtEmail.Text);
                    enterMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong user or password.");
                }

            }
            catch(Exception errorHappened)
            {
                MessageBox.Show($"There was an error: {errorHappened.Message}");
            }
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0, 255);
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Type here...")
            { txtEmail.Text = ""; }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            { txtPassword.Text = ""; }
        }

        private void picWatchPassword_Click(object sender, EventArgs e)
        {
            clickCounter++;
            if (clickCounter % 2 == 1)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp newUser = new SignUp();
            newUser.Show();
            this.Hide();
        }
    }
}
