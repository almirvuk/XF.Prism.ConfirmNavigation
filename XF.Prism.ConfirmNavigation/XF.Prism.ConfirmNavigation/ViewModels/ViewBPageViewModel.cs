using Prism.Navigation;
using Prism.Commands;

namespace XF.Prism.ConfirmNavigation.ViewModels
{
    public class ViewBPageViewModel 
    {
        private readonly INavigationService _navigationService;

        public DelegateCommand GoBackCommand { get; private set; }

        public ViewBPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            GoBackCommand = new DelegateCommand(GoBack);
        }

        private async void GoBack()
        {
            await _navigationService.GoBackAsync();
        }
    }
}
