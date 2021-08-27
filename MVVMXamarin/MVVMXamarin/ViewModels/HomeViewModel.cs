using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using MVVMXamarin.Models;
using MVVMXamarin.Services;

namespace MVVMXamarin.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public MenuOption BarAndHotelsMenuOption { get; set; } = new MenuOption();
        public MenuOption FreeDinningMenuOption { get; set; } = new MenuOption();
        public MenuOption CafesMenuOption { get; set; } = new MenuOption();
        public MenuOption NearbyMenuOption { get; set; } = new MenuOption();
        public MenuOption FastFoodsMenuOption { get; set; } = new MenuOption();
        public MenuOption FeaturedFoodsMenuOption { get; set; } = new MenuOption();

    }
        
        public HomeViewModel(IAlertService alertService, INavigationService navigationService) : base(alertService, navigationService)
        {
            
        }
}
