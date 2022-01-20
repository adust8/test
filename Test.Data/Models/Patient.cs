using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Data.Models
{
    public partial class Patient
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string SocialSecNumber { get; set; }
        public string Ein { get; set; }
        public int SocialTypeId { get; set; }
        public string Phone { get; set; }
        public string PassportS { get; set; }
        public string PassportN { get; set; }
        public DateTime Birthdate { get; set; }
        public int Id { get; set; }
        public string InsuranceName { get; set; }
        public string InsuaranceAddress { get; set; }
        public string InsuranceInn { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public virtual SocialType SocialType { get; set; }
    }
}
