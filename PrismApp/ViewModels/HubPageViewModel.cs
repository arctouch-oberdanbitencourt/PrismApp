using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;
using Microsoft.Practices.Prism.StoreApps;
using Microsoft.Practices.Prism.StoreApps.Interfaces;
using PrismApp.Common;
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
            get { return Constants.Company; }
        }

        public string Services
        {
            get { return Constants.Services; }
        }

        public string About
        {
            get { return Constants.About; }
        }

        public string CompanySubHeader
        {
            get { return Constants.ArcTouchAppDevelopmentStudio; }
        }

        public string CompanyDescription
        {
            get { return Constants.ArcTouchDescription; }
        }

        public string ServiceItem
        {
            get { return Constants.ServiceItem; }
        }

        public string ServiceItemDescription
        {
            get { return Constants.ServiceItemDescription; }
        }

        public string SubServiceItem
        {
            get { return Constants.SubServiceItem; }
        }

        public string SubServiceItemDescription
        {
            get { return Constants.SubServiceItemDescription; }
        }

        public string ArcTouch
        {
            get { return Constants.ArcTouch; }
        }

        public string AboutText
        {
            get { return Constants.SubServiceItemDescription; }
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
                    new Service {Name = Constants.EnterpriseApps, Description = Constants.EnterpriseAppsDesc},
                    new Service {Name = Constants.ConsumerApps, Description = Constants.ConsumerAppsDesc},
                    new Service {Name = Constants.InnovativeApps, Description = Constants.InnovativeAppsDesc}
                };
            }
        }

        public ObservableCollection<string> SearchSuggestionsList
        {
            get
            {
                return new ObservableCollection<string>
                {
                    Constants.Company,
                     Constants.Services
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
                    _navigationService.Navigate(Constants.Company, null);
                    break;
                case "services":
                    _navigationService.Navigate(Constants.Services, null);
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