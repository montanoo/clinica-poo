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
        private SqlCommand insert1;
        public int userId;


        public Pharmacy()
        {
            InitializeComponent();
            refreshBtn.Hide();
        }
        public Pharmacy(string email)
        {
            InitializeComponent();
            userEmailData = email;
            Connection sqlVariables = new Connection();
            sqlVariables.Connect();
            string connectString = sqlVariables.WindowsAuth;

            SqlConnection windowsAuthConn = new SqlConnection(connectString);
            string sql = "SELECT patient_id FROM patient WHERE [email] = @pEmail";
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@pEmail", email);
                try
                {
                    conn.Open();
                    userId = (int)cmd.ExecuteScalar(); // Obtenemos el string del email.
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private void fillGrid()
        {
            string consult = "select product AS[Product Name], id AS [Product ID] , price AS [Price] from inventory";
            SqlDataAdapter adapter = new SqlDataAdapter(consult, conn);
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
            try
            {
                conn.Open();
                string consult = "SELECT product AS[Product Name], id AS [Product ID] ,price AS [Price] FROM inventory WHERE product='" + ProductTxtBox.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(consult, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                PharmacyGridView.DataSource = dt;
                SqlCommand command = new SqlCommand(consult, conn);
                SqlDataReader dataReader;
                dataReader = command.ExecuteReader();
                refreshBtn.Show();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("An error occured ,product not found", "Error", MessageBoxButtons.OK);
            }

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            fillGrid();
            ProductTxtBox.Clear();
            refreshBtn.Hide();
        }



        private void PharmacyGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PharmacyGridView.Columns[e.ColumnIndex].Name == "AddProduct")
            {
                int cantidad;
                double precio, total;

                if (QtyTextBox.Text == "")
                {
                    MessageBox.Show("Insert quantity", "Notice", MessageBoxButtons.OK);
                }
                else
                {
                    cantidad = Convert.ToInt32(QtyTextBox.Text); 
                    try
                    {
                        
                        conn.Open();
                        insert1 = new SqlCommand("INSERT INTO billing (patient_id, method_id, medicine_id, medicine_quantity, total) VALUES (@patient_id, @method_id, @medicine_id, @medicine_quantity, @total )", conn);
                        insert1.Parameters.Add("@medicine_quantity", SqlDbType.Int).Value = int.Parse(QtyTextBox.Text); 
                        insert1.Parameters.Add("@patient_id", SqlDbType.Int).Value = userId;
                        insert1.Parameters.Add("@method_id", SqlDbType.Int).Value = 1; // 1 -> solo de compras.
                        insert1.Parameters.Add("@medicine_id", SqlDbType.Int).Value = PharmacyGridView.SelectedCells[2].Value;
                        precio = Convert.ToDouble(PharmacyGridView.SelectedCells[3].Value);
                        total = cantidad * precio;
                        insert1.Parameters.Add("@total", SqlDbType.Float).Value = total;
                        insert1.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show($"There was an error: {error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}
