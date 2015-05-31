using Exemplo.Dominio;

namespace Exemplo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CompositionRoot.Configurar();

            // testando notificacao apos chamar metodo Baixar()
            var despesa = new Despesa();
            despesa.Baixar();
        }
    }
}
