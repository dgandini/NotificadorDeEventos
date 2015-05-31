using Exemplo.Dominio;
using System;

namespace Exemplo.ConsoleApp
{
    // abaixo, duas implementacoes/observers para o mesmo evento para validarmos que o notificador concreto notificará ambos

    public class ExibicaoDeValoresNoConsole : IEnderecadorDeEvento<DespesaPaga>
    {
        public void Enderecar(DespesaPaga despesaPaga)
        {
            Console.WriteLine("Despesa {0} paga no valor de {1:c}", despesaPaga.IdDespesa, despesaPaga.ValorPago);
        }
    }

    public class ExibicaoDeAlertaNoConsole : IEnderecadorDeEvento<DespesaPaga>
    {
        public void Enderecar(DespesaPaga despesaPaga)
        {
            if (despesaPaga.ValorPago <= 500)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor abaixo do esperado");
                Console.ResetColor();
            }
        }
    }
}