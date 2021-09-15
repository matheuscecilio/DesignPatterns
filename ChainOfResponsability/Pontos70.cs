namespace DesignPatterns.ChainOfResponsability
{
    public class Pontos70 : ICalculadorDePontos
    {
        private ICalculadorDePontos _proximo;

        public int CalcularPontosPedido(Pedido pedido)
        {
            if (pedido.Valor >= 70)
            {
                return (int)(pedido.Valor / 5.0);
            }

            return _proximo.CalcularPontosPedido(pedido);
        }

        public void SetProximo(ICalculadorDePontos proximo)
        {
            _proximo = proximo;
        }
    }
}
