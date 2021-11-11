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
    public partial class DentistInformation : Form


    {
        private SqlConnection conn;
        private string sCn;
        ///variables for search bar
        public DataTable input;
        string filterField = "specialty";
        public DentistInformation()
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
            string commandJOIN = "SELECT dentist.name, dentist.specialty, dentist.status, dentist.email, dentist.phone FROM dentist";
            SqlCommand cmd = new SqlCommand(commandJOIN, conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            input = tabla;

            data.Fill(tabla);

            return tabla;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dentist_information_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = AddData();
                conn.Close();
                //Closing database connection
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Podes des comentar esto, lo hice pa ahorrate este boton :D
            //Menu returnToMenu = new Menu(userEmailValue);
            //returnToMenu.Show();
            //this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         

        }

        private void specialitytxt_TextChanged(object sender, EventArgs e)
        {
            if (specialitytxt.Text == "Type here...")
            {
                specialitytxt.Text = "";
            }
            input.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, specialitytxt.Text);
        }
    }
    }


