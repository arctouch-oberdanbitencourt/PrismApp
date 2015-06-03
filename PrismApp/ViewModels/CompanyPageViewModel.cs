using Microsoft.Practices.Prism.StoreApps;
using Microsoft.Practices.Prism.StoreApps.Interfaces;
using PrismApp.Common;

namespace PrismApp.ViewModels
{
    public class CompanyPageViewModel : ViewModel
    {
        private INavigationService _navigationService;

        public string Company { get { return Constants.Company; } }

        public CompanyPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
