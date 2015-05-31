using Exemplo.Dominio;
using SimpleInjector;

namespace Exemplo.ConsoleApp
{
    public class CompositionRoot
    {
        public static void Configurar()
        {
            var container = new Container();
            container.RegisterAll<IEnderecadorDeEvento<DespesaPaga>>(new ExibicaoDeValoresNoConsole(), new ExibicaoDeAlertaNoConsole());

            NotificadorDeEventosDeDominio.NotificadorCorrente = new NotificadorBaseadoEmContainerDeDi(container);
        }
    }
}