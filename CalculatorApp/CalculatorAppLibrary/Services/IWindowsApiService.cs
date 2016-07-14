using System.Threading.Tasks;

namespace CalculatorAppLibrary.Services
{
    public interface IWindowsApiService
    {
        Task ShowMessage(string message);
    }
}
