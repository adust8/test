using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Data.Models
{
    public partial class SocialType
    {
        public SocialType()
        {
            Patients = new HashSet<Patient>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }
    }
}
