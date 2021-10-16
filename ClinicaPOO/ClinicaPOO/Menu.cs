using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaPOO
{
    public partial class Menu : Form
    {
        public Menu(string userEmail)
        {
            InitializeComponent();
        }

        private void btnBookApp_Click(object sender, EventArgs e)
        {
            
        }

        private void btnListApp_Click(object sender, EventArgs e)
        {
            FormListOfAppointments listOfAppointments = new FormListOfAppointments();

        }
    }
}
