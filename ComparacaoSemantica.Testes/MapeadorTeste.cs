using NUnit.Framework;
using Ploeh.SemanticComparison.Fluent;

namespace ComparacaoSemantica.Testes
{
    [TestFixture]
    public class MapeadorTeste
    {
        [Test]
        public void Deve_mapear_viewmodel_para_cmd_v1()
        {
            var vm = new CriacaoDeClienteViewModel { Nome = "Robson", Email = "rcs@rcs.com", NumeroDaMatricula = "123456" };
            var mapeador = new Mapeador();

            var cmd = mapeador.Mapear(vm);

            Assert.AreEqual(cmd.Nome, vm.Nome);
            Assert.AreEqual(cmd.Email, vm.Email);
            Assert.AreEqual(cmd.NumeroDaMatricula, vm.NumeroDaMatricula);
        }

        [Test]
        public void Deve_mapear_viewmodel_para_cmd_v2()
        {
            var vm = new CriacaoDeClienteViewModel { Nome = "Robson", Email = "rcs@rcs.com", NumeroDaMatricula = "123456" };
            var mapeador = new Mapeador();

            var cmd = mapeador.Mapear(vm);

            var cmdEsperado = vm.AsSource().OfLikeness<CriacaoDeClienteCmd>();
            cmdEsperado.ShouldEqual(cmd);
        }

        // RESEMBLANCE
        // pensar em exemplo para usar com Mock
        //var cmdEsperado = vm.AsSource().OfLikeness<CriacaoDeClienteCmd>().Without(c => c.DataDeOcorrencia).CreateProxy();
        //_mock.Verify(mapeador => mapeador.Do(cmdEsperado));
    }
}
