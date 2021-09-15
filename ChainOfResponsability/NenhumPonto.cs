using System;

namespace DesignPatterns.ChainOfResponsability
{
    public class NenhumPonto : ICalculadorDePontos
    {
        public int CalcularPontosPedido(Pedido pedido)
            => 0;

        public void SetProximo(ICalculadorDePontos proximo)
        {
            throw new NotImplementedException();
        }
    }
}
