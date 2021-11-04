using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ClinicaPOO
{
    class AddDentist
    {
        private string name, specialty, email, phone;
        int status;
        private SqlConnection connector;
        private SqlCommand insertcommand;
        private string sqlConn;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Specialty
        {
            get { return specialty; }
            set { specialty = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        public bool SignUpDentist(TextBox txtName, TextBox txtSpecialty, TextBox txtEmail, MaskedTextBox txtPhone)
        {
            Connection access = new Connection();
            access.Connect();
            sqlConn = access.WindowsAuth;
            connector = new SqlConnection(sqlConn);
            connector.Open();

            if (txtName.Text == "" || txtEmail.Text == "" || txtPhone.Text == "" || txtSpecialty.Text == ""
                || txtName.Text == "Type here..." || txtEmail.Text == "Type here..." || txtPhone.Text == "Type here..." || txtSpecialty.Text == "Type here...")
            {
                MessageBox.Show("Complete all fields please", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                try
                {
                    Name = txtName.Text;
                    Email = txtEmail.Text;
                    Phone = txtPhone.Text;
                    Specialty = txtSpecialty.Text;

                    InsertIntoDensist(Name, Email, Specialty, Phone);
                    insertcommand.ExecuteNonQuery();
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
        public void InsertIntoDensist(string name, string email, string specialty, string phone)
        {
            string insertDentist;

            insertDentist = "INSERT INTO dentist (name, specialty, email, phone) ";
            insertDentist += "VALUES (@pName, @pSpecialty, @pEmail, @pPhone)";
            insertcommand = new SqlCommand(insertDentist, connector);
            insertcommand.Parameters.Add(new SqlParameter("@pName", SqlDbType.VarChar));
            insertcommand.Parameters["@pName"].Value = name;
            insertcommand.Parameters.Add(new SqlParameter("@pSpecialty", SqlDbType.VarChar));
            insertcommand.Parameters["@pSpecialty"].Value = specialty;
            insertcommand.Parameters.Add(new SqlParameter("@pEmail", SqlDbType.VarChar));
            insertcommand.Parameters["@pEmail"].Value = email;
            insertcommand.Parameters.Add(new SqlParameter("@pPhone", SqlDbType.VarChar));
            insertcommand.Parameters["@pPhone"].Value = phone;
        }
    }
}
