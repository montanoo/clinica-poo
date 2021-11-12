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
using System.Text.RegularExpressions;

namespace ClinicaPOO
{
    public partial class FormProfile : Form
    {
        //object to use validations in signup class
        SignUp signingup = new SignUp();

        public int currentUserId;
        public string userEmailValue;
        public string CurrentPatientID;
        //for connection to sql
        private SqlConnection connector;
        private SqlCommand insertcommand;
        private SqlCommand insertcommand2;
        private string sqlConn;

        public FormProfile(string userEmail)
        {
            InitializeComponent();
            Connection access = new Connection();
            access.Connect();
            sqlConn = access.WindowsAuth;
            connector = new SqlConnection(sqlConn);
            connector.Open();
            userEmailValue = userEmail;
        }
        //Show current info everytime the form loads
        private void FormProfile_Load(object sender, EventArgs e)
        {
            ShowCurrentInfo();
        }

        //When edit button is pressed, read only will be disabled and the font style will turn bold
        private void btnEditName_Click(object sender, EventArgs e)
        {
            txtName.ReadOnly = false;
            txtName.Font = new Font(txtName.Font, FontStyle.Bold);
        }

        private void btnEditLastn_Click(object sender, EventArgs e)
        {
            txtLastname.ReadOnly = false;
            txtLastname.Font = new Font(txtLastname.Font, FontStyle.Bold);
        }

        private void btnEditEmail_Click(object sender, EventArgs e)
        {
            txtEmail.ReadOnly = false;
            txtEmail.Font = new Font(txtEmail.Font, FontStyle.Bold);
        }

        private void btnEditPwd_Click(object sender, EventArgs e)
        {
            txtPassword.ReadOnly = false;
            txtPassword.Font = new Font(txtPassword.Font, FontStyle.Bold);
        }

        private void btnEditPhone_Click(object sender, EventArgs e)
        {
            txtPhone.ReadOnly = false;
            txtPhone.Font = new Font(txtPhone.Font, FontStyle.Bold);
        }
        //When edit button is pressed enable datetime picker
        private void btnEditBirth_Click(object sender, EventArgs e)
        {
            dTPbirth.Enabled = true;
        }

        //When saving changes, check if password is valid
        private void btnSave_Click(object sender, EventArgs e)
        {
            SignUpUser checkPassword = new SignUpUser();
            
            if (checkPassword.WeakPassword(txtPassword) == true)
            {
                MessageBox.Show("Password must have more than 8 characters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //try
                //{
                    //Update the edited info
                    UpdateInfo();
                    insertcommand.ExecuteNonQuery();
                    insertcommand2.ExecuteNonQuery();
                    connector.Close();
                    MessageBox.Show("Your changes have been saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Return to menu automatically
                    Menu showmenu = new Menu(txtEmail.Text);
                    showmenu.Show();
                    this.Close();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show($"An error has ocurred: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            //Return to default font styles and enable read only
            txtName.Font = new Font(txtName.Font, FontStyle.Regular);
            txtLastname.Font = new Font(txtLastname.Font, FontStyle.Regular);
            txtEmail.Font = new Font(txtEmail.Font, FontStyle.Regular);
            txtPassword.Font = new Font(txtPassword.Font, FontStyle.Regular);
            txtPhone.Font = new Font(txtPhone.Font, FontStyle.Regular);
            txtName.ReadOnly = true;
            txtLastname.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtPassword.ReadOnly = true;
            txtPhone.ReadOnly = true;
            dTPbirth.Enabled = false;
        }

        private void ShowCurrentInfo()
        {
            string seleccion;
            //Searches for logged in patient in the database
            seleccion = "Select * From patient where email= '" + userEmailValue + "'";
            SqlDataAdapter da1 = new SqlDataAdapter(seleccion, connector);
            SqlParameter prm = new SqlParameter("email", SqlDbType.VarChar);
            prm.Value = userEmailValue;
            da1.SelectCommand.Parameters.Add(prm);
            SqlDataReader dr1 = da1.SelectCommand.ExecuteReader();
            //Fills the textboxes with the patient's registered information
            while (dr1.Read())
            {
                CurrentPatientID = dr1["id"].ToString().Trim();
                txtName.Text = dr1["name"].ToString().Trim();
                txtLastname.Text = dr1["lastname"].ToString().Trim();
                txtEmail.Text = dr1["email"].ToString().Trim();
                txtDUI.Text = dr1["dui"].ToString().Trim();
                txtPhone.Text = dr1["phone"].ToString().Trim();
                dTPbirth.Value = (DateTime)dr1["birthdate"];
            }
            dr1.Close();




            seleccion = "SELECT [password] FROM patient p INNER JOIN [user] u ON u.id = p.[user_id] where email= '" + userEmailValue + "'";
            SqlDataAdapter da2 = new SqlDataAdapter(seleccion, connector);
            SqlParameter prm2 = new SqlParameter("email", SqlDbType.VarChar);
            prm2.Value = userEmailValue;
            da2.SelectCommand.Parameters.Add(prm2);
            SqlDataReader dr2 = da2.SelectCommand.ExecuteReader();
            while (dr2.Read())
            {
                txtPassword.Text = dr2["password"].ToString().Trim();
            }
            dr2.Close();
        }
        //Updates all info and makes the necessary changes
        private void UpdateInfo()
        {
            string updateuser;

            updateuser = "UPDATE patient SET name= @pname, lastname= @plastname, email= @pemail, ";
            updateuser += "phone= @pphone, birthdate = @pbirthdate WHERE id= @ppatientid";
            insertcommand = new SqlCommand(updateuser, connector);
            insertcommand.Parameters.Add(new SqlParameter("@pname", SqlDbType.VarChar));
            insertcommand.Parameters["@pname"].Value = txtName.Text;
            insertcommand.Parameters.Add(new SqlParameter("@plastname", SqlDbType.VarChar));
            insertcommand.Parameters["@plastname"].Value = txtLastname.Text;
            insertcommand.Parameters.Add(new SqlParameter("@pemail", SqlDbType.VarChar));
            insertcommand.Parameters["@pemail"].Value = txtEmail.Text;

            insertcommand.Parameters.Add(new SqlParameter("@pphone", SqlDbType.VarChar));
            insertcommand.Parameters["@pphone"].Value = txtPhone.Text;
            insertcommand.Parameters.Add(new SqlParameter("@pbirthdate", SqlDbType.Date));
            insertcommand.Parameters["@pbirthdate"].Value = dTPbirth.Text;
            insertcommand.Parameters.Add(new SqlParameter("@ppatientid", SqlDbType.VarChar));
            insertcommand.Parameters["@ppatientid"].Value = CurrentPatientID;

            // Seleccion del user_id para modificarlo en la tabla user.

            Connection sqlVariables = new Connection();
            sqlVariables.Connect();
            string connectString = sqlVariables.WindowsAuth;
            SqlConnection windowsAuthConn = new SqlConnection(connectString);
            string sql = "SELECT user_id FROM patient WHERE [email] = @pEmail";
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@pEmail", userEmailValue);
                try
                {
                    conn.Open();
                    currentUserId = (int)cmd.ExecuteScalar(); // Obtenemos el string del email.
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        
            string updatePassword;
            updatePassword = "UPDATE [user] SET password = @ppassword ";
            updatePassword += "WHERE id = @puserid";
            insertcommand2 = new SqlCommand(updatePassword, connector);
            insertcommand2.Parameters.Add(new SqlParameter("@ppassword", SqlDbType.VarChar));
            insertcommand2.Parameters["@ppassword"].Value = txtPassword.Text;
            insertcommand2.Parameters.Add(new SqlParameter("@puserid", SqlDbType.VarChar));
            insertcommand2.Parameters["@puserid"].Value = currentUserId;
        }
        //Checks if email is valid once focus leaves the textbox
        private void txtEmail_Leave(object sender, EventArgs e)
        {

            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Invalid email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.SelectAll();
                txtEmail.Focus();
            }
        }
        //Return to menu with return button
        private void button1_Click(object sender, EventArgs e)
        {
            Menu showmenu = new Menu(userEmailValue);
            showmenu.Show();
            this.Hide();
        }
        private bool IsValidEmail(string pemail)
        {
            string expression = @"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$";

            if (Regex.IsMatch(pemail, expression))
            {
                if (Regex.Replace(pemail, expression, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
