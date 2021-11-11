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
            // Instanciamos a la clase LoginUser pasando parámetros.
            LoginUser newLogin = new LoginUser();
            bool returned = newLogin.Login(txtUsername, txtPassword);
            if (returned) // Si el bool que retorna es true, puede ocultar esta pantalla y dar paso a la siguiente.
                this.Hide();
        }

        private void btnLogin_MouseHover(object sender, EventArgs e) // Poner el mouse en el botón Login.
        {
            this.BackColor = Color.White;
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0, 255);
        }

        private void txtEmail_Click(object sender, EventArgs e) 
        {
            if (txtUsername.Text == "Type here...")
            { txtUsername.Text = ""; }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            { txtPassword.Text = ""; }
        }

        private void picWatchPassword_Click(object sender, EventArgs e)
        {
            // Permite mostrar o no mostrar la contraseña por medio de un contador de clicks.
            clickCounter++;
            if (clickCounter % 2 == 1)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // En un dado caso el usuario quiera entrar al menu Sign Up.
            SignUp newUser = new SignUp();
            newUser.Show();
            this.Hide();
        }
    }
}
