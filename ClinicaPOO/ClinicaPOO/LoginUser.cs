using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClinicaPOO
{
    class LoginUser
    {
        private string userEmail;
        private int roleId;
        public bool Login(TextBox txtUsername, TextBox txtPassword)
        {
            try
            {
                Connection sqlVariables = new Connection();
                sqlVariables.Connect();
                string connectString = sqlVariables.WindowsAuth;

                SqlConnection windowsAuthConn = new SqlConnection(connectString);
                windowsAuthConn.Open();
                string verify = "SELECT username, password FROM [user] WHERE [username] = @vUsername AND password = @vPassword";
                SqlCommand command = new SqlCommand(verify, windowsAuthConn);
                command.Parameters.AddWithValue("@vUsername", txtUsername.Text);
                command.Parameters.AddWithValue("@vPassword", txtPassword.Text);

                SqlDataReader readData = command.ExecuteReader();
                if (readData.Read())
                {
                    string sql2 = "SELECT [role_id] FROM [user] WHERE [username] = @pUsername";
                    using (SqlConnection conn = new SqlConnection(connectString))
                    {
                        SqlCommand cmd = new SqlCommand(sql2, conn);
                        cmd.Parameters.AddWithValue("@pUsername", txtUsername.Text);
                        try
                        {
                            conn.Open();
                            roleId = (int)cmd.ExecuteScalar();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }

                    if (roleId != 1)
                    {
                        windowsAuthConn.Close();
                        // Obtendremos el email relacionado con ese usuario de la tabla patient con inner join.
                        string sql = "SELECT email FROM patient p INNER JOIN [user] u ON u.id = p.id WHERE [username] = @pUsername";
                        using (SqlConnection conn = new SqlConnection(connectString))
                        {
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@pUsername", txtUsername.Text);
                            try
                            {
                                conn.Open();
                                userEmail = cmd.ExecuteScalar().ToString(); // Obtenemos el string del email.
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            Menu enterMenu = new Menu(userEmail);
                            enterMenu.Show();
                        }
                    }
                    else
                    {
                        if (roleId == 1)
                        {
                            AdminMenu enterAdmin = new AdminMenu();
                            enterAdmin.Show();
                        }
                    }
                    return true;
                }
                // En un dado caso exista el usuario, se leerá.
                else
                {   // En el caso en que las credenciales sean incorrectas.
                    MessageBox.Show("Wrong user or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception errorHappened)
            {
                MessageBox.Show($"There was an error: {errorHappened.Message}"); // Si ocurre un error externo.
                return false;
            }
        }
    }
}
