using System.Collections.Generic;

namespace WinStalker.Core.Model
{
    public class Person
    {
        public string PrimaryPhotoUrl { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }

        public List<SocialNetwork> SocialNetworks { get; set; }
        

    }
}
