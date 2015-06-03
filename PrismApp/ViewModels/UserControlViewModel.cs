using System;
using System.IO;
using Microsoft.Practices.Prism.StoreApps;
using Microsoft.Practices.Prism.StoreApps.Interfaces;

namespace PrismApp.ViewModels
{
    public class UserControlViewModel : ViewModel
    {
        private INavigationService _navigationService;
        private int _value;

        public int Value
        {
            get { return _value; }
            set { SetProperty(ref _value, value); }
        }

        public UserControlViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            OnButtonClickedCommand = new DelegateCommand(ButtonClick);
        }

        private void ButtonClick()
        {
            if (Value == 100)
                Value = 0;
            else
                Value += 10;
        }

        public DelegateCommand OnButtonClickedCommand { get; set; }
    }
}
