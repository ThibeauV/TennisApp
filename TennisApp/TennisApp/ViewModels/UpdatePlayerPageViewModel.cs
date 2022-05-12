using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace TennisApp.ViewModels
{
    public class UpdatePlayerPageViewModel : ViewModelBase
    {
        public UpdatePlayerPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Update Player";

            UpdateCommand = new DelegateCommand(UpdatePlayer);
        }

        public ICommand UpdateCommand { get; private set; }

        private async void UpdatePlayer()
        {

        }
    }
}
