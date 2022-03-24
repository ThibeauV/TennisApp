using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace TennisApp.ViewModels
{
    public class NavigationPageViewModel : ViewModelBase
    {
        public NavigationPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "NavigationEventArgs Page";
        }
    }
}