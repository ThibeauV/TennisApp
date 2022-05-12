using Prism;
using Prism.Ioc;
using TennisApp.Models;
using TennisApp.Repositories;
using TennisApp.ViewModels;
using TennisApp.Views;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace TennisApp
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {

        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/NavPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<Xamarin.Forms.NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<SpelersLijst, SpelersLijstViewModel>();
            containerRegistry.RegisterForNavigation<ToernooiPage, ToernooiPageViewModel>();
            containerRegistry.RegisterForNavigation<NavPage, NavPageViewModel>();
            containerRegistry.RegisterForNavigation<NewPlayerPage, NewPlayerPageViewModel>();
            containerRegistry.Register<IDataRepositories<Player>, FirebaseRepositories>();
            containerRegistry.RegisterForNavigation<UpdatePlayerPage, UpdatePlayerPageViewModel>();
        }
    }
}
