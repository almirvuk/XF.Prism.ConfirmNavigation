using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;

namespace XF.Prism.ConfirmNavigation.ViewModels
{
    public class ViewAPageViewModel : BindableBase, IConfirmNavigation
    {
        private readonly INavigationService _navigationService;

        private bool canNavigateAway;
        public bool CanNavigateAway
        {
            get { return canNavigateAway; }
            set { SetProperty(ref canNavigateAway, value); }
        }
        
        public DelegateCommand NavigateAwayCommand { get; set; }    

        public ViewAPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            NavigateAwayCommand = new DelegateCommand(NavigateAway);
        }

        private async void NavigateAway()
        {
            await _navigationService.NavigateAsync("ViewBPage");
        }

        public bool CanNavigate(INavigationParameters parameters)
        {
            return CanNavigateAway;
        }
    }
}
