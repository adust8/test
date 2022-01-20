using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Data.Models
{
    public partial class Laborant
    {
        public Laborant()
        {
            ServicesReports = new HashSet<ServicesReport>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime LastEnterDate { get; set; }
        public TimeSpan LastEnterTime { get; set; }

        public virtual ICollection<ServicesReport> ServicesReports { get; set; }
    }
}
