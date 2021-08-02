namespace DesignPatterns.Facade
{
    public abstract class Pagamento
    {
        public Pagamento(Pedido pedido)
        {
            Pedido = pedido;
        }

        protected Pedido Pedido { get; set; }

        public abstract bool RealizarPagamento();
    }
}
