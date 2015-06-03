using System;
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
        private readonly DelegateCommand<HubSectionHeaderClickEventArgs> _sectionHeaderCommand;
        private readonly DelegateCommand<SearchBoxQuerySubmittedEventArgs> _searchQuerySubmittedCommand;
        private readonly DelegateCommand<SearchBoxSuggestionsRequestedEventArgs> _searchQuerySuggestionsRequestedCommand;

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

        public DelegateCommand<HubSectionHeaderClickEventArgs> SectionHeaderCommand
        {
            get { return _sectionHeaderCommand; }
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

        public ObservableCollection<string> SearchSuggestionsList
        {
            get
            {
                return new ObservableCollection<string>
                {
                    "Company",
                    "Services"
                };
            }
        }

        public DelegateCommand<SearchBoxQuerySubmittedEventArgs> SearchQuerySubmittedCommand
        {
            get { return _searchQuerySubmittedCommand; }
        }

        public DelegateCommand<SearchBoxSuggestionsRequestedEventArgs> SearchQuerySuggestionsRequestedCommand
        {
            get { return _searchQuerySuggestionsRequestedCommand; }
        }

        public HubPageViewModel(INavigationService navigationService)
        {
            _sectionHeaderCommand = new DelegateCommand<HubSectionHeaderClickEventArgs>(HandleSectionHeaderClick);
            _searchQuerySubmittedCommand = new DelegateCommand<SearchBoxQuerySubmittedEventArgs>(HandleSearchQuerySubmitted);
            _searchQuerySuggestionsRequestedCommand = new DelegateCommand<SearchBoxSuggestionsRequestedEventArgs>(HandleSearchQuerySuggestionsRequested);
            _navigationService = navigationService;
        }

        private void HandleSearchQuerySuggestionsRequested(SearchBoxSuggestionsRequestedEventArgs args)
        {
            string queryText = args.QueryText;
            if (!string.IsNullOrEmpty(queryText))
            {
                Windows.ApplicationModel.Search.SearchSuggestionCollection suggestionCollection = args.Request.SearchSuggestionCollection;
                foreach (string suggestion in SearchSuggestionsList)
                {
                    if (suggestion.StartsWith(queryText, StringComparison.CurrentCultureIgnoreCase))
                    {
                        suggestionCollection.AppendQuerySuggestion(suggestion);
                    }
                }
            }
        }

        private void HandleSearchQuerySubmitted(SearchBoxQuerySubmittedEventArgs args)
        {
            var queryText = args.QueryText;
            if (!string.IsNullOrEmpty(queryText))
            {
                NavigateToPage(queryText);
            }
        }

        private void HandleSectionHeaderClick(HubSectionHeaderClickEventArgs args)
        {
            NavigateToPage(args.Section.Name);
        }

        private void NavigateToPage(string pageName)
        {
            switch (pageName.ToLower())
            {
                case "company":
                    _navigationService.Navigate("Company", null);
                    break;
                case "services":
                    _navigationService.Navigate("Services", null);
                    break;
                case "test":
                    _navigationService.Navigate("Test", null);
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