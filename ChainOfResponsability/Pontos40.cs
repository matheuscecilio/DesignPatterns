namespace DesignPatterns.ChainOfResponsability
{
    public class Pontos40 : ICalculadorDePontos
    {
        private ICalculadorDePontos _proximo;

        public int CalcularPontosPedido(Pedido pedido)
        {
            if (pedido.Valor >= 40)
            {
                return (int)(pedido.Valor / 7);
            }

            return _proximo.CalcularPontosPedido(pedido);
        }

        public void SetProximo(ICalculadorDePontos proximo)
        {
            _proximo = proximo;
        }
    }
}
