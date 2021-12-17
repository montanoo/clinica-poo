using System;
using System.Collections.Generic;

#nullable disable

namespace ClinicaPOO.Models
{
    public partial class Method
    {
        public Method()
        {
            Appointments = new HashSet<Appointment>();
            Billings = new HashSet<Billing>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double? Price { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Billing> Billings { get; set; }
    }
}
