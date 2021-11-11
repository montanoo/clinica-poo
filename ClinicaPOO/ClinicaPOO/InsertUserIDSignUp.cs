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
    class InsertUserIDSignUp
    {
        private SqlConnection connector;
        private SqlCommand insertcommand;
        private string sqlConn;

        public bool Updatepatient(TextBox txtUsername, TextBox txtEmail)
        {
        Connection access = new Connection();
            access.Connect();
            sqlConn = access.WindowsAuth;
            connector = new SqlConnection(sqlConn);
            connector.Open();
            try
            {
                Int32 USERID = 0;
                string sql =
                    "SELECT id from [user] WHERE username = @pusername";
                using (SqlConnection conn = new SqlConnection(sqlConn))
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Add("@pusername", SqlDbType.VarChar);
                    cmd.Parameters["@pusername"].Value = txtUsername.Text;
                    conn.Open();
                    USERID = (Int32)cmd.ExecuteScalar();
                    conn.Close();
                }
                string insertuserid;

                insertuserid = "UPDATE patient SET user_id=@puserid WHERE email=@pemail";
                insertcommand = new SqlCommand(insertuserid, connector);
                insertcommand.Parameters.Add(new SqlParameter("@puserid", SqlDbType.Int));
                insertcommand.Parameters["@puserid"].Value = USERID;
                insertcommand.Parameters.Add(new SqlParameter("@pemail", SqlDbType.VarChar));
                insertcommand.Parameters["@pemail"].Value = txtEmail.Text;
                insertcommand.ExecuteNonQuery();
                connector.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
    }
}
