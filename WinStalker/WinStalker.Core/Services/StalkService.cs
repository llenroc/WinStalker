using WinStalker.Core.Model;
using WinStalker.Core.Util;
using System;
using Newtonsoft.Json.Linq;
using WinStalker.Core.ExternalServices;

namespace WinStalker.Core.Services
{
    public class StalkService : IStalkService
    {
        private IPersonService _ps;

        public StalkService() : this(new FullContactPersonService())
        {
        }

        public StalkService(IPersonService ips)
        {
            _ps = ips;
        }

        public Person GetPerson(string email)
        {
            string json = _ps.GetPerson(email);
            JObject jo = JObject.Parse(json);

            int status = Int32.Parse(jo["status"].ToString());
            if (status != 200)
            {
                string errorMessage;

                switch (status)
                {
                    case 202:
                        errorMessage = "Data for this person is being prepared. Try again in 5 minutes.";
                        break;
                    case 404:
                        errorMessage = "Person not found.";
                        break;
                    default:
                        errorMessage = "An error has ocurred when searching for this person.";
                        break;
                }

                throw new Exception(errorMessage);
            }

            
            return new Person(jo);
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
