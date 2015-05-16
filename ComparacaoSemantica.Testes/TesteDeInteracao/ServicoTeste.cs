using Moq;
using NUnit.Framework;
using Ploeh.SemanticComparison.Fluent;

namespace ComparacaoSemantica.Testes.TesteDeInteracao
{
    [TestFixture]
    public class ServicoTeste
    {
        [Test]
        public void Deve_notificar_sobre_o_evento()
        {
            // arrange
            var notificadorMock = new Mock<INotificador>();
            var servico = new Servico(notificadorMock.Object);
            var evento = new ClienteFoiCadastrado { IdDoCliente = 1000 };
            var esperado = evento.AsSource().OfLikeness<ClienteFoiCadastrado>().Without(c => c.Id).CreateProxy();

            // act
            servico.Executar();

            // assert
            notificadorMock.Verify(n => n.NotificarSobre(esperado));
        }
    }
}