using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Data.Models
{
    public partial class Service
    {
        public Service()
        {
            AccountantsServices = new HashSet<AccountantsService>();
            Orders = new HashSet<Order>();
            ServicesReports = new HashSet<ServicesReport>();
        }

        public int Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<AccountantsService> AccountantsServices { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<ServicesReport> ServicesReports { get; set; }
    }
}
