using System;
using System.Collections.Generic;

#nullable disable

namespace SimpleHouse.Models
{
    public partial class About
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string Picture { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? DisplayIndex { get; set; }
    }
}
