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
    public partial class AppointmentBooking : Form
    {
        public AppointmentBooking()
        {
            //Kallahan Salas
            InitializeComponent();
            var fechaactual = DateTime.Now;
            dateTimePicker1.MinDate = fechaactual;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void methodcmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
