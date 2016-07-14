using System;
using System.Threading.Tasks;
using Windows.UI.Popups;
using CalculatorAppLibrary.Services;

namespace CalculatorApp.Services
{
    public class WindowsApiService : IWindowsApiService
    {
        public async Task ShowMessage(string message)
        {
            var messageDialog = new MessageDialog(message);
            await messageDialog.ShowAsync();
        }
    }    
}