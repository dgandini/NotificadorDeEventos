namespace Exemplo.Dominio
{
    public class DespesaPaga : IEventoDeDominio
    {
        public int IdDespesa { get; private set; }
        public double ValorPago { get; private set; }

        public DespesaPaga(int idDespesa, double valorPago)
        {
            IdDespesa = idDespesa;
            ValorPago = valorPago;
        }
    }
}