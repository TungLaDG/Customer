using System;
using System.Collections.Generic;

namespace Customer.Models
{
    public partial class Car
    {
        public Car()
        {
            Orderings = new HashSet<Ordering>();
            Payments = new HashSet<Payment>();
        }

        public string FrameId { get; set; } = null!;
        public string? CarName { get; set; }
        public string? Origin { get; set; }
        public int? Model { get; set; }
        public int? Cc { get; set; }
        public string? Size { get; set; }
        public string? Hp { get; set; }
        public string? Gear { get; set; }
        public string? Enginetype { get; set; }
        public string? Color { get; set; }
        public int? CategoryId { get; set; }
        public string? Imageurl { get; set; }
        public decimal? Price { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<Ordering> Orderings { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
