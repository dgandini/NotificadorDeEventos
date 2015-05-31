using System;

namespace Exemplo.Dominio
{
    public abstract class NotificadorDeEventosDeDominio
    {
        private static NotificadorDeEventosDeDominio _notificadorCorrente;

        public static NotificadorDeEventosDeDominio NotificadorCorrente
        {
            get { return _notificadorCorrente; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");

                _notificadorCorrente = value;
            }
        }

        public abstract void NotificarSobre<T>(T eventoDeDominio) where T : IEventoDeDominio;
    }
}
