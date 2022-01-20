using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Data.Models
{
    public partial class AccountantsService
    {
        public int Id { get; set; }
        public int AccountantId { get; set; }
        public int ServiceId { get; set; }

        public virtual Accountant Accountant { get; set; }
        public virtual Service Service { get; set; }
    }
}
