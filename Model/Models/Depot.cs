using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class Depot
    {
        public Depot()
        {
            Orderings = new HashSet<Ordering>();
        }

        public int CarId { get; set; }
        public string? CarName { get; set; }
        public DateTime? Inputdate { get; set; }
        public DateTime? Salesdate { get; set; }
        public int? Amount { get; set; }
        public int? Sold { get; set; }

        public virtual ICollection<Ordering> Orderings { get; set; }
    }
}
