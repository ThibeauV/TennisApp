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
        }

        public ICommand SpelersLijstPageCommand { get; private set; }


        private async void ToSpelersLijst()
        {
            await NavigationService.NavigateAsync(nameof(SpelersLijst), null, true, true);
        }
    }
}