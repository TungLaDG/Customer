using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class Payment
    {
        public int PayId { get; set; }
        public int? Phonenumber { get; set; }
        public string? FrameId { get; set; }
        public int? Paid { get; set; }
        public int? Unpaid { get; set; }
        public string? Note { get; set; }

        public virtual Car? Frame { get; set; }
        public virtual Customerinf? PhonenumberNavigation { get; set; }
    }
}
