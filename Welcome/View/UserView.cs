using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.View;
using Welcome.ViewModel;
using Welcome.Others;
namespace Welcome.View
{
    internal class UserView
    {
        private UserViewModel _viewModel;
        public UserView(UserViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public void Display()
        {
            if(_viewModel.Role == UserRolesEnum.ADMIN)
            {
                Console.WriteLine("Welcome");
                Console.WriteLine("User:" + _viewModel.Names);
                Console.WriteLine("Password:" + _viewModel.Password);
                Console.WriteLine("Role:" + _viewModel.Role);
                Console.WriteLine("FacultyNumber:" + _viewModel.FacultyNumber);
                Console.WriteLine("Email:" + _viewModel.Email);
            }
            else
            {
                Console.WriteLine("Welcome");
                Console.WriteLine("User:" + _viewModel.Names);
                Console.WriteLine("Password:" + _viewModel.EcryptedPassword);
                Console.WriteLine("Role:" + _viewModel.Role);
            }
            
        }
    }
    
}