using System;
using System.Collections.Generic;

namespace Customer.Models
{
    public partial class Ordering
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int? CarId { get; set; }
        public DateTime? Receivedate { get; set; }
        public string? FrameId { get; set; }

        public virtual Depot? Car { get; set; }
        public virtual Car? Frame { get; set; }
    }
}
