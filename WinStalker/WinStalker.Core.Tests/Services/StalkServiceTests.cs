using System;
using WinStalker.Core.Model;
using WinStalker.Core.Services;
using WinStalker.Core.Tests.ExternalServices;
using Xunit;

namespace WinStalker.Core.Tests
{
    public class StalkServiceTests
    {
        private readonly IStalkService ss;

        public StalkServiceTests()
        {
            ss = new StalkService(new MockPersonService());
        }

        [Fact]
        public void GetPersonSuccess()
        {
            Person p = ss.GetPerson("teste-200@istalker.com");

            Assert.Equal("Márcio Gabriel", p.FullName);
            Assert.Equal("Male", p.Gender);
            Assert.Equal("https://d2ojpxxtu63wzl.cloudfront.net/static/ff53b3bfe47180da4697f2cba95d6ed4_aa78c53620a485e08ce3c0ea38178d7339554ba81178753bd4446dd464308426", p.PrimaryPhotoUrl);

            Assert.True(p.SocialNetworks.Count == 8);

            bool foundYouTube = false;

            foreach(SocialNetwork sn in p.SocialNetworks)
            {
                if ("youtube".Equals(sn.TypeId))
                {
                    foundYouTube = true;

                    Assert.Equal("Youtube", sn.TypeName);
                    Assert.Equal("https://youtube.com/user/marcioggs", sn.Url);
                    Assert.Equal("marcioggs", sn.Username);

                    break;
                }
            }

            Assert.True(foundYouTube);
        }

        [Fact]
        public void GetPersonDataBeingPrepared()
        {
            Exception ex = Assert.Throws<Exception>(() => ss.GetPerson("teste-202@istalker.com"));
            Assert.Equal("Data for this person is being prepared. Try again in 5 minutes.", ex.Message);
        }

        [Fact]
        public void GetPersonPersonNotFound()
        {
            Exception ex = Assert.Throws<Exception>(() => ss.GetPerson("teste-404@istalker.com"));
            Assert.Equal("Person not found.", ex.Message);
        }

        [Fact]
        public void GetPersonGenericServerError()
        {
            Exception ex = Assert.Throws<Exception>(() => ss.GetPerson("teste-500@istalker.com"));
            Assert.Equal("An error has ocurred when searching for this person.", ex.Message);
        }

        [Fact]
        public void GetSocialNetworkIconURLTest()
        {
            string e = "https://api.fullcontact.com/v2/icon/facebook/64/default?apiKey=252a1ebb9708464c";
            string a = ss.GetSocialNetworkIconURL("facebook");
            Assert.Equal(e, a);
        }

    }
}
