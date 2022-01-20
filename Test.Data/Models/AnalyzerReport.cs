using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Data.Models
{
    public partial class AnalyzerReport
    {
        public int Id { get; set; }
        public int AnalyzerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public long WorkTime { get; set; }

        public virtual Analyzer Analyzer { get; set; }
    }
}
