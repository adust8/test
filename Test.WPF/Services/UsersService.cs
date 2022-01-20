using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Data.Models;
using Test.WPF.Exceptions;

namespace Test.WPF.Services
{
    internal class UsersService
    {
        public User GetUserByLoginAndPassword(string login, string password, Role role)
        {
            using (WorldSkillsDbContext ctx = new())
            {
                return ctx.Users.FirstOrDefault(x => x.Login == login && x.Role==role && x.Password==password);               
            }
        }
    }
}
