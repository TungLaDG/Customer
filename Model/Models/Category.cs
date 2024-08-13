using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class Category
    {
        public Category()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string? Carbrand { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
