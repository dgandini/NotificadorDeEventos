using Moq;
using NUnit.Framework;
using Ploeh.SemanticComparison.Fluent;

namespace Exemplo.Dominio.Testes
{
    [TestFixture]
    public class DespesaTeste
    {
        [Test]
        public void Deve_notificar_sobre_baixa_da_despesa()
        {
            var notificadorDeEventosDeDominioMock = new Mock<NotificadorDeEventosDeDominio>();
            NotificadorDeEventosDeDominio.NotificadorCorrente = notificadorDeEventosDeDominioMock.Object;

            var despesa = new Despesa();

            despesa.Baixar();

            // obs: valores 100 e 100.50 hard-coded apenas para demonstracao (ver implementacao do metodo Baixar())
            var despesaPaga = (new DespesaPaga(100, 100.50)).AsSource().OfLikeness<DespesaPaga>().CreateProxy();
            notificadorDeEventosDeDominioMock.Verify(mock => mock.NotificarSobre(despesaPaga), Times.Once);
        }
    }
}
