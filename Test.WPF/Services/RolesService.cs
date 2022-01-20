using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Data.Models;

namespace Test.WPF.Services
{
    public class RolesService
    {
        public List<Role> GetAllRoles()
        {
            using (WorldSkillsDbContext ctx = new())
            {
                return ctx.Roles.ToList();
            }
        }
        public Role Get(Role role)
        {
            using (WorldSkillsDbContext ctx = new())
            {
                return ctx.Roles.FirstOrDefault(x => x==role);
            }
        }
    }


}
