using System;
using System.Collections.Generic;

namespace Customer.Models
{
    public partial class Customerinf
    {
        public Customerinf()
        {
            Payments = new HashSet<Payment>();
        }

        public int Phonenumber { get; set; }
        public string? Customername { get; set; }
        public string? Addres { get; set; }
        public string? Sex { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
    }
}
