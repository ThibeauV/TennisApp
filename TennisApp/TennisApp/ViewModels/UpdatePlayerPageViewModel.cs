using Prism.Commands;
using Prism.Common;
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
    public class UpdatePlayerPageViewModel : ViewModelBase
    {
        private Player player;

        private IDataRepositories<Player> dataRepositories;

        public UpdatePlayerPageViewModel(INavigationService navigationService, IDataRepositories<Player> dataRepositories)
            : base(navigationService)
        {
            this.dataRepositories = dataRepositories;

            Title = "Update Player";

            UpdateCommand = new DelegateCommand(OnSave);//.ObservesProperty(() => age).ObservesProperty(() => name).ObservesProperty(() => familiename);

            CancelCommand = new DelegateCommand(CancelPlayer);

            DeleteCommand = new DelegateCommand(DeletePlayer);
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

        public ICommand UpdateCommand { get; private set; }
        public ICommand CancelCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }

        private async void OnSave()
        {
            try
            {
                player.Age = age;
                player.Firstname = name;
                player.Lastname = familiename;

                await dataRepositories.UpdateItemAsync(player);
                await NavigationService.GoBackAsync();
            }
            catch
            {

            }
        }

        private async void CancelPlayer()
        {
            await NavigationService.GoBackAsync();
        }

        private bool ValidateSave()
        {
            bool test = !string.IsNullOrWhiteSpace(Convert.ToString(age))
                && !string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(familiename);
            return test;
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.ContainsKey("player"))
            {
                player = parameters.GetValue<Player>("player");
                Name = player.Firstname;
                Familiename = player.Lastname;
                Age = player.Age;
            }
        }

        public async void DeletePlayer()
        {
            dataRepositories.DeleteItemAsync(player);
            await NavigationService.GoBackAsync();
        }
    }
}
