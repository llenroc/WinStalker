using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.Mvvm.Interfaces;
using System;
using Windows.UI.Popups;
using WinStalker.Core.Model;
using WinStalker.Core.Services;

namespace WinStalker.ViewModels

    //TODO: Colocar ícone de loading ao clicar em Stalk.
    //TODO: Colocar painéis clicáveis abrindo o link no browser.
    //TODO: Ao clicar no botão enter, submeter a pesquisa.

{
    public class SearchPageViewModel : ViewModel
    {
        private string _email;
        private readonly INavigationService _navigationService;

        public SearchPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            StalkCommand = new DelegateCommand(Stalk);
        }

        private async void Stalk()
        {
            try
            {
                StalkService ss = new StalkService();
                Person person = ss.GetPerson(_email);
                _navigationService.Navigate(Pages.Result.ToString(), person);
            }
            catch (Exception e){
                await new MessageDialog(e.Message).ShowAsync();
            }
        }

        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        public DelegateCommand StalkCommand { get; set; }
    }
}
