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
                Connection sqlConnection = new Connection();
                sqlConnection.Connect();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter($"SELECT COUNT(*) FROM patient WHERE email='{txtEmail.Text}' AND password='{txtPassword.Text}'", sqlConnection.WindowsAuth);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                    MessageBox.Show("User login successfull!", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Something's wrong!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
    }
}
