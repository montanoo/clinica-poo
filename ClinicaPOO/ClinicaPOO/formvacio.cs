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
    public partial class formvacio : Form
    {
        public formvacio()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppointmentBooking formu = new AppointmentBooking(textBox1.Text);
            formu.Show();
            this.Hide();
        }
    }
}
