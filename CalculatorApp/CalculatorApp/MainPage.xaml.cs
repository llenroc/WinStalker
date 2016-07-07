using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;
using CalculatorApp.Services;
using CalculatorApp.Core.Services;

namespace CalculatorApp
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;
            WindowsApiService = new WindowsApiService();
            CalculatorService = new CalculatorService();
        }

        private ICalculatorService CalculatorService { get; set; }

        private IWindowsApiService WindowsApiService { get; set; }

        private async void BtnSum_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            var numberOne = double.Parse(TxtNumberOne.Text);
            var numberTwo = double.Parse(TxtNumberTwo.Text);
            var result = CalculatorService.Sum(numberOne, numberTwo);
            var message = $"Result of {numberOne} + {numberTwo} = {result}";
            await WindowsApiService.ShowMessage(message);
        }

        private async void BtnSubtract_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            var numberOne = double.Parse(TxtNumberOne.Text);
            var numberTwo = double.Parse(TxtNumberTwo.Text);
            var result = CalculatorService.Subtract(numberOne, numberTwo);
            var message = $"Result of {numberOne} - {numberTwo} = {result}";
            await WindowsApiService.ShowMessage(message);
        }

        private async void BtnMultiply_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            var numberOne = double.Parse(TxtNumberOne.Text);
            var numberTwo = double.Parse(TxtNumberTwo.Text);
            var result = CalculatorService.Multiply(numberOne, numberTwo);
            var message = $"Result of {numberOne} * {numberTwo} = {result}";
            await WindowsApiService.ShowMessage(message);
        }

        private async void BtnDivide_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            var numberOne = double.Parse(TxtNumberOne.Text);
            var numberTwo = double.Parse(TxtNumberTwo.Text);
            var result = CalculatorService.Divide(numberOne, numberTwo);
            var message = $"Result of {numberOne} / {numberTwo} = {result}";
            await WindowsApiService.ShowMessage(message);
        }
    }
}