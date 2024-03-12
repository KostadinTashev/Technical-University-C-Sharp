using System;
using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;
namespace Welcome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Names = "Kostadin Tashev";
            user.Password = "123654789";
            user.Role = UserRolesEnum.ADMIN;
            user.FacultyNumber = "121221132";
            user.Email = "kotashev@tu-sofia.bg";

            UserViewModel viewModel = new UserViewModel(user);
            UserView userView = new UserView(viewModel);
            userView.Display();
            Console.ReadKey();
        }
    }
}