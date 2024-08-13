using System;
using System.Collections.Generic;

namespace Customer.Models
{
    public partial class Contact
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? PhoneNumber { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string? Content { get; set; }
        public string? Address { get; set; }
        //public virtual User? UserNavigation { get; set; }

    }
}
