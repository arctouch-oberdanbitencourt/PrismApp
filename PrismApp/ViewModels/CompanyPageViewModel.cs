using Microsoft.Practices.Prism.StoreApps;
using Microsoft.Practices.Prism.StoreApps.Interfaces;

namespace PrismApp.ViewModels
{
    public class CompanyPageViewModel : ViewModel
    {
        private INavigationService _navigationService;

        public string Company { get { return "Company"; } }

        public CompanyPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
