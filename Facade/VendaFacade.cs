using System;

namespace DesignPatterns.Facade
{
    public class VendaFacade
    {
        public VendaFacade(Consumidor consumidor)
        {
            Pedido = new(consumidor);
            EmailPedido = new(Pedido);
        }

        public Pedido Pedido { get; set; }
        public EmailPedido EmailPedido { get; set; }
        public Pagamento Pagamento { get; set; }

        public void AdicionarProduto(Produto produto)
        {
            Pedido.AdicionarProduto(produto);
        }

        public void PedidoCredito()
        {
            Pagamento = new PagamentoCredito(Pedido);

            if (Pagamento.RealizarPagamento())
            {
                Console.WriteLine("Pagamento realizado via crédito");
            }
            else
            {
                Console.WriteLine("Falha no pagamento via crédito");
            }
        }

        public void PedidoBoleto()
        {
            Pagamento = new PagamentoBoleto(Pedido);

            if (Pagamento.RealizarPagamento())
            {
                Console.WriteLine("Pagamento realizado via boleto");
            }
            else
            {
                Console.WriteLine("Falha no pagamento via boleto");
            }
        }
    }
}
