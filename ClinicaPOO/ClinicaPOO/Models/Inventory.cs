using System;
using System.Collections.Generic;

#nullable disable

namespace ClinicaPOO.Models
{
    public partial class Inventory
    {
        public Inventory()
        {
            Billings = new HashSet<Billing>();
        }

        public int Id { get; set; }
        public string Product { get; set; }
        public int? Quantity { get; set; }
        public double? Price { get; set; }

        public virtual ICollection<Billing> Billings { get; set; }
    }
}
