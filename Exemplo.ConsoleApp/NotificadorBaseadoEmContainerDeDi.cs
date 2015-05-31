using Exemplo.Dominio;
using SimpleInjector;

namespace Exemplo.ConsoleApp
{
    /// <summary>
    /// notificador concreto usando o container SimpleInjector
    /// </summary>
    public class NotificadorBaseadoEmContainerDeDi : NotificadorDeEventosDeDominio
    {
        private readonly Container _container;

        public NotificadorBaseadoEmContainerDeDi(Container container)
        {
            _container = container;
        }

        public override void NotificarSobre<T>(T eventoDeDominio)
        {
            foreach (var enderecador in _container.GetAllInstances<IEnderecadorDeEvento<T>>())
                enderecador.Enderecar(eventoDeDominio);
        }
    }
}