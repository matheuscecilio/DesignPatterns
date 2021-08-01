using DesignPatterns.Adapter.Interfaces;

namespace DesignPatterns.Adapter
{
    public class Cobranca
    {
        private IGateway Gateway { get; set; }

        public Cobranca(IGateway gateway)
        {
            Gateway = gateway;
        }

        public void AdicionarValor(double valor) 
            => Gateway.AdicionarValor(valor);

        public void AdicionarParcelas(int parcelas) 
            => Gateway.AdicionarParcelas(parcelas);

        public void AdicionarNumeroCartao(string numeroCartao)
            => Gateway.AdicionarNumeroCartao(numeroCartao);

        public void AdicionarCVV(string cvv)
            => Gateway.AdicionarCVV(cvv);

        public void AdicionarGateway(IGateway gateway)
            => Gateway = gateway;

        public bool ValidarCartao() 
            => Gateway.ValidarCartao();

        public bool RealizarPagamento() 
            => Gateway.RealizarPagamento();
    }
}
