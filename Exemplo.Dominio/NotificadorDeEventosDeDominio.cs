using System;

namespace Exemplo.Dominio
{
    public abstract class NotificadorDeEventosDeDominio
    {
        private static NotificadorDeEventosDeDominio _notificadorPadrao;

        public static NotificadorDeEventosDeDominio NotificadorPadrao
        {
            get { return _notificadorPadrao; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");

                _notificadorPadrao = value;
            }
        }

        public abstract void NotificarSobre<T>(T eventoDeDominio) where T : IEventoDeDominio;
    }
}
