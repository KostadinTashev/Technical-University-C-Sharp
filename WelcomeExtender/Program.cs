using System;
using Welcome.Model;
using Welcome.Others;
using Welcome.ViewModel;
using Welcome.View;
using WelcomeExtended.Others;
using WelcomeExtender.Others;
namespace WelcomeExtender
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var user = new User
                {
                    Names = "Kostadin Tashev",
                    Password = "123654789",
                    Role = UserRolesEnum.STUDENT
                };

                var viewModel = new UserViewModel(user);

                var view = new UserView(viewModel);
                view.Display();

                view.DisplayError();
            }
            catch (Exception e)
            {
                var log = new ActionOnError(Delegates.Log);
                log(e.Message);
            }
            finally
            {
                Console.WriteLine("Executed in any case!");
            }
        }
    }
}
