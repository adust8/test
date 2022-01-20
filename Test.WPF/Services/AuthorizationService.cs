using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Data.Models;
using Test.WPF.Exceptions;

namespace Test.WPF.Services
{
    internal class AuthorizationService
    {
        private readonly UsersService _usersService;
        public AuthorizationService()
        {
            _usersService = new UsersService();
        }
        public static User CurrentUser { get; private set; }
        public void Authorize(User user)
        {
            if (user == null)
                throw new UserNotFound();

            CurrentUser = user;
        }
    }
}
