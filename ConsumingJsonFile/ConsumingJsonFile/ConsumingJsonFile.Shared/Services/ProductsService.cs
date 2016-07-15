using System;
using System.Collections.Generic;
using ConsumingJsonFile.Model;
using System.Threading.Tasks;
using Windows.Storage;
using System.IO;
using Newtonsoft.Json;

namespace ConsumingJsonFile.Services
{
    public class ProductsService : IProductsService
    {
        public async Task<IList<Product>> GetProducts()
        {
            var productsJson = "";
            var file = await GetFile();
            using (var sRead = new StreamReader(await file.OpenStreamForReadAsync()))
                productsJson = await sRead.ReadToEndAsync();
            return JsonConvert.DeserializeObject<List<Product>>(productsJson);            
        }

        public async Task<StorageFile> GetFile()
        {
            return await StorageFile.GetFileFromApplicationUriAsync(
                new Uri(@"ms-appx:///Data/products.json"));
        }
    }
    public interface IProductsService
    {
        Task<IList<Product>> GetProducts();
    }
}
