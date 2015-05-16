using NUnit.Framework;
using Ploeh.SemanticComparison.Fluent;

namespace ComparacaoSemantica.Testes.TesteDeEstado
{
    [TestFixture]
    public class MapeadorTeste
    {
        [Test]
        public void Deve_mapear_viewmodel_para_cmd_v1()
        {
            // arrange
            var vm = new CriacaoDeClienteViewModel { Nome = "Robson", Email = "rcs@rcs.com", NumeroDaMatricula = "123456" };
            var mapeador = new Mapeador();

            // act
            var cmd = mapeador.Mapear(vm);

            // assert
            Assert.AreEqual(cmd.Nome, vm.Nome);
            Assert.AreEqual(cmd.Email, vm.Email);
            Assert.AreEqual(cmd.NumeroDaMatricula, vm.NumeroDaMatricula);
        }

        [Test]
        public void Deve_mapear_viewmodel_para_cmd_v2()
        {
            // arrange
            var vm = new CriacaoDeClienteViewModel { Nome = "Robson", Email = "rcs@rcs.com", NumeroDaMatricula = "123456" };
            var mapeador = new Mapeador();
            var cmdEsperado = vm.AsSource().OfLikeness<CriacaoDeClienteCmd>();

            // act
            var cmd = mapeador.Mapear(vm);

            // assert
            cmdEsperado.ShouldEqual(cmd);
        }
    }
}
