using WinStalker.Core.Services;
using Xunit;

namespace WinStalker.Core.Tests
{
    public class StalkServiceTests
    {
        private readonly IStalkService _stalkService;

        public StalkServiceTests()
        {
            _stalkService = new StalkService();
        }

        [Fact]
        public void TesteTest()
        {
            Assert.Equal(_stalkService.Teste(), 5);
        }

    }
}
