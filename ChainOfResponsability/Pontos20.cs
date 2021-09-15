namespace DesignPatterns.ChainOfResponsability
{
    public class Pontos20 : ICalculadorDePontos
    {
        private ICalculadorDePontos _proximo;

        public int CalcularPontosPedido(Pedido pedido)
        {
            if (pedido.Valor >= 20)
            {
                return (int)(pedido.Valor / 10);
            }

            return _proximo.CalcularPontosPedido(pedido);
        }

        public void SetProximo(ICalculadorDePontos proximo)
        {
            _proximo = proximo;
        }
    }
}
