﻿
namespace ComparacaoSemantica.Testes
{
    public class Mapeador
    {
        public CriacaoDeClienteCmd Mapear(CriacaoDeClienteViewModel vm)
        {
            return new CriacaoDeClienteCmd
            {
                Nome = vm.Nome,
                NumeroDaMatricula = vm.NumeroDaMatricula,
                Email = vm.Email
                //DataDeOcorrencia = DateTime.Now
            };
        }
    }
}