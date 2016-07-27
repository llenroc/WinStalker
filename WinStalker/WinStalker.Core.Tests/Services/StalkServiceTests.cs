using WinStalker.Core.Services;
using Xunit;

namespace WinStalker.Core.Tests
{
    public class StalkServiceTests
    {
        private readonly IStalkService ss;

        public StalkServiceTests()
        {
            //TODO: Refatorar StalkService para desacoplar API e injetar a dependência mockada por aqui.
            ss = new StalkService();
        }

        [Fact]
        public void GetSocialNetworkIconURLTest()
        {
            string e = "https://api.fullcontact.com/v2/icon/facebook/64/default?apiKey=252a1ebb9708464c";
            string a = ss.GetSocialNetworkIconURL("facebook");
            Assert.Equal(e, a);
        }

        /* TODO: Escrever teste para:
            - Obter pessoa com sucesso
            - Pessoa não encontrada
            - Dados da pessoa sendo preparados
            - Erro genérico da API
        */

    }
}
