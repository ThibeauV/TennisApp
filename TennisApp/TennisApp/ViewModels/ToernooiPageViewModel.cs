using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TennisApp.ViewModels
{
    public class ToernooiPageViewModel : ViewModelBase
    {
        public ToernooiPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "toernooi";
        }
    }
}
