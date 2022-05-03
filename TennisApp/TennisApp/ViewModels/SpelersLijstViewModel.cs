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
    public class SpelersLijstViewModel : ViewModelBase
    {
        private IDataRepositories<Players> dataRepositories;

        public SpelersLijstViewModel(INavigationService navigationService, IDataRepositories<Players> dataRepositories) 
            : base(navigationService)
        {
            this.dataRepositories = dataRepositories;

            Title = "Spelers";

            TerugPageCommand = new DelegateCommand(ToNavPage);

            AddPlayerCommand = new DelegateCommand(MakePlayer);

            Player = new ObservableCollection<Players>();

            ShowPlayer();
        }

        public ObservableCollection<Players> Player { get; private set; }

        private bool isBusy;

        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        public ICommand TerugPageCommand { get; private set; }

        public ICommand AddPlayerCommand { get; private set; }

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
                var players = await dataRepositories.GetPlayersAsync();

                foreach (var player in players)
                {
                    Player.Add(player);
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
    }
}