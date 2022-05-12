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

            CancelCommand = new DelegateCommand(CancelPlayer);
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

        private async void UpdatePlayer()
        {
            OnSave();
            await NavigationService.GoBackAsync();
        }

        private async void OnSave()
        {
            try
            {
                
            }
            catch
            {

            }
        }

        private async void CancelPlayer()
        {
            await NavigationService.GoBackAsync();
        }
    }
}
