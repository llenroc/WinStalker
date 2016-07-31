using System.Collections.Generic;
using Microsoft.Practices.Prism.Mvvm;
using Windows.UI.Xaml.Navigation;

namespace WinStalker.ViewModels
{
    public class SecondPageViewModel : ViewModel
    {

        private string _email;

        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        public override void OnNavigatedTo(object navigationParameter, NavigationMode navigationMode, Dictionary<string, object> viewModelState)
        {
            base.OnNavigatedTo(navigationParameter, navigationMode, viewModelState);
            _email = (string)navigationParameter;
        }
    }
}
