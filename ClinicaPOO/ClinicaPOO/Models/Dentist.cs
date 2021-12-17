using System;
using System.Collections.Generic;

#nullable disable

namespace ClinicaPOO.Models
{
    public partial class Dentist
    {
        public Dentist()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public int? Status { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
