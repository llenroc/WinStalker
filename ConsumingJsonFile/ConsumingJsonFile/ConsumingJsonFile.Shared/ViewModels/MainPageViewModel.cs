using System.Threading.Tasks;
using ConsumingJsonFile.Services;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using ConsumingJsonFile.Model;
using System.Collections.ObjectModel;

namespace ConsumingJsonFile.ViewModels
{
    public class MainPageViewModel : ViewModel
    {
        private IProductsService _productsService;
        private ObservableCollection<Product> _products;

        public MainPageViewModel(IProductsService productsService)
        {
            _productsService = productsService;
            GetProductsListCommand = DelegateCommand.FromAsyncHandler(GetProductsList);
        }

        private async Task GetProductsList()
        {
            var products = await _productsService.GetProducts();
            Products = new ObservableCollection<Product>(products);
        }

        public DelegateCommand GetProductsListCommand { get; set; }

        public ObservableCollection<Product> Products
        {
            get{ return _products; }
            set { SetProperty(ref _products, value);}
        }
    }
}
