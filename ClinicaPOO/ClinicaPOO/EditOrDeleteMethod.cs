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
    class EditOrDeleteMethod
    {
        Connection sqlVariables = new Connection();
        public void Delete(ComboBox cmbMethod)
        {
            try
            {
                sqlVariables.Connect();
                string connectString = sqlVariables.WindowsAuth;
                SqlConnection windowsAuthConn = new SqlConnection(connectString);

                string currentMethod = cmbMethod.SelectedItem.ToString(); ;

                string deletion;
                deletion = $"DELETE FROM methods WHERE id IN (SELECT id from methods WHERE name = '{currentMethod}')";

                windowsAuthConn.Open();
                SqlCommand delete = new SqlCommand(deletion, windowsAuthConn);
                delete.ExecuteNonQuery();
                windowsAuthConn.Close();

                MessageBox.Show("Method deleted with success", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Error)
            {
                MessageBox.Show($"We found an error: {Error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Update(ComboBox cmbMethod)
        {
            cmbMethod.Items.Clear();
            try
            {
                sqlVariables.Connect();
                string connectString = sqlVariables.WindowsAuth;
                SqlConnection windowsAuthConn = new SqlConnection(connectString);
                windowsAuthConn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM methods", windowsAuthConn);
                SqlDataReader readData = command.ExecuteReader();

                while (readData.Read())
                {
                    AddMethods newMethod = new AddMethods()
                    {
                        Name = readData["name"].ToString()
                    };
                    cmbMethod.Items.Add(newMethod.Name);
                }
                windowsAuthConn.Close();

            }
            catch (Exception errorHappened)
            {
                MessageBox.Show($"There was an error: {errorHappened.Message}");
            }
        }
        public bool Edit(TextBox txtName, TextBox txtDescription, TextBox txtPrice, ComboBox cmbMethods)
        {
            try
            {
                sqlVariables.Connect();
                string connectString = sqlVariables.WindowsAuth;
                SqlConnection windowsAuthConn = new SqlConnection(connectString);
                windowsAuthConn.Open();

                string currentMethod = cmbMethods.SelectedItem.ToString();
                string updateQuery = $"UPDATE methods SET name=@pName, description=@pDescription, price=@pPrice WHERE id IN (SELECT id from methods WHERE name = '{currentMethod}')";
                SqlCommand newQuery = new SqlCommand(updateQuery, windowsAuthConn);

                newQuery.Parameters.Add("@pName", SqlDbType.VarChar).Value = txtName.Text;
                newQuery.Parameters.AddWithValue("@pDescription", txtDescription.Text);
                newQuery.Parameters.AddWithValue("@pPrice", double.Parse(txtPrice.Text));

                newQuery.ExecuteNonQuery();

                windowsAuthConn.Close();

                MessageBox.Show($"Method updated succesfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;

            }
            catch (Exception errorFound)
            {
                MessageBox.Show($"There was an error: {errorFound.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
    }
}
