using System;
using System.Collections.Generic;

#nullable disable

namespace ClinicaPOO.Models
{
    public partial class User
    {
        public User()
        {
            Patients = new HashSet<Patient>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public int? RoleId { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }
    }
}
