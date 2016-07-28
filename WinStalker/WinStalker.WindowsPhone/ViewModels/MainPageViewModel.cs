using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.Mvvm.Interfaces;

namespace WinStalker.ViewModels
{
    public class MainPageViewModel : ViewModel
    {
        private string _hello;
        private INavigationService _navigationService;

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            Hello = "Hi!";
            SayHiCommand = new DelegateCommand(SayHi);
            GoToNextPageCommand = new DelegateCommand(GoToNextPage);
        }

        private void GoToNextPage()
        {
            _navigationService.Navigate(Pages.Second.ToString(), null);
        }

        private void SayHi()
        {
            Hello = "Hi Nabil!";
        }

        public string Hello
        {
            get { return _hello; }
            set { SetProperty(ref _hello, value); }
        }

        public DelegateCommand SayHiCommand { get; set; }

        public DelegateCommand GoToNextPageCommand { get; set; }
    }
}
