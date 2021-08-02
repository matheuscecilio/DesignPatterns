namespace DesignPatterns.Facade
{
    public class PagamentoCredito : Pagamento
    {
        public PagamentoCredito(Pedido pedido) : base(pedido) { }

        public override bool RealizarPagamento()
        {
            if (Pedido.Valor > 0)
            {
                return true;
            }

            return false;
        }
    }
}
