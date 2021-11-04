using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ClinicaPOO
{
    class AddMethods
    {
        private SqlConnection connector;
        private SqlCommand insertcommand;
        private string sqlConn;

        private string name, description;
        private double price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public bool AddNewMethod (TextBox txtName, TextBox txtDescription, TextBox txtPrice)
        {
            Connection access = new Connection();
            access.Connect();
            sqlConn = access.WindowsAuth;
            connector = new SqlConnection(sqlConn);
            connector.Open();

            if (txtName.Text == "" || txtDescription.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Complete all fields please", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                try
                {
                    Name = txtName.Text;
                    Description = txtDescription.Text;
                    Price = double.Parse(txtPrice.Text);

                    InsertIntoMethods(Name, Description, Price);
                    insertcommand.ExecuteNonQuery();
                    connector.Close();

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error has ocurred: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        public void InsertIntoMethods(string name, string description, double price)
        {
            string insertDentist;

            insertDentist = "INSERT INTO methods (name, description, price) ";
            insertDentist += "VALUES (@pName, @pDescription, @pPrice)";
            insertcommand = new SqlCommand(insertDentist, connector);
            insertcommand.Parameters.Add(new SqlParameter("@pName", SqlDbType.VarChar));
            insertcommand.Parameters["@pName"].Value = name;
            insertcommand.Parameters.Add(new SqlParameter("@pDescription", SqlDbType.VarChar));
            insertcommand.Parameters["@pDescription"].Value = description;
            insertcommand.Parameters.Add(new SqlParameter("@pPrice", SqlDbType.Float));
            insertcommand.Parameters["@pPrice"].Value = price;
        }
    }
}
