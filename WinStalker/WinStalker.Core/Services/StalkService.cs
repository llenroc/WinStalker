using WinStalker.Core.Model;
using System.Net.Http;

namespace WinStalker.Core.Services
{
    public class StalkService : IStalkService
    {

        public Person GetPerson(string email)
        {
            //TODO: Colocar URL em arquivo de configuração.
            string json = GetHttpRequest("https://api.fullcontact.com/v2/person.json?apiKey=f03b8de1c87465&email=" + email);

            return new Person(json);
        }

        private string GetHttpRequest(string Url)
        {
            string responseString = null;
            var response = new HttpClient().GetAsync(Url).Result;

            //TODO: Tratar códigos de erro.
            if (response.IsSuccessStatusCode)
            {
                responseString = response.Content.ReadAsStringAsync().Result;
            }
            
            return responseString;
        }

    }

    public interface IStalkService
    {
        Person GetPerson(string email);
    }
}
