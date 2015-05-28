using System.Collections.ObjectModel;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using Microsoft.Practices.Prism.StoreApps;
using Microsoft.Practices.Prism.StoreApps.Interfaces;
using PrismApp.Models;

namespace PrismApp.ViewModels
{
    public class HubPageViewModel : ViewModel
    {
        private INavigationService _navigationService;
        private readonly DelegateCommand<HubSectionHeaderClickEventArgs> _hubSectionHeaderCommand;

        public string Company
        {
            get { return "Company"; }
        }

        public string Services
        {
            get { return "Services"; }
        }

        public string About
        {
            get { return "About"; }
        }

        public string CompanySubHeader
        {
            get { return "ArcTouch - App Development Studio"; }
        }

        public string CompanyDescription
        {
            get { return "ArcTouch is a full-service mobile app development company headquartered in San Francisco. Our world-class application developers, designers and mobile strategists create custom smartphone and tablet apps for iOS, Android, Windows, and HTML5 platforms. We have launched more than 200 projects for Fortune 500 companies, leading consumer brands, innovative startups, media & entertainment companies, and world-class marketing and design agencies."; }
        }

        public string ServiceItem
        {
            get { return "Comprehensive mobile app development services"; }
        }

        public string ServiceItemDescription
        {
            get { return "ArcTouch creates indispensable enterprise and consumer apps for mobile devices, wearables and the Internet of Things (IoT). We develop for iOS, Android, Windows, and HTML5 platforms, and produce native, web, and hybrid apps."; }
        }

        public string SubServiceItem
        {
            get { return "SubServiceItem"; }
        }

        public string SubServiceItemDescription
        {
            get { return "kcLorem ipsum dolor sit amet, consectetuer ising elit, sed diam nonummy nibh uismod tincidunt ut laoreet suscipit lobortis ni ut wisi quipexerci quis consequat minim veniam, quis nostrud exerci tation ullam corper. Lorem ipsum dolor sit amet, consectetuer ising elit, sed diam nonummy nibh uismod tincidunt ut laoreet suscipit lobortis ni ut wisi quipexerci quis consequat minim veniam, quis nostrud exerci tation ullam corper."; }
        }

        public string ArcTouch
        {
            get { return "ArcTouch"; }
        }

        public string AboutText
        {
            get { return "Lorem ipsum dolor sit amet, consectetuer ising elit, sed diam nonummy nibh uismod tincidunt ut laoreet suscipit lobortis ni ut wisi quipexerci quis consequat minim veniam, quis nostrud exerci tation ullam corper. Lorem ipsum dolor sit amet, consectetuer ising elit, sed diam nonummy nibh uismod tincidunt ut laoreet suscipit lobortis ni ut wisi quipexerci quis consequat minim veniam, quis nostrud exerci tation ullam corper."; }
        }

        public DelegateCommand<HubSectionHeaderClickEventArgs> HubSectionHeaderCommand
        {
            get { return _hubSectionHeaderCommand; }
        }

        public ObservableCollection<Service> ServiceItems
        {
            get
            {
                return new ObservableCollection<Service>
                {
                    new Service {Name = "Enterprise Apps", Description = "ArcTouch creates mobile experiences to serve the unique needs and varied audiences inside the enterprise, whether its an app for your distributed workforce or its partners."},
                    new Service {Name = "Consumer Apps", Description = "Every time your customer answers the phone, checks the time, or pats his or her pocket—your mobile app is there. ArcTouch develops brand-building consumer apps that grow your market."},
                    new Service {Name = "Innovative Apps", Description = "A great mobile app engages users without them even realizing it. With ArcTouch apps, each piece of information offers value, each screen tells a story, and each touch or swipe causes an intuitive response."}
                };
            }
        }

        public HubPageViewModel(INavigationService navigationService)
        {
            _hubSectionHeaderCommand = new DelegateCommand<HubSectionHeaderClickEventArgs>(HubSectionHeaderClick);
            _navigationService = navigationService;
        }

        private void HubSectionHeaderClick(HubSectionHeaderClickEventArgs args)
        {
            switch (args.Section.Name)
            {
                case "Company":
                    _navigationService.Navigate("Company", null);
                    break;
                case "Services":
                    _navigationService.Navigate("Services", null);
                    break;
            }
        }

        /// <summary>
        /// Created just for the design time.
        /// </summary>
        public HubPageViewModel()
        {
        }
    }
}