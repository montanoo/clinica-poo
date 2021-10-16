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

            string createDB = "CREATE DATABASE " + "ClinicaPOO";

            string appointmentsTable = "USE ClinicaPOO;" +
                "CREATE TABLE appointments (" +
                "id int IDENTITY(1,1) NOT NULL," +
                "dentist_id int," +
                "patient_id int," +
                "appointment_time datetime," +
                "method_id int," +
                "CONSTRAINT PK_appointmentID PRIMARY KEY (id));";

            string patientTable = "USE ClinicaPOO;" +
                "CREATE TABLE patient(" +
                "id int IDENTITY(1,1) NOT NULL," +
                "dui varchar(10)," +
                "[name] varchar(50)," +
                "lastname varchar(50)," +
                "email varchar(255)," +
                "phone varchar(9)," +
                "birthdate date," +
                "[password] varchar(max)," +
                "CONSTRAINT chk_password CHECK(DATALENGTH([password]) >= 8)," +
                "CONSTRAINT PK_patientID PRIMARY KEY (id));";

            string dentistTable = "USE ClinicaPOO;" +
                "CREATE TABLE dentist(" +
                "id int IDENTITY(1,1) NOT NULL," +
                "[name] varchar(50)," +
                "specialty varchar(25)," +
                "schedule datetime," +
                "email varchar(255)," +
                "phone varchar(9)," +
                "CONSTRAINT PK_dentistID PRIMARY KEY (id));";

            string inventoryTable = "USE ClinicaPOO;" +
                "CREATE TABLE inventory(" +
                "id int IDENTITY(1,1) NOT NULL," +
                "product varchar(100)," +
                "quantity int," +
                "price decimal(18, 2)," +
                "CONSTRAINT PK_inventoryID PRIMARY KEY (id));";

            string methodsTable = "USE ClinicaPOO;" +
                  "CREATE TABLE methods(" +
                 "id int IDENTITY(1,1) NOT NULL," +
                 "[name] varchar(50)," +
                 "[description] varchar(max)," +
                 "price decimal(18, 2)," +
                 "duration int," +
                 "CONSTRAINT PK_methodsID PRIMARY KEY(id));";


            string doctorStatusTable = "USE ClinicaPOO;" +
                "CREATE TABLE doctor_status(" +
                "dentist_id int," +
                "dentist_status varchar(8))";
                

            string foreignk = "ALTER TABLE appointments ";
            foreignk += "ADD CONSTRAINT FK_dentistID ";
            foreignk += "FOREIGN KEY (dentist_id) REFERENCES dentist(id);";

            string foreignk1 = "ALTER TABLE appointments ";
            foreignk1 += "ADD CONSTRAINT FK_patientID ";
            foreignk1 += "FOREIGN KEY (patient_id) REFERENCES patient(id);";

            string foreignk2 = "ALTER TABLE appointments ";
            foreignk2 += "ADD CONSTRAINT FK_methodID ";
            foreignk2 += "FOREIGN KEY (method_id) REFERENCES methods(id);";

            string foreignk3 = "ALTER TABLE doctor_status ";
            foreignk3 += "ADD CONSTRAINT FK_dentiststatus ";
            foreignk3 += "FOREIGN KEY (dentist_id) REFERENCES dentist(id);";

            SqlCommand cmd = new SqlCommand(createDB, connectionString);
            SqlCommand cmd1 = new SqlCommand(appointmentsTable, connectionString);
            SqlCommand cmd2 = new SqlCommand(patientTable, connectionString);
            SqlCommand cmd3 = new SqlCommand(dentistTable, connectionString);
            SqlCommand cmd4 = new SqlCommand(inventoryTable, connectionString);
            SqlCommand cmd5 = new SqlCommand(methodsTable, connectionString);
            SqlCommand cmd6 = new SqlCommand(doctorStatusTable, connectionString);
            SqlCommand cmd7 = new SqlCommand(foreignk, connectionString);
            SqlCommand cmd8 = new SqlCommand(foreignk1, connectionString);
            SqlCommand cmd9 = new SqlCommand(foreignk2, connectionString);
            SqlCommand cmd10 = new SqlCommand(foreignk3, connectionString);

            try
            {
                connectionString.Open();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();
                cmd5.ExecuteNonQuery();
                cmd6.ExecuteNonQuery();
                cmd7.ExecuteNonQuery();
                cmd8.ExecuteNonQuery();
                cmd9.ExecuteNonQuery();
                cmd10.ExecuteNonQuery();

                connectionString.Close();
            }
            catch (Exception errorFound)
            {
                MessageBox.Show($"Error found: {errorFound.Message}");
            }
        }
    }
}
