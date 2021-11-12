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
        public int userId;
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
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            userEmailValue = userEmail;

            try
            {
                Connection sqlVariables = new Connection();
                sqlVariables.Connect();
                string connectString = sqlVariables.WindowsAuth;
                SqlConnection windowsAuthConn = new SqlConnection(connectString);
                windowsAuthConn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM dentist WHERE status = 1", windowsAuthConn);
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
                SqlCommand command2 = new SqlCommand("SELECT * FROM methods WHERE id > 1", windowsAuthConn2);
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
            if (dentistcmb.SelectedIndex == -1 || methodcmb.SelectedIndex == -1 || hourcmbx.SelectedIndex == -1)
                MessageBox.Show("You must complete all data!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            else 
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
                insertappointment = "INSERT INTO appointments (dentist_id, patient_id, appointment_time, method_id)";
                insertappointment += "VALUES (@pdentist_id, @ppatient_id,@pappointment_time, @pmethod_id)";
                sqlConnect.Open();

                SqlParameter prm1 = new SqlParameter("id", SqlDbType.VarChar);
                string selection = $"SELECT id FROM patient WHERE email = '{userEmailValue}'";
                da1 = new SqlDataAdapter(selection, sqlConnect);
                prm1.Value = $"{userEmailValue}";
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

                DateTime appointmentDate = new DateTime();
                appointmentDate = DateTime.ParseExact(dateTimePicker1.Text + " " + hourcmbx.Text, "yyyy-MM-dd HH:mm", null);

                insertcommand.Parameters.Add(new SqlParameter("@pappointment_time", SqlDbType.DateTime));
                string chopper = $"{dateTimePicker1.Text} {hourcmbx.Text}";

                string sqlFormattedDate = appointmentDate.ToString("yyyy-MM-dd HH:mm:ss");
                insertcommand.Parameters["@pappointment_time"].Value = sqlFormattedDate;

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
                insertcommand.Parameters.Add(new SqlParameter("@ppatient_id", SqlDbType.Int));
                insertcommand.Parameters["@ppatient_id"].Value = userId;

                sqlConnect.Close();
                sqlConnect.Open();

                insertcommand.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Your appointment has been added succesfully. Remember to be punctual", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception errorFound)
            {
                MessageBox.Show($"There was an error: {errorFound.Message}");
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu returnToMenu = new Menu(userEmailValue);
            returnToMenu.Show();
            this.Hide();
        }

        private void AppointmentBooking_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}