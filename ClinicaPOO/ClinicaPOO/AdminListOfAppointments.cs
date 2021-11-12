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
    public partial class AdminListOfAppointments : Form
    {
        public DataTable input;
        private string sCn;
        private SqlConnection conn;
        string filterField = "Name";

        public AdminListOfAppointments()
        {
            InitializeComponent();
            //using class Connection
            Connection cn = new Connection();
            cn.Connect();
            sCn = cn.WindowsAuth;
            conn = new SqlConnection(sCn);
            //open connection
            conn.Open();
        }
        public DataTable AddData()
        {
            string commandJOIN = "SELECT patient.Name + ' ' + patient.Lastname AS Name, methods.name AS Method, dentist.name AS Dentist, appointments.appointment_time AS [Date], methods.price AS Price FROM appointments ";
            commandJOIN += "INNER JOIN patient ON appointments.patient_id = patient.id ";
            commandJOIN += "INNER JOIN methods ON appointments.method_id = methods.id ";
            commandJOIN += "INNER JOIN dentist ON appointments.dentist_id = dentist.id ";
            commandJOIN += "WHERE methods.id > 1 ";

            SqlCommand cmd = new SqlCommand(commandJOIN, conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            input = tabla;

            data.Fill(tabla);

            return tabla;
        }

        private void AdminListOfAppointments_Load(object sender, EventArgs e)
        {
            //Adding a source to the dgv
            dataGridView1.DataSource = AddData();
            conn.Close(); //Closing database connection
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Type here...")
                txtSearch.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Type here...")
            {
                txtSearch.Text = "";
            }
            input.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, txtSearch.Text);
        }
        private void AdminListOfAppointments_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminMenu goBack = new AdminMenu();
            goBack.Show();
            this.Hide();
        }

        private void linkSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login signOut = new Login();
            signOut.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
