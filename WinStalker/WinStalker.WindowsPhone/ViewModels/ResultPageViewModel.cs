using System.Collections.Generic;
using Microsoft.Practices.Prism.Mvvm;
using Windows.UI.Xaml.Navigation;
using WinStalker.Core.Model;

namespace WinStalker.ViewModels
{
    public class ResultPageViewModel : ViewModel
    {

        private Person _person;

        public Person Person
        {
            get { return _person; }
            set { SetProperty(ref _person, value); }
        }

        public override void OnNavigatedTo(object navigationParameter, NavigationMode navigationMode, Dictionary<string, object> viewModelState)
        {
            base.OnNavigatedTo(navigationParameter, navigationMode, viewModelState);
            _person = (Person)navigationParameter;
        }
    }
}
