using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TennisApp.ViewModels
{
    public class NewPlayerPageViewModel : ViewModelBase
    {
        public NewPlayerPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "New Player";
        }
    }
}
