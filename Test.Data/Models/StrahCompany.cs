using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Data.Models
{
    public partial class StrahCompany
    {
        public StrahCompany()
        {
            Checks = new HashSet<Check>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Inn { get; set; }
        public string Rs { get; set; }
        public string Bik { get; set; }

        public virtual ICollection<Check> Checks { get; set; }
    }
}
