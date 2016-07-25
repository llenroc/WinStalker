using WinStalker.Core.Services;
using Xunit;

namespace WinStalker.Core.Tests
{
    public class StalkServiceTests
    {
        private readonly IStalkService _stalkService;

        public StalkServiceTests()
        {
            //TODO: Refatorar StalkService para desacoplar API e injetar a dependência mockada por aqui.
            _stalkService = new StalkService();
        }

        [Fact]
        public void TesteTest()
        {
            //TODO: Exemplo de teste, remover após criar os testes reais.
            Assert.Equal("Márcio Gabriel", _stalkService.GetPerson("marcioggs@gmail.com").FullName);
        }

        /* TODO: Escrever teste para:
            - Obter pessoa com sucesso
            - Obter ícone da rede social
            - Pessoa não encontrada
            - Dados da pessoa sendo preparados
            - Erro genérico da API
        */

    }
}
