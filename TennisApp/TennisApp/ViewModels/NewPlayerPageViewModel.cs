using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace TennisApp.ViewModels
{
    public class NewPlayerPageViewModel : ViewModelBase
    {
        public NewPlayerPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "New Player";

            AddCommand = new DelegateCommand(AddPlayer);

            CancelCommand = new DelegateCommand(CancelPlayer);
        }

        public ICommand AddCommand { get; private set; }

        public ICommand CancelCommand { get; private set; }

        private async void AddPlayer()
        {
            await NavigationService.GoBackAsync();
        }

        private async void CancelPlayer()
        {
            await NavigationService.GoBackAsync();
        }
    }
}
