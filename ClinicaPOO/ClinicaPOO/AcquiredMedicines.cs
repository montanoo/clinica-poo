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
    public partial class AcquiredMedicines : Form
    {

        private SqlConnection conn;
        private string sCn;
        public string userEmailValue;
        public DataTable input;
        string filterField = "Product";
        private SqlCommand updcommand;
        public AcquiredMedicines(string userEmail)
        {
            InitializeComponent();
            Connection cn = new Connection();
            cn.Connect();
            sCn = cn.WindowsAuth;
            conn = new SqlConnection(sCn);
            conn.Open();
            userEmailValue = userEmail;
        }
        public DataTable AddData()
        {
            string commandForProducts = "SELECT product AS Product, billing.medicine_quantity AS Quantity,billing.total AS [Total Price] ";
            commandForProducts += "from inventory ";
            commandForProducts += "INNER JOIN billing ON billing.medicine_id=inventory.id ";
            commandForProducts += "INNER JOIN patient ON billing.patient_id=patient.id ";
            commandForProducts += $"WHERE patient.email='{userEmailValue}'";

            SqlCommand cmd = new SqlCommand(commandForProducts, conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            input = table;

            data.Fill(table);

            return table;
        }

        private void AcquiredMedicines_Load(object sender, EventArgs e)
        {
            try
            {
                //updating total
                UpdateTotal();
                updcommand.ExecuteNonQuery();
                conn.Close();
                //Adding a source to the dgv
                dgvProducts.DataSource = AddData();
                conn.Close(); //Closing database connection
                dgvProducts.Columns[2].DefaultCellStyle.Format = "$#.##";
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void UpdateTotal()
        {
            string settotal;
            settotal = "UPDATE B SET B.total =B.medicine_quantity*I.price ";
            settotal += "FROM billing B ";
            settotal += "INNER JOIN inventory I ON B.medicine_id = I.id";
            settotal += "INNER JOIN patient P ON B.patient_id = P.id";
            settotal += "WHERE P.email = @pemail";
            updcommand = new SqlCommand(settotal, conn);
            updcommand.Parameters.Add(new SqlParameter("@pemail", SqlDbType.VarChar));
            updcommand.Parameters["@pemail"].Value = userEmailValue;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Text = "";
            }
            input.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, txtSearch.Text);
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
                txtSearch.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
             Menu returnToMenu = new Menu(userEmailValue);
            returnToMenu.Show();
            this.Hide();
        }
    }
}
