namespace DesignPatterns.ChainOfResponsability
{
    public interface ICalculadorDePontos
    {
        int CalcularPontosPedido(Pedido pedido);

        void SetProximo(ICalculadorDePontos proximo);
    }
}
