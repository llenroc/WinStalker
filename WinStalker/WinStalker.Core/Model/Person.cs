using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace WinStalker.Core.Model
{
    public class Person
    {
        public Person(string json)
        {
            JObject jo = JObject.Parse(json);

            FullName = jo["contactInfo"]["fullName"].ToString();
            Gender = jo["demographics"]["gender"].ToString();
            SocialNetworks = SocialNetwork.ToList(jo["socialProfiles"]);
            //TODO: Preencher a foto primária.
        }

        public string PrimaryPhotoUrl { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public List<SocialNetwork> SocialNetworks { get; set; }

    }
}
