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
    public partial class FormProfile : Form
    {
        //object to use validations in signup class
        SignUp signingup = new SignUp();

        public string userEmailValue;
        public string CurrentPatientID;
        //for connection to sql
        private SqlConnection connector;
        private SqlCommand insertcommand;
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
                try
                {
                    //Update the edited info
                    UpdateInfo();
                    insertcommand.ExecuteNonQuery();
                    connector.Close();
                    MessageBox.Show("Your changes have been saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Return to menu automatically
                    Menu showmenu = new Menu(txtEmail.Text);
                    showmenu.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error has ocurred: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                txtPassword.Text = dr1["password"].ToString().Trim();
                txtDUI.Text = dr1["dui"].ToString().Trim();
                txtPhone.Text = dr1["phone"].ToString().Trim();
                dTPbirth.Value = (DateTime)dr1["birthdate"];
            }
            dr1.Close();
        }
        //Updates all info and makes the necessary changes
        private void UpdateInfo()
        {
            string updateuser;

            updateuser = "UPDATE patient SET name= @pname, lastname= @plastname, email= @pemail, password= @ppassword,";
            updateuser += "phone= @pphone, birthdate = @pbirthdate WHERE id= @ppatientid";
            insertcommand = new SqlCommand(updateuser, connector);
            insertcommand.Parameters.Add(new SqlParameter("@pname", SqlDbType.VarChar));
            insertcommand.Parameters["@pname"].Value = txtName.Text;
            insertcommand.Parameters.Add(new SqlParameter("@plastname", SqlDbType.VarChar));
            insertcommand.Parameters["@plastname"].Value = txtLastname.Text;
            insertcommand.Parameters.Add(new SqlParameter("@pemail", SqlDbType.VarChar));
            insertcommand.Parameters["@pemail"].Value = txtEmail.Text;
            insertcommand.Parameters.Add(new SqlParameter("@ppassword", SqlDbType.VarChar));
            insertcommand.Parameters["@ppassword"].Value = txtPassword.Text;
            insertcommand.Parameters.Add(new SqlParameter("@pphone", SqlDbType.VarChar));
            insertcommand.Parameters["@pphone"].Value = txtPhone.Text;
            insertcommand.Parameters.Add(new SqlParameter("@pbirthdate", SqlDbType.Date));
            insertcommand.Parameters["@pbirthdate"].Value = dTPbirth.Text;
            insertcommand.Parameters.Add(new SqlParameter("@ppatientid", SqlDbType.VarChar));
            insertcommand.Parameters["@ppatientid"].Value = CurrentPatientID;
        }
        //Checks if email is valid once focus leaves the textbox
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!signingup.validemail(txtEmail.Text))
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
    }
}
