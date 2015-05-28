using Microsoft.Practices.Prism.StoreApps;
using Microsoft.Practices.Prism.StoreApps.Interfaces;

namespace PrismApp.ViewModels
{
    public class ServicesPageViewModel : ViewModel
    {
        private INavigationService _navigationService;

        public string Service { get { return "Service"; } }

        public ServicesPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
