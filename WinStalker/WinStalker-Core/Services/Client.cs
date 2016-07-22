using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WinStalker_Core.Model;

namespace WinStalker_Core.Services
{
    public class Client
    {
        HttpClient client;


        public Client()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }

        public async Task<Person> RefreshDataAsync()
        {
            // RestUrl = http://developer.xamarin.com:8081/api/todoitems{0}
            var uri = new Uri('https://api.fullcontact.com/v2/person.json?apiKey=f03b8de1c87465&email=marcioggs@gmail.com');

            var response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Person>(content);
            }
            else
            {
                return new Person();
            }

        }
    }
}
