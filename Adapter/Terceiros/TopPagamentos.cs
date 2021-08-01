using System;

namespace DesignPatterns.Adapter.Terceiros
{
    public class TopPagamentos
    {
        private double Valor { get; set; }
        private int Parcelas { get; set; }
        private string NumeroCartao { get; set; }
        private string CVV { get; set; }

        public void AdicionarValorTotal(double valor) => Valor = valor;

        public void AdicionarQuantidadesDeParcelas(int parcelas) => Parcelas = parcelas;

        public void AdicionarCartao(
            string numeroCartao, 
            string cvv
        )
        {
            NumeroCartao = numeroCartao;
            CVV = cvv;
        }

        public bool RealizarPagamento()
        {
            Console.WriteLine("Pagamento TopPagamentos");
            return true;
        }
    }
}
