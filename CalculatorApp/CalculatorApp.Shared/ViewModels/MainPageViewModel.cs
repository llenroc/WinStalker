using System.Threading.Tasks;
using CalculatorAppLibrary.Services;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;

namespace CalculatorApp.ViewModels
{
    public class MainPageViewModel : ViewModel
    {
        private readonly IMathOperationsService _mathOperationsService;
        private readonly IWindowsApiService _windowsApiService;
        private double _firstValue;
        private double _secondValue;

        public MainPageViewModel(
            IMathOperationsService mathOperationsService,
            IWindowsApiService windowsApiService)
        {
            _mathOperationsService = mathOperationsService;
            _windowsApiService = windowsApiService;
            SumCommand = DelegateCommand.FromAsyncHandler(Sum);
            SubtractCommand = DelegateCommand.FromAsyncHandler(Subtract);
            MultiplyCommand = DelegateCommand.FromAsyncHandler(Multiply);
            DivideCommand = DelegateCommand.FromAsyncHandler(Divide);
        }

        private async Task Sum()
        {
            var result = _mathOperationsService.Sum(FirstValue, SecondValue);
            var message = $"Result of {FirstValue} + {SecondValue} = {result}";
            await _windowsApiService.ShowMessage(message);
        }

        private async Task Subtract()
        {
            var result = _mathOperationsService.Subtract(FirstValue, SecondValue);
            var message = $"Result of {FirstValue} - {SecondValue} = {result}";
            await _windowsApiService.ShowMessage(message);
        }

        private async Task Multiply()
        {
            var result = _mathOperationsService.Multiply(FirstValue, SecondValue);
            var message = $"Result of {FirstValue} * {SecondValue} = {result}";
            await _windowsApiService.ShowMessage(message);
        }

        private async Task Divide()
        {
            var result = _mathOperationsService.Divide(FirstValue, SecondValue);
            var message = $"Result of {FirstValue} / {SecondValue} = {result}";
            await _windowsApiService.ShowMessage(message);
        }

        public double FirstValue
        {
            get { return _firstValue; }
            set { SetProperty(ref _firstValue, value); }
        }

        public double SecondValue
        {
            get { return _secondValue; }
            set { SetProperty(ref _secondValue, value); }
        }

        public DelegateCommand SumCommand { get; set; }
        public DelegateCommand SubtractCommand { get; set; }
        public DelegateCommand MultiplyCommand { get; set; }
        public DelegateCommand DivideCommand { get; set; }
    }
}
