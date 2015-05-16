namespace ComparacaoSemantica.Testes.TesteDeInteracao
{
    public class Servico
    {
        private readonly INotificador _notificador;

        public Servico(INotificador notificador)
        {
            _notificador = notificador;
        }

        public void Executar()
        {
            // qualquer outro codigo...

            _notificador.NotificarSobre(new ClienteFoiCadastrado { IdDoCliente = 1000 });
        }
    }
}