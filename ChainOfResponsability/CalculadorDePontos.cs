namespace DesignPatterns.ChainOfResponsability
{
    public static class CalculadorDePontos
    {
        public static int CalcularPontosPedido(
            Pedido pedido,
            int dia
        )
        {
            var pontos70 = new Pontos70();
            var pontos40 = new Pontos40();
            var pontos20 = new Pontos20();
            var nenhumPonto = new NenhumPonto();

            pontos70.SetProximo(pontos40);
            pontos40.SetProximo(pontos20);
            pontos20.SetProximo(nenhumPonto);

            var pontos = pontos70.CalcularPontosPedido(pedido);

            if (dia >= 16)
            {
                return pontos * 2;
            }

            return pontos;
        }

        private static int MetodoOriginal(Pedido pedido)
        {
            int pontos;

            if (pedido.Valor >= 70)
            {
                pontos = (int)(pedido.Valor / 5);
            }
            else if (pedido.Valor >= 40)
            {
                pontos = (int)(pedido.Valor / 7);
            }
            else if (pedido.Valor >= 20)
            {
                pontos = (int)(pedido.Valor / 10);
            }
            else
            {
                return 0;
            }

            return pontos;
        }
    }
}
