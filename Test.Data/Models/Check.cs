using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Data.Models
{
    public partial class Check
    {
        public Check()
        {
            AccountantsChecks = new HashSet<AccountantsCheck>();
        }

        public int Id { get; set; }
        public int StrahCompanyId { get; set; }
        public decimal Summary { get; set; }

        public virtual StrahCompany StrahCompany { get; set; }
        public virtual ICollection<AccountantsCheck> AccountantsChecks { get; set; }
    }
}
