using System.Threading.Tasks;
using Microsoft.Practices.Prism.Mvvm;
using Windows.ApplicationModel.Activation;
using Microsoft.Practices.Unity;
using ConsumingJsonFile.Structure;
using ConsumingJsonFile.Services;

namespace ConsumingJsonFile
{
    public sealed partial class App : MvvmAppBase
    {
        private readonly IUnityContainer _container = new UnityContainer();
        public App()
        {
            this.InitializeComponent();
        }

        protected override Task OnLaunchApplicationAsync(LaunchActivatedEventArgs args)
        {
            _container.RegisterInstance(SessionStateService);
            _container.RegisterInstance(NavigationService);
            _container.RegisterType<IProductsService, ProductsService>();

            ViewModelLocationProvider.SetDefaultViewModelFactory((viewmodel) => _container.Resolve(viewmodel));

            NavigationService.Navigate(Pages.Main.ToString(), null);
            return Task.FromResult<object>(null);
        }

    }
}