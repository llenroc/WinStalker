using System.Collections.Generic;

namespace WinStalker.Core.Model
{
    public class Person
    {
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public string GivenName { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }

        public List<SocialNetwork> SocialNetworks { get; set; }
        

    }
}
