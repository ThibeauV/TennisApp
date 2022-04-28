using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using TennisApp.Views;

namespace TennisApp.ViewModels
{
    public class NavPageViewModel : ViewModelBase
    {
        public NavPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Navigation Page";

            SpelersLijstPageCommand = new DelegateCommand(ToSpelersLijst);
            ToernooiPageCommand = new DelegateCommand(ToToernooiPage);
        }

        public ICommand SpelersLijstPageCommand { get; private set; }
        public ICommand ToernooiPageCommand { get; private set; }

        private async void ToSpelersLijst()
        {
            await NavigationService.NavigateAsync(nameof(SpelersLijst), null, true, true);
        }

        private async void ToToernooiPage()
        {
            await NavigationService.NavigateAsync(nameof(ToernooiPage), null, true, true);
        }
    }
}
