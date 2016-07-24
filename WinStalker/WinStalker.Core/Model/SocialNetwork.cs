using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace WinStalker.Core.Model
{
    public class SocialNetwork
    {

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
        }

        public string TypeId { get; set; }
        public string TypeName { get; set; }
        public string Username { get; set; }
        public string Url { get; set; }

    }
}
