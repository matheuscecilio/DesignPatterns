using DesignPatterns.Adapter.Interfaces;
using DesignPatterns.Adapter.Terceiros;

namespace DesignPatterns.Adapter
{
    public class TopPagamentosAdapter : IGateway
    {
        public TopPagamentosAdapter(TopPagamentos topPagamentos)
        {
            TopPagamentos = topPagamentos;
        }

        private TopPagamentos TopPagamentos { get; set; }
        private string CVV { get; set; }
        private string NumeroCartao { get; set; }

        public void AdicionarCVV(string cvv)
        {
            CVV = cvv;

            if (!string.IsNullOrEmpty(NumeroCartao))
            {
                TopPagamentos.AdicionarCartao(
                    NumeroCartao,
                    CVV
                );
            }
        }

        public void AdicionarNumeroCartao(string numeroCartao)
        {
            NumeroCartao = numeroCartao;

            if (!string.IsNullOrEmpty(CVV))
            {
                TopPagamentos.AdicionarCartao(
                    NumeroCartao,
                    CVV
                );
            }
        }

        public void AdicionarParcelas(int parcelas)
            => TopPagamentos.AdicionarQuantidadesDeParcelas(parcelas);

        public void AdicionarValor(double valor)
            => TopPagamentos.AdicionarValorTotal(valor);

        public bool RealizarPagamento()
            => TopPagamentos.RealizarPagamento();

        public bool ValidarCartao() => true;
    }
}
