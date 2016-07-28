using System.Net.Http;
using WinStalker.Core.Util;

namespace WinStalker.Core.ExternalServices
{
    public class FullContactPersonService : IPersonService
    {
        public string GetPerson(string email)
        {
            string url = Config.API_BASE_URL + "/person.json?apiKey=" + Config.API_KEY + " &email=" + email;
            var response = new HttpClient().GetAsync(url).Result;
            return response.Content.ReadAsStringAsync().Result;
        }
    }
}
