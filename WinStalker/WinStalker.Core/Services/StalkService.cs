using System.Threading.Tasks;
using WinStalker.Core.Model;
using Newtonsoft.Json;
using System.Net;
using System;
using System.Runtime.Serialization.Json;
using System.Net.Http;

namespace WinStalker.Core.Services
{
    public class StalkService : IStalkService
    {

        public Person GetPerson(string email)
        {
            Person p = new Person();
            //TODO: Colocar URL em arquivo de configuração.
            string json = GetHttpRequest("https://api.fullcontact.com/v2/person.json?apiKey=f03b8de1c87465&email=marcioggs@gmail.com");
            //TODO: Fazer o parse dos campos.

            return p;
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
