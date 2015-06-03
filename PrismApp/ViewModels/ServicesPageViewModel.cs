using System;
using Windows.UI.Xaml.Controls;
using Microsoft.Practices.Prism.StoreApps;
using Microsoft.Practices.Prism.StoreApps.Interfaces;

namespace PrismApp.ViewModels
{
    public class ServicesPageViewModel : ViewModel
    {
        public string Service { get { return "Services"; } }

        public ServicesPageViewModel()
        {
        }
    }
}
