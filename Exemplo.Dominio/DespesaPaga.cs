using System;

namespace Exemplo.Dominio
{
    public class DespesaPaga : IEventoDeDominio
    {
        public int IdDespesa { get; private set; }
        public double ValorPago { get; private set; }

        public DespesaPaga(int idDespesa, double valorPago)
        {
            if (idDespesa <= 0) throw new ArgumentException("idDespesa");
            if (valorPago < 0) throw new ArgumentException("valorPago");
            IdDespesa = idDespesa;
            ValorPago = valorPago;
        }
    }
}