﻿using System;
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
        public string userEmailData;
        public Menu(string email)
        {
            InitializeComponent();
            userEmailData = email;
        }

        private void btnBookApp_Click(object sender, EventArgs e)
        {
            AppointmentBooking bookAnAppointment = new AppointmentBooking(userEmailData);
            bookAnAppointment.Show();
            this.Hide();
        }

        private void btnListApp_Click(object sender, EventArgs e)
        {
            FormListOfAppointments appointmentList = new FormListOfAppointments(userEmailData);
            appointmentList.Show();
            this.Hide();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login signOut = new Login();
            signOut.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            FormProfile profile = new FormProfile(userEmailData);
            profile.Show();
            this.Hide();
        }

        private void btnMedicines_Click(object sender, EventArgs e)
        {
            AcquiredMedicines showMedicines = new AcquiredMedicines(userEmailData);
            showMedicines.Show();
            this.Hide();
        }

        private void btnPharmacy_Click(object sender, EventArgs e)
        {
            Pharmacy showPharmacy = new Pharmacy(userEmailData);
            showPharmacy.Show();
            this.Hide();
        }

        private void btnDentists_Click(object sender, EventArgs e)
        {
            DentistInformation showDentist = new DentistInformation(userEmailData);
            showDentist.Show();
            this.Hide();
        }
    }
}
