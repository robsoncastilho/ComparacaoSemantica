using System;

namespace ComparacaoSemantica.Testes.TesteDeInteracao
{
    public abstract class Evento
    {
        public Guid Id { get; private set; }

        protected Evento()
        {
            Id = Guid.NewGuid();
        }
    }
}