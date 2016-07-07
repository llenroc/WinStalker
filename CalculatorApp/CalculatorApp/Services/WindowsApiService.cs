using System;
using System.Threading.Tasks;
using Windows.UI.Popups;

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

    public interface IWindowsApiService
    {
        Task ShowMessage(string message);
    }
}