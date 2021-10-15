using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ClinicaPOO
{
    public partial class AppointmentBooking : Form
    {
        public string userEmailValue;
        private SqlDataAdapter da1;
        private SqlDataReader dr1;
        public AppointmentBooking(string userEmail)
        {
            //Kallahan Salas
            InitializeComponent();
            userEmailValue = userEmail;
            var fechaactual = DateTime.Now;
            dateTimePicker1.MinDate = fechaactual;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";


            try
            {
                Connection sqlVariables = new Connection();
                sqlVariables.Connect();
                string connectString = sqlVariables.WindowsAuth;
                SqlConnection windowsAuthConn = new SqlConnection(connectString);
                windowsAuthConn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM dentist", windowsAuthConn);
                SqlDataReader readData = command.ExecuteReader();


                while (readData.Read())
                {
                    Dentist dentist = new Dentist()
                    {
                        id = int.Parse(readData["id"].ToString()),
                        name = readData["name"].ToString()
                    };
                    dentistcmb.Items.Add(dentist.name);
                    dentistList.Add(dentist);
                }
                windowsAuthConn.Close();
            }
            catch (Exception errorHappened)
            {
                MessageBox.Show($"There was an error: {errorHappened.Message}");
            }


            try
            {
                Connection sqlVariables2 = new Connection();
                sqlVariables2.Connect();
                string connectString2 = sqlVariables2.WindowsAuth;
                SqlConnection windowsAuthConn2 = new SqlConnection(connectString2);
                windowsAuthConn2.Open();
                SqlCommand command2 = new SqlCommand("SELECT * FROM methods", windowsAuthConn2);
                SqlDataReader readData2 = command2.ExecuteReader();


                while (readData2.Read())
                {
                    Methods methods = new Methods()
                    {
                        id = int.Parse(readData2["id"].ToString()),
                        name = readData2["name"].ToString()
                    };
                    methodcmb.Items.Add(methods.name);
                    methodsList.Add(methods);
                }
                windowsAuthConn2.Close();
            }

            catch (Exception errorHappened)
            {
                MessageBox.Show($"There was an error: {errorHappened.Message}");
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void methodcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection sqlVariables3 = new Connection();
            sqlVariables3.Connect();
            string connectString3 = sqlVariables3.WindowsAuth;
            SqlConnection windowsAuthConn3 = new SqlConnection(connectString3);
            SqlCommand command3 = new SqlCommand("SELECT * FROM  methods WHERE name = (@name)", windowsAuthConn3);
            command3.Parameters.AddWithValue("@name", methodcmb.SelectedItem.ToString());
            windowsAuthConn3.Open();
            SqlDataReader registro = command3.ExecuteReader();
            if (registro.Read())
            {
                price.Text = registro["price"].ToString();
            }
            windowsAuthConn3.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertInto();
        }

        private void InsertInto()
        {
            try
            {
                Connection sqlCnn = new Connection();
                sqlCnn.Connect();
                string connectString = sqlCnn.WindowsAuth;
                SqlConnection sqlConnect = new SqlConnection(connectString);
                string insertappointment;
                insertappointment = "INSERT INTO appointments (dentist_id, appointment_time, method_id)";
                insertappointment += "VALUES (@pdentist_id, @pappointment_time, @pmethod_id)";
                //   insertappointment += "";
                //     commandJOIN += $"WHERE patient.email='{userEmailValue}'";
                sqlConnect.Open();
                int userId;
                SqlParameter prm1 = new SqlParameter("id", SqlDbType.Int);
                string selection = "SELECT id FROM patient WHERE email = 'userId'"; // Reemplazado por una variable.
                da1 = new SqlDataAdapter(selection, connectString);
                prm1.Value = "userId";
                da1.SelectCommand.Parameters.Add(prm1);
                dr1 = da1.SelectCommand.ExecuteReader();

                while (dr1.Read())
                {
                    userId = int.Parse(dr1["id"].ToString());
                }

                SqlCommand insertcommand = new SqlCommand(insertappointment, sqlConnect);
                insertcommand.Parameters.Add(new SqlParameter("@pdentist_id", SqlDbType.Int));
                int pdentist_id = -1;
                foreach (Dentist element in dentistList)
                {
                    if (element.name == dentistcmb.Text)
                    {
                        pdentist_id = element.id;
                    }
                }
                insertcommand.Parameters["@pdentist_id"].Value = pdentist_id;

                insertcommand.Parameters.Add(new SqlParameter("@pappointment_time", SqlDbType.Date));
                DateTime date = new DateTime();
                date = DateTime.ParseExact(dateTimePicker1.Text + " " + hourcmbx.Text, "dd-MM-yyyy HH:mm", null);
                insertcommand.Parameters["@pappointment_time"].Value = date;

                insertcommand.Parameters.Add(new SqlParameter("@pmethod_id", SqlDbType.Int));
                int pmethod_id = -1;
                foreach (Methods element in methodsList)
                {
                    if (element.name == methodcmb.Text)
                    {
                        pmethod_id = element.id;
                    }
                }
                insertcommand.Parameters["@pmethod_id"].Value = pmethod_id;

                insertcommand.ExecuteNonQuery();
                sqlConnect.Close();
            }
            catch(Exception errorFound)
            {
                MessageBox.Show("There was an error: " + errorFound.Message);
            }
        }

        public class Dentist

        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class Methods
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public static List<Dentist> dentistList = new List<Dentist>();
        public static List<Methods> methodsList = new List<Methods>();

        private void AppointmentBooking_Load(object sender, EventArgs e)
        {

          /*  try
            {
                Connection sqlVariables = new Connection();
                sqlVariables.Connect();
                string connectString = sqlVariables.WindowsAuth;
                SqlConnection windowsAuthConn = new SqlConnection(connectString);
                windowsAuthConn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM dentist", windowsAuthConn);
                SqlDataReader readData = command.ExecuteReader();


                while (readData.Read())
                {
                    Dentist dentist = new Dentist()
                    {
                        id = int.Parse(readData["id"].ToString()),
                        name = readData["name"].ToString()
                    };
                    dentistcmb.Items.Add(dentist.name);
                    dentistList.Add(dentist);
                }
                windowsAuthConn.Close();
            }
            catch (Exception errorHappened)
            {
                MessageBox.Show($"There was an error: {errorHappened.Message}");
            }


            try
            {
                Connection sqlVariables2 = new Connection();
                sqlVariables2.Connect();
                string connectString2 = sqlVariables2.WindowsAuth;
                SqlConnection windowsAuthConn2 = new SqlConnection(connectString2);
                windowsAuthConn2.Open();
                SqlCommand command2 = new SqlCommand("SELECT * FROM methods", windowsAuthConn2);
                SqlDataReader readData2 = command2.ExecuteReader();


                while (readData2.Read())
                {
                    Methods methods = new Methods()
                    {
                        id = int.Parse(readData2["id"].ToString()),
                        name = readData2["name"].ToString()
                    };
                    methodcmb.Items.Add(methods.name);
                    methodsList.Add(methods);
                }
                windowsAuthConn2.Close();
            }

            catch (Exception errorHappened)
            {
                MessageBox.Show($"There was an error: {errorHappened.Message}");
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dentistcmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hourcmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AppointmentBooking_Load_1(object sender, EventArgs e)
        {

        }
    }
}