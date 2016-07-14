using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using CalculatorApp.Services;
using CalculatorApp.Structure;
using CalculatorAppLibrary.Services;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Unity;

namespace CalculatorApp
{
    sealed partial class App : MvvmAppBase
    {
        private readonly IUnityContainer _container = new UnityContainer();
        public App()
        {
            this.InitializeComponent();     
        }

        protected override Task OnLaunchApplicationAsync(LaunchActivatedEventArgs args)
        {
            _container.RegisterInstance(NavigationService);
            _container.RegisterInstance(SessionStateService);
            _container.RegisterType<IWindowsApiService,WindowsApiService>();
            _container.RegisterType<IMathOperationsService, MathOperationsService>();

            ViewModelLocationProvider.SetDefaultViewModelFactory
                ((viewModelType) => _container.Resolve(viewModelType));

            NavigationService.Navigate(Pages.Main.ToString(), null);

            return Task.FromResult<object>(null);
        }   
    }
}
