using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Test.Data.Models;
using Test.WPF.Exceptions;
using Test.WPF.Services;
using Test.WPF.ViewModels;

namespace Test.WPF.Commands
{
    internal class LoginCommand : BaseCommand
    {
        private readonly LoginViewModel _loginViewModel;
        private readonly AuthorizationService _authService;
        private readonly UsersService _usersService;

        public LoginCommand(LoginViewModel loginViewModel)
        {
            _usersService = new();
            _authService=new AuthorizationService();
            _loginViewModel = loginViewModel;
        }

        public override bool CanExecute(object parameter) => !string.IsNullOrWhiteSpace(_loginViewModel.Login)
            && !string.IsNullOrWhiteSpace(_loginViewModel.Password)
            && _loginViewModel.Role != null;
        public override void Execute(object parameter)
        {
            try
            {
                User user = _usersService.GetUserByLoginAndPassword(_loginViewModel.Login,_loginViewModel.Password,_loginViewModel.Role);
                _authService.Authorize(user);
                _loginViewModel.Status = "Success";
                _loginViewModel.Success = true;
            }
            catch (UserNotFound e)
            {
                _loginViewModel.Status = "Неправильный логин или пароль";
                _loginViewModel.Success = false;
            }
            
        }
    }
}
