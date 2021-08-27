﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVMXamarin.Services
{
    public class NavigationService : INavigationService
    {
        public Task NavigationAsync(Page page, bool navigationBar)
        {
            if (!navigationBar)
            {
                NavigationPage.SetHasNavigationBar(page, false);
            }
            return App.Current.MainPage.Navigation.PushAsync(page);
        }
    }
}
