using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace TennisApp.ViewModels
{
    public class ToernooiPageViewModel : ViewModelBase
    {
        public ToernooiPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "toernooi";

            TerugPageCommand = new DelegateCommand(ToNavPage);
        }

        public ICommand TerugPageCommand { get; private set; }

        private async void ToNavPage()
        {
            await NavigationService.GoBackAsync();
        }
    }
}
