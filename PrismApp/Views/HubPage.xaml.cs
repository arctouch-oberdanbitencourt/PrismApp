﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.Practices.Prism.StoreApps;

// The Hub Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=321224

namespace PrismApp.Views
{
    /// <summary>
    /// A page that displays a grouped collection of items.
    /// </summary>
    public sealed partial class HubPage : VisualStateAwarePage
    {
        public HubPage()
        {
           InitializeComponent();
        }
    }
}