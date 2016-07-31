using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.Mvvm.Interfaces;

namespace WinStalker.ViewModels
{
    public class MainPageViewModel : ViewModel
    {
        private string _email;
        private INavigationService _navigationService;

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            StalkCommand = new DelegateCommand(Stalk);
        }

        private void Stalk()
        {
            _navigationService.Navigate(Pages.Second.ToString(), _email);
        }

        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        public DelegateCommand StalkCommand { get; set; }
    }
}
