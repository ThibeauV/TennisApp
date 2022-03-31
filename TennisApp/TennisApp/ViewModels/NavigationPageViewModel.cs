﻿using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace TennisApp.ViewModels
{
    public class NavigationPageViewModel : ViewModelBase
    {
        public NavigationPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "NavigationEventArgs Page";

            SpelersLijstPageCommand = new DelegateCommand(async () => navigationService.NavigateAsync(new Uri("SpelersLijst.xaml", UriKind.Relative)));
        }

        public DelegateCommand SpelersLijstPageCommand { get; }
    }
}