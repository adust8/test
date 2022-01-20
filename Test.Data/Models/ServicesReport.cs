using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Data.Models
{
    public partial class ServicesReport
    {
        public int Id { get; set; }
        public int LaborantId { get; set; }
        public int ServicesId { get; set; }
        public DateTime Date { get; set; }

        public virtual Laborant Laborant { get; set; }
        public virtual Service Services { get; set; }
    }
}
