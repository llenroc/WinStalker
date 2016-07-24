using WinStalker.Core.Services;
using Xunit;

namespace WinStalker.Core.Tests
{
    public class StalkServiceTests
    {
        private readonly IStalkService _stalkService;

        public StalkServiceTests()
        {
            //TODO: Mockar API e injetar dependência.
            _stalkService = new StalkService();
        }

        [Fact]
        public void TesteTest()
        {
            Assert.Equal(_stalkService.GetPerson("marcioggs@gmail.com").FullName, "teseet");
        }

    }
}
