using System;
using Windows.UI.Xaml.Controls;
using Microsoft.Practices.Prism.StoreApps;
using Microsoft.Practices.Prism.StoreApps.Interfaces;

namespace PrismApp.ViewModels
{
    public class TestPageViewModel : ViewModel
    {
        private string _formattedCurrency;

        public string ShortDateTimeNow { get; set; }

        public string LongDateTimeNow { get; set; }

        public ComboBoxItem CurrencySelectedObject { get; set; }

        public string CurrencyCode { get { return CurrencySelectedObject.Content as string; } }

        public string Test { get { return "Test"; } }

        public DelegateCommand CurrencySelectionChangedCommand { get; set; }

        public string FormattedCurrency
        {
            get { return _formattedCurrency; }
            private set { SetProperty(ref _formattedCurrency, value); }
        }

        private void CurrencySelectionChanged()
        {
            FormattedCurrency = (string.IsNullOrEmpty(CurrencyCode))
                ? string.Empty
                : Util.Currency.Format(CurrencyCode, 2380.97d);
        }

        public TestPageViewModel()
        {
            CurrencySelectionChangedCommand = new DelegateCommand(CurrencySelectionChanged);
            var now = DateTime.Now;
            ShortDateTimeNow = Util.DateTimeFormat.ToShortDateTimeFormat(now);
            LongDateTimeNow = Util.DateTimeFormat.ToLongtDateTimeFormat(now);
        }
    }
}