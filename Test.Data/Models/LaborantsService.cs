using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Data.Models
{
    public partial class LaborantsService
    {
        public int Id { get; set; }
        public int LaborantId { get; set; }
        public int ServiceCode { get; set; }

        public virtual Laborant Laborant { get; set; }
        public virtual Service ServiceCodeNavigation { get; set; }
    }
}
