using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Data.Models
{
    public partial class Accountant
    {
        public Accountant()
        {
            AccountantsChecks = new HashSet<AccountantsCheck>();
            AccountantsServices = new HashSet<AccountantsService>();
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public TimeSpan? LastEnterTime { get; set; }
        public DateTime LastEnterDate { get; set; }

        public virtual ICollection<AccountantsCheck> AccountantsChecks { get; set; }
        public virtual ICollection<AccountantsService> AccountantsServices { get; set; }
    }
}
