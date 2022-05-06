using Prism.AppModel;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Input;
using TennisApp.Models;
using TennisApp.Repositories;
using TennisApp.Views;
using Xamarin.Forms;

namespace TennisApp.ViewModels
{
    public class SpelersLijstViewModel : ViewModelBase, IPageLifecycleAware
    {
        private IDataRepositories<Player> dataRepositories;

        public SpelersLijstViewModel(INavigationService navigationService, IDataRepositories<Player> dataRepositories) 
            : base(navigationService)
        {
            this.dataRepositories = dataRepositories;

            Title = "Spelers";

            TerugPageCommand = new DelegateCommand(ToNavPage);

            AddPlayerCommand = new DelegateCommand(MakePlayer);

            Players = new ObservableCollection<Player>();

            ReloadPlayersCommand = new DelegateCommand(ReloadPlayers);
        }

        public ObservableCollection<Player> Players { get; private set; }

        private bool isBusy;

        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        public ICommand TerugPageCommand { get; private set; }

        public ICommand AddPlayerCommand { get; private set; }
        
        public ICommand ReloadPlayersCommand { get; private set; }

        private async void ToNavPage()
        {
            await NavigationService.GoBackAsync();
        }

        private async void MakePlayer()
        {
            await NavigationService.NavigateAsync(nameof(NewPlayerPage), null, true, true);
        }

        private async void ShowPlayer()
        {
            try
            {
                Players.Clear();

                var players = await dataRepositories.GetPlayersAsync();

                foreach (var player in players)
                {
                    Players.Add(player);
                }
            }
            catch (Exception x)
            {
                Debug.WriteLine(x);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            ShowPlayer();
        }

        public void OnDisappearing()
        {
            
        }

        public void ReloadPlayers()
        {
            ShowPlayer();
        }
    }
}