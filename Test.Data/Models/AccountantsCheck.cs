using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Data.Models
{
    public partial class AccountantsCheck
    {
        public int Id { get; set; }
        public int AccountantId { get; set; }
        public int CheckId { get; set; }

        public virtual Accountant Accountant { get; set; }
        public virtual Check Check { get; set; }
    }
}
