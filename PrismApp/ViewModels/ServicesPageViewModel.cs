using System;
using Windows.UI.Xaml.Controls;
using Microsoft.Practices.Prism.StoreApps;
using Microsoft.Practices.Prism.StoreApps.Interfaces;

namespace PrismApp.ViewModels
{
    public class ServicesPageViewModel : ViewModel
    {
        private INavigationService _navigationService;

        public string ShortDateTimeNow { get; set; }

        public string LongDateTimeNow { get; set; }

        public ComboBoxItem CurrencySelectedObject { get; set; }

        public string CurrencyCode { get { return CurrencySelectedObject.Content as string; } }

        public string Service { get { return "Service"; } }

        public DelegateCommand CurrencySelectionChangedCommand { get; set; }

        public string FormattedCurrency { get; private set; }

        public ServicesPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            CurrencySelectionChangedCommand = new DelegateCommand(CurrencySelectionChanged);
            var now = DateTime.Now;
            ShortDateTimeNow = Util.DateTimeFormat.ToShortDateTimeFormat(now);
            LongDateTimeNow = Util.DateTimeFormat.ToLongtDateTimeFormat(now);
        }

        private void CurrencySelectionChanged()
        {
            FormattedCurrency = (string.IsNullOrEmpty(CurrencyCode))
                ? string.Empty
                : Util.Currency.Format(CurrencyCode, 2380.97d);
        }

        public ServicesPageViewModel()
        {
        }
    }
}
