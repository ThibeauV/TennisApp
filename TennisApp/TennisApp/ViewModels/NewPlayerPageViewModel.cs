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
    public class NewPlayerPageViewModel : ViewModelBase
    {
        private IDataRepositories<Player> dataRepositories;

        public NewPlayerPageViewModel(INavigationService navigationService, IDataRepositories<Player> dataRepositories)
            : base(navigationService)
        {
            Title = "New Player";

            AddCommand = new DelegateCommand(AddPlayer);

            CancelCommand = new DelegateCommand(CancelPlayer);

            this.dataRepositories = dataRepositories;
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        private string familiename;

        public string Familiename
        {
            get { return familiename; }
            set { SetProperty(ref familiename, value); }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { SetProperty(ref age, value); }
        }

        public ICommand AddCommand { get; private set; }

        public ICommand CancelCommand { get; private set; }

        private async void AddPlayer()
        {
            OnSave();
            await NavigationService.GoBackAsync();
        }

        private async void CancelPlayer()
        {
            await NavigationService.GoBackAsync();
        }

        private async void OnSave()
        {
            try
            {
                Player player = new Player()
                {
                    PlayerId = 1,
                    Firstname = name,
                    Lastname = familiename,
                    Age = age
                };

                await dataRepositories.AddPlayersAsync(player);
            }
            catch
            {

            }
        }
    }
}
