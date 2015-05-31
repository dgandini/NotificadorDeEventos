namespace Exemplo.Dominio
{
    public interface IEnderecadorDeEvento<T> where T : IEventoDeDominio
    {
        void Enderecar(T eventoDeDominio);
    }
}