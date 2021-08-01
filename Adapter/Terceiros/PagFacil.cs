using System;

namespace DesignPatterns.Adapter.Terceiros
{
    public class PagFacil
    {
        private double Valor { get; set; }
        private int Parcelas { get; set; }
        private string NumeroCartao { get; set; }
        private string CVV { get; set; }

        public void AdicionarValor(double valor) => Valor = valor;

        public void AdicionarParcelas(int parcelas) => Parcelas = parcelas;

        public void AdicionarNumeroCartao(string numeroCartao) => NumeroCartao = numeroCartao;

        public void AdicionarCVV(string cvv) => CVV = cvv;

        public bool ValidarCartao()
        {
            return true;
        }

        public bool RealizarPagamento()
        {
            Console.WriteLine("Pagamento PagFacil");
            return true;
        }
    }
}
