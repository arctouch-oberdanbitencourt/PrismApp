using System;
using Windows.UI.Xaml.Controls;
using Microsoft.Practices.Prism.StoreApps;
using PrismApp.Common;
using PrismApp.Util;

namespace PrismApp.ViewModels
{
    public class ServicesPageViewModel : ViewModel
    {
        public string Services { get { return Constants.Services; } }
    }
}