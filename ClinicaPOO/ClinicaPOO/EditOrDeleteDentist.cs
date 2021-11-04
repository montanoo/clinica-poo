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
    class EditOrDeleteDentist
    {
        Connection sqlVariables = new Connection();

        public bool Edit(TextBox txtName, TextBox txtSpecialty, TextBox txtStatus, TextBox txtEmail, MaskedTextBox txtPhone, ComboBox cmbDentistEmail)
        {
            try
            {
                sqlVariables.Connect();
                string connectString = sqlVariables.WindowsAuth;
                SqlConnection windowsAuthConn = new SqlConnection(connectString);
                windowsAuthConn.Open();

                string currentEmail = cmbDentistEmail.SelectedItem.ToString();
                string updateQuery = $"UPDATE dentist SET name=@pName, specialty=@pSpecialty, status=@pStatus, email = @pEmail, phone = @pPhone WHERE id IN (SELECT id from dentist WHERE email = '{currentEmail}')";
                SqlCommand newQuery = new SqlCommand(updateQuery, windowsAuthConn);

                newQuery.Parameters.AddWithValue("@pName", txtName.Text);
                newQuery.Parameters.AddWithValue("@pSpecialty", txtSpecialty.Text);
                newQuery.Parameters.AddWithValue("@pStatus", int.Parse(txtStatus.Text));
                newQuery.Parameters.Add("@pEmail", SqlDbType.VarChar).Value = txtEmail.Text;
                newQuery.Parameters.AddWithValue("@pPhone", txtPhone.Text);

                newQuery.ExecuteNonQuery();

                windowsAuthConn.Close();

                MessageBox.Show($"Dentist updated succesfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;

            }
            catch (Exception errorFound)
            {
                MessageBox.Show($"There was an error: {errorFound.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }
        public void Update(ComboBox cmbDentistEmail)
        {
            cmbDentistEmail.Items.Clear();
            try
            {
                sqlVariables.Connect();
                string connectString = sqlVariables.WindowsAuth;
                SqlConnection windowsAuthConn = new SqlConnection(connectString);
                windowsAuthConn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM dentist", windowsAuthConn);
                SqlDataReader readData = command.ExecuteReader();

                while (readData.Read())
                {
                    AddDentist dentist = new AddDentist()
                    {
                        Email = readData["email"].ToString()
                    };
                    cmbDentistEmail.Items.Add(dentist.Email);
                }
                windowsAuthConn.Close();

            }
            catch (Exception errorHappened)
            {
                MessageBox.Show($"There was an error: {errorHappened.Message}");
            }
        }
        public void Delete(ComboBox cmbDentistEmail)
        {
            try
            {
                sqlVariables.Connect();
                string connectString = sqlVariables.WindowsAuth;
                SqlConnection windowsAuthConn = new SqlConnection(connectString);

                string currentEmail = cmbDentistEmail.SelectedItem.ToString(); ;

                string deletion;
                deletion = $"DELETE FROM dentist WHERE id IN (SELECT id from dentist WHERE email = '{currentEmail}')";

                windowsAuthConn.Open();
                SqlCommand delete = new SqlCommand(deletion, windowsAuthConn);
                delete.ExecuteNonQuery();
                windowsAuthConn.Close();

                MessageBox.Show("Dentist deleted with success", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception Error)
            {
                MessageBox.Show($"We found an error: {Error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
