using MVVMXamarin.Services;
using MVVMXamarin.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;


namespace MVVMXamarin.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        public ICommand RegisterCommand { get; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public RegisterViewModel(IAlertService alertService, INavigationService navigationService) : base(alertService, navigationService)
        {
            RegisterCommand = new Command(OnRegister);
        }

        private async void OnRegister()
        {
            Console.WriteLine("Enter Method");
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(ConfirmPassword))
            {
                await AlertService.AlertAsync("Error!", "You must fill in all the fields");
            }
            else if (Password != ConfirmPassword)
            {
                await AlertService.AlertAsync("Error!", "The passwords entered are different");
            }
            else
            {
                await AlertService.AlertAsync("Welcome", "Hello, " + Name);
                await NavigationService.NavigationAsync(new HomeTabbedPage(), false);
            }

        }
    }
}