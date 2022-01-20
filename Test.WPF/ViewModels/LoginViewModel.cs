using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Test.Data.Models;
using Test.WPF.Commands;
using Test.WPF.Services;

namespace Test.WPF.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly RolesService _rolesService;
        public LoginViewModel()
        {
            _rolesService = new();
            LoginCommand = new LoginCommand(this);
        }
        private string _login;

        public string Login
        {
            get { return _login; }
            set => Set(ref _login,value);
        }
        private string _password;

        public string Password
        {
            get { return _password; }
            set => Set(ref _password, value);
        }

        public List<Role> Roles => _rolesService.GetAllRoles();
        private Role _role;

        public Role Role
        {
            get { return _role; }
            set => Set(ref _role, value);
        }
        public ICommand LoginCommand { get; set; }
        private string _status;

        public string Status
        {
            get => _status;
            set => Set(ref _status, value);
        }
        private bool _success;

        public bool Success
        {
            get => _success;
            set => Set(ref _success, value);
        }

    }
}
