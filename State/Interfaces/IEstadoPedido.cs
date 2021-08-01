namespace DesignPatterns.State.Interfaces
{
    public interface IEstadoPedido
    {
        void SucessoAoPagar();

        void DespacharPedido();

        void CancelarPedido();
    }
}
