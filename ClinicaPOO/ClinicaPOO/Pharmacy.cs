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
    public partial class Pharmacy : Form
    {
        private SqlConnection conn;
        private string sCn;
        public string userEmailData;

        public Pharmacy()
        {
            InitializeComponent();
            refreshBtn.Hide();

        }
        public Pharmacy(string email)
        {
            InitializeComponent();
            userEmailData = email;
        }
        private void fillGrid()
        {
            string consulta = "select product AS[Product Name], price AS [Price] from inventory";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            PharmacyGridView.DataSource = dt;
        }
        private void Pharmacy_Load(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            cn.Connect();
            sCn = cn.WindowsAuth;
            conn = new SqlConnection(sCn);
            conn.Open();
            fillGrid();
            conn.Close();
        }

        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(userEmailData);
            menu.Show();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conn.Open();
            string consulta= "SELECT product AS[Product Name], price AS [Price] FROM inventory WHERE product='"+ ProductTxtBox.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            PharmacyGridView.DataSource = dt;
            SqlCommand command = new SqlCommand(consulta, conn);
            SqlDataReader dataReader;
            dataReader = command.ExecuteReader();
            refreshBtn.Show();
            conn.Close();

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            fillGrid();
            ProductTxtBox.Clear();
            refreshBtn.Hide();
        }

        private void PharmacyGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
