using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ClinicaPOO
{
    class SignUpUser
    {
        private SqlConnection connector;
        private SqlCommand insertcommand1, insertcommand2;
        private string sqlConn;

        public bool SignUp(TextBox txtUsername, TextBox txtName, TextBox txtLastname, TextBox txtEmail, TextBox txtPassword, MaskedTextBox txtDUI, MaskedTextBox txtPhone, DateTimePicker dTPbirth)
        {
            Connection access = new Connection();
            access.Connect();
            sqlConn = access.WindowsAuth;
            connector = new SqlConnection(sqlConn);
            connector.Open(); 

            if (txtName.Text == "" || txtLastname.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" ||
                txtDUI.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Complete all fields please", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtName.Text == "Type here..." || txtLastname.Text == "Type here..." ||
                txtEmail.Text == "Type here..." || txtPassword.Text == "Password" ||
                txtDUI.Text == "Type here..." || txtPhone.Text == "Type here...")
            {
                MessageBox.Show("Complete all fields please", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;

            }
            else if (WeakPassword(txtPassword))
            {
                MessageBox.Show("Password must have more than 8 characters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                try
                {
                    InsertInto(txtUsername, txtName, txtLastname, txtEmail, txtPassword, txtDUI, txtPhone, dTPbirth);
                    insertcommand1.ExecuteNonQuery();
                    insertcommand2.ExecuteNonQuery();
                    connector.Close();

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error has ocurred: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        public void InsertInto(TextBox txtUsername, TextBox txtName, TextBox txtLastname, TextBox txtEmail, TextBox txtPassword, MaskedTextBox txtDUI, MaskedTextBox txtPhone, DateTimePicker dTPbirth)
        {
            string insertpatient;

            insertpatient = "INSERT INTO patient (name, lastname, email, dui, phone, birthdate )";
            insertpatient += "VALUES (@pname, @plastname, @pemail, @pdui, @pphone, @pbirthdate)";
            insertcommand1 = new SqlCommand(insertpatient, connector);
            insertcommand1.Parameters.Add(new SqlParameter("@pname", SqlDbType.VarChar));
            insertcommand1.Parameters["@pname"].Value = txtName.Text;
            insertcommand1.Parameters.Add(new SqlParameter("@plastname", SqlDbType.VarChar));
            insertcommand1.Parameters["@plastname"].Value = txtLastname.Text;
            insertcommand1.Parameters.Add(new SqlParameter("@pemail", SqlDbType.VarChar));
            insertcommand1.Parameters["@pemail"].Value = txtEmail.Text;
            insertcommand1.Parameters.Add(new SqlParameter("@pdui", SqlDbType.VarChar));
            insertcommand1.Parameters["@pdui"].Value = txtDUI.Text;
            insertcommand1.Parameters.Add(new SqlParameter("@pphone", SqlDbType.VarChar));
            insertcommand1.Parameters["@pphone"].Value = txtPhone.Text;
            insertcommand1.Parameters.Add(new SqlParameter("@pbirthdate", SqlDbType.Date));
            insertcommand1.Parameters["@pbirthdate"].Value = dTPbirth.Text;

            string insertuser;

            insertuser = "INSERT INTO [user] (username, [password]) VALUES (@puser, @ppassword); ";
            insertcommand2 = new SqlCommand(insertuser, connector);
            insertcommand2.Parameters.Add(new SqlParameter("@puser", SqlDbType.VarChar));
            insertcommand2.Parameters["@puser"].Value = txtUsername.Text;
            insertcommand2.Parameters.Add(new SqlParameter("@ppassword", SqlDbType.VarChar));
            insertcommand2.Parameters["@ppassword"].Value = txtPassword.Text;
        }
        public Boolean WeakPassword(TextBox txtPassword)
        {
            int countnumbers = 0;
            for (int i = 0; i < txtPassword.TextLength; i++)
            {
                countnumbers += 1;
            }
            if (countnumbers < 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
