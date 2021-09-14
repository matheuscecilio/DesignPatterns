using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy
{
    public abstract class Pedido
    {
        protected IFrete Frete { get; set; }
        protected double Valor { get; set; }
        protected string Setor { get; set; }

        public double CalcularFrete() => Frete.Calcula(Valor);
    }
}
