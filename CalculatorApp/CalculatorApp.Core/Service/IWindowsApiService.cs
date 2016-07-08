using System.Threading.Tasks;

namespace CalculatorApp.Core.Services
{
    public interface IWindowsApiService
    {
        Task ShowMessage(string message);
    }
}