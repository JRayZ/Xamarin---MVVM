using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVMXamarin.Services
{
    public interface INavigationService
    {
        Task NavigationAsync(Page page, bool navegationBar);
    }
}
