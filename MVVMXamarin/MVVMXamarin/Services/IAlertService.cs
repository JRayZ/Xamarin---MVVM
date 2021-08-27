using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MVVMXamarin.Services
{
    public interface IAlertService
    {
        Task AlertAsync(string title, string description);
    }
}