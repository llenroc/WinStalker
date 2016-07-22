using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinStalker_Core.Model;
using Newtonsoft.Json;

namespace WinStalker_Core.Services
{
    public class StalkService : IStalkService
    {
        public async Task<Person> GetPerson()
        {
            var personJson = "";
            /*var file = await GetFile();
            using (var sRead = new StreamReader(await file.OpenStreamForReadAsync()))
                productsJson = await sRead.ReadToEndAsync();*/
            return JsonConvert.DeserializeObject<Person>(personJson);
        }

    }

    public async void GetRequest()
    {
        Uri geturi = new Uri("https://api.fullcontact.com/v2/person.json?apiKey=f03b8de1c87465&email=marcioggs@gmail.com"); //TODO: Replace Email by variable
 /*
        var response = await client.GetAsync(uri);
        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            Items = JsonConvert.DeserializeObject<List<TodoItem>>(content);
        }
       client = new HttpClient();
            HttpResponseMessage responseGet = await client.GetAsync(geturi);
            string response = await responseGet.Content.ReadAsStringAsync();*/
        }

    public interface IStalkService
    {
        Task<Person> GetPerson();
    }
}
