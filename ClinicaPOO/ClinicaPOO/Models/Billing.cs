using System;
using System.Collections.Generic;

#nullable disable

namespace ClinicaPOO.Models
{
    public partial class Billing
    {
        public int Id { get; set; }
        public int? PatientId { get; set; }
        public int? MethodId { get; set; }
        public int? MedicineId { get; set; }
        public int? MedicineQuantity { get; set; }
        public double? Total { get; set; }

        public virtual Inventory Medicine { get; set; }
        public virtual Method Method { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
