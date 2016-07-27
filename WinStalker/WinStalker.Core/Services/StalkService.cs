using WinStalker.Core.Model;
using System.Net.Http;
using WinStalker.Core.Util;
using System.Net;
using System;

namespace WinStalker.Core.Services
{
    public class StalkService : IStalkService
    {

        public Person GetPerson(string email)
        {
            string json = GetFullContactApiPerson(email);
            return new Person(json);
        }

        private string GetFullContactApiPerson(string email)
        {
            string url = Config.API_BASE_URL + "/person.json?apiKey=" + Config.API_KEY + " &email=" + email;
            var response = new HttpClient().GetAsync(url).Result;

            if (response.StatusCode != HttpStatusCode.OK)
            {
                string errorMessage;

                switch (response.StatusCode)
                {
                    case HttpStatusCode.Accepted:
                        errorMessage = "Data for this person is being prepared. Try again in 5 minutes.";
                        break;
                    case HttpStatusCode.NotFound:
                        errorMessage = "Person not found.";
                        break;
                    default:
                        errorMessage = "An error has ocurred when searching for this person.";
                        break;
                }

                throw new Exception(errorMessage);
            }

            return response.Content.ReadAsStringAsync().Result;
        }

        public string GetSocialNetworkIconURL(string typeId)
        {
            return Config.API_BASE_URL + "/icon/" + typeId + "/64/default?apiKey=" + Config.API_KEY;
        }

    }

    public interface IStalkService
    {
        Person GetPerson(string email);
        string GetSocialNetworkIconURL(string typeId);
    }
}
