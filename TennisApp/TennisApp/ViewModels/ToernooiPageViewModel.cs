using Prism.AppModel;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace TennisApp.ViewModels
{
    public class ToernooiPageViewModel : ViewModelBase, IPageLifecycleAware
    {
        public ToernooiPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "toernooi";

            TerugPageCommand = new DelegateCommand(ToNavPage);
        }

        public ICommand TerugPageCommand { get; private set; }

        public void OnAppearing()
        {
            throw new NotImplementedException();
        }

        public void OnDisappearing()
        {
            throw new NotImplementedException();
        }

        private async void ToNavPage()
        {
            await NavigationService.GoBackAsync();
        }
    }
}
