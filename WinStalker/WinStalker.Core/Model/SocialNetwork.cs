using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using WinStalker.Core.Util;

namespace WinStalker.Core.Model
{
    public class SocialNetwork
    {
        public string TypeId { get; set; }
        public string TypeName { get; set; }
        public string Username { get; set; }
        public string Url { get; set; }
        public string IconUrl { get; set; }

        internal static List<SocialNetwork> ToList(JToken jtl)
        {
            List<SocialNetwork> sns = new List<SocialNetwork>();

            foreach (JToken jt in jtl.Children())
            {
                SocialNetwork sn = new SocialNetwork(jt);
                sns.Add(sn);
            }

            return sns;
        }

        public SocialNetwork(JToken jt)
        {
            TypeId = jt["typeId"].ToString();
            TypeName = jt["typeName"].ToString();

            if (jt["username"] != null)
            {
                Username = jt["username"].ToString();
            }

            Url = jt["url"].ToString();

            IconUrl = Config.API_BASE_URL + "/icon/" + TypeId + "/64/default?apiKey=" + Config.API_KEY;
        }
    }
}
