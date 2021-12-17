using System;
using System.Collections.Generic;

#nullable disable

namespace ClinicaPOO.Models
{
    public partial class Appointment
    {
        public int Id { get; set; }
        public int? DentistId { get; set; }
        public int? PatientId { get; set; }
        public DateTime? AppointmentTime { get; set; }
        public int? MethodId { get; set; }

        public virtual Dentist Dentist { get; set; }
        public virtual Method Method { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
