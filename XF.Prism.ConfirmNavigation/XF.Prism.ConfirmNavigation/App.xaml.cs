using Prism.DryIoc;
using Prism.Ioc;
using Xamarin.Forms;
using XF.Prism.ConfirmNavigation.Views;

namespace XF.Prism.ConfirmNavigation
{
    public partial class App : PrismApplication
    {
        public App()
        {
            InitializeComponent();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<ViewAPage>();
            containerRegistry.RegisterForNavigation<ViewBPage>();
        }

        protected override async void OnInitialized()
        {
            await NavigationService.NavigateAsync("NavigationPage/ViewAPage");
        }

        protected override void OnStart() { }
        protected override void OnSleep() { }
        protected override void OnResume() { }
    }
}
