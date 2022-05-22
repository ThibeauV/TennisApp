using Prism.AppModel;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using TennisApp.Models;
using TennisApp.Repositories;

namespace TennisApp.ViewModels
{
    public class ToernooiPageViewModel : ViewModelBase, IPageLifecycleAware
    {
        private int amountPlayers;
        private Player player;
        private IDataRepositories<Player> dataRepositories;

        public ToernooiPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "toernooi";

            TerugPageCommand = new DelegateCommand(ToNavPage);

            MakeToernooiCommand = new DelegateCommand(MakeToernooi);
        }

        public ICommand TerugPageCommand { get; private set; }
        public ICommand MakeToernooiCommand { get; private set; }

        public void OnAppearing()
        {

        }

        public void OnDisappearing()
        {

        }

        private async void ToNavPage()
        {
            await NavigationService.GoBackAsync();
        }

        private async void MakeToernooi()
        {
            amountPlayers = Convert.ToInt32(dataRepositories.GetPlayerCount());
        }
    }
}
