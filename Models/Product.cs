using System;
using System.Collections.Generic;

#nullable disable

namespace SimpleHouse.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public int? DisplayIndex { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
