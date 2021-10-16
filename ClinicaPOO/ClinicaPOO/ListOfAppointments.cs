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
using System.Data.OleDb;

namespace ClinicaPOO
{
    public partial class FormListOfAppointments : Form
    {
        private SqlConnection conn;
        private string sCn;
        public string userEmailValue;

        //variables for search bar
        public DataTable input;
        string filterField = "Method";
        public FormListOfAppointments(string userEmail)
        {
            InitializeComponent();
            //using class Connection
            Connection cn = new Connection();
            cn.Connect();
            sCn = cn.WindowsAuth;
            conn = new SqlConnection(sCn);
            //open connection
            conn.Open();
            userEmailValue = userEmail;
        }


        private void FormListOfAppointments_Load(object sender, EventArgs e)
        {
            try
            {
                //Adding a source to the dgv
                dataGridView1.DataSource = AddData();
                conn.Close(); //Closing database connection
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public DataTable AddData()
        {
            string commandJOIN = "SELECT methods.name AS Method, dentist.name AS Dentist, appointments.appointment_time AS [Date], methods.price AS Price FROM appointments ";
            commandJOIN += "INNER JOIN patient ON appointments.patient_id = patient.id ";
            commandJOIN += "INNER JOIN methods ON appointments.method_id = methods.id ";
            commandJOIN += "INNER JOIN dentist ON appointments.dentist_id = dentist.id ";
            commandJOIN += $"WHERE patient.email='{userEmailValue}'";

            SqlCommand cmd = new SqlCommand(commandJOIN, conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            input = tabla;

            data.Fill(tabla);

            return tabla;
        }
        private void FormListOfAppointments_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Type your scheduled procedure...")
                txtSearch.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            input.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, txtSearch.Text);
        }
    }
}

