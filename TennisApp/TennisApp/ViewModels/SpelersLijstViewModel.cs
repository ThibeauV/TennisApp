using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace TennisApp.ViewModels
{
    public class SpelersLijstViewModel : ViewModelBase
    {
        public SpelersLijstViewModel(INavigationService navigationService) 
            : base(navigationService)
        {
            Title = "Spelers";

            TerugPageCommand = new DelegateCommand(ToNavPage);
        }

        public ICommand TerugPageCommand { get; private set; }

        private async void ToNavPage()
        {
            await NavigationService.GoBackAsync();
        }
    }
}