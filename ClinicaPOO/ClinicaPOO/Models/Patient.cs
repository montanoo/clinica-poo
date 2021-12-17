using System;
using System.Collections.Generic;

#nullable disable

namespace ClinicaPOO.Models
{
    public partial class Patient
    {
        public Patient()
        {
            Appointments = new HashSet<Appointment>();
            Billings = new HashSet<Billing>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Dui { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? Birthdate { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Billing> Billings { get; set; }
    }
}
