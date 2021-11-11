using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.IO;


namespace ClinicaPOO
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutUs showAbout = new AboutUs();
            showAbout.Show();
            this.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            bool databaseExist = CheckDatabase("ClinicaPOO");

            if (!databaseExist)
            {
                // MessageBox.Show("Creating db");
                CreateDatabase();
            }
            // MessageBox.Show("Database already exists!");
            Login changeToLogin = new Login();
            changeToLogin.Show();
            this.Hide();
        }

        private void btnStart_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            btnStart.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0, 255);
        }

        private void Welcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private bool CheckDatabase(string databaseName)
        {
            Connection sqlConnection = new Connection();
            sqlConnection.Connect();

            string fromMaster = sqlConnection.WindowsAuth.Replace("Initial Catalog=ClinicaPOO", "Initial Catalog=master");
            SqlConnection connectionString = new SqlConnection(fromMaster);

            var cmdText = "SELECT COUNT(*) FROM master.dbo.sysdatabases where name=@database";

            using (var sqlConn = new SqlConnection(fromMaster))
            {
                using (var sqlCmd = new SqlCommand(cmdText, sqlConn))
                {
                    sqlCmd.Parameters.Add("@database", SqlDbType.NVarChar).Value = databaseName;

                    sqlConn.Open();
                    bool alreadyExists = Convert.ToInt32(sqlCmd.ExecuteScalar()) == 1;
                    return alreadyExists;
                }
            }
        }

        private void CreateDatabase()
        {
            Connection sqlConnection = new Connection();
            sqlConnection.Connect();

            string fromMaster = sqlConnection.WindowsAuth.Replace("Initial Catalog=ClinicaPOO", "Initial Catalog=master");
            SqlConnection connectionString = new SqlConnection(fromMaster);

            connectionString.Open();

            string desiredPath = Environment.CurrentDirectory.Replace("ClinicaPOO\\bin\\Debug\\net5.0-windows", 
                "database");
            string data = File.ReadAllText(desiredPath + @"\ClinicaPOO.sql");
            Server server = new Server(new ServerConnection(connectionString));
            server.ConnectionContext.ExecuteNonQuery(data);
        }
    }
}
