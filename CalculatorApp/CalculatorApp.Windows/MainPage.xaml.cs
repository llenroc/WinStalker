using CalculatorApp.Core.Services;
using CalculatorApp.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CalculatorApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
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
