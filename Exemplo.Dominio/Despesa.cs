
namespace Exemplo.Dominio
{
    public class Despesa
    {
        public void Baixar()
        {
            //....quaisquer regras de baixa....

            NotificadorDeEventosDeDominio.NotificadorPadrao.NotificarSobre(new DespesaPaga(100, 100.50));
        }
    }
}
