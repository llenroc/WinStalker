using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System;

namespace WinStalker.Core.Model
{
    public class Person
    {
        public string PrimaryPhotoUrl { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public List<SocialNetwork> SocialNetworks { get; set; }

        public Person(JObject jo)
        {
            FullName = jo["contactInfo"]["fullName"].ToString();

            if (jo["demographics"] != null && jo["demographics"]["gender"] != null)
            {
                Gender = jo["demographics"]["gender"].ToString();
            }
            
            SocialNetworks = SocialNetwork.ToList(jo["socialProfiles"]);
            PrimaryPhotoUrl = getPrimaryPhotoUrl(jo["photos"]);
        }

        private string getPrimaryPhotoUrl(JToken jtl)
        {
            String url = null;

            foreach (JToken jt in jtl.Children())
            {
                if (jt["isPrimary"] != null && jt["isPrimary"].ToString().Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    url = jt["url"].ToString();
                    break;
                }
            }

            return url;
        }

    }
}
