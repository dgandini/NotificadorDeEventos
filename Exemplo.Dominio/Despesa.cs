
namespace Exemplo.Dominio
{
    public class Despesa
    {
        public void Baixar()
        {
            //....quaisquer regras de baixa....
            //....valores atribuidos diretamente somente para fins de demonstração da notificacao
            const int idDespesa = 100;
            const double valorPago = 100.50;

            NotificadorDeEventosDeDominio.NotificadorPadrao.NotificarSobre(new DespesaPaga(idDespesa, valorPago));
        }
    }
}
