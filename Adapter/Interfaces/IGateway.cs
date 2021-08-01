namespace DesignPatterns.Adapter.Interfaces
{
    public interface IGateway
    {
        void AdicionarValor(double valor);
        
        void AdicionarParcelas(int parcelas);
        
        void AdicionarNumeroCartao(string numeroCartao);
        void AdicionarCVV(string cvv);
        
        bool ValidarCartao();

        bool RealizarPagamento();
    }
}
