using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using TennisApp.Views;
using Xamarin.Forms;

namespace TennisApp.ViewModels
{
    public class NavigationPageViewModel : ViewModelBase
    {
        public NavigationPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "NavigationEventArgs Page";

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