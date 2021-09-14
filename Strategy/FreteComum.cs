using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy
{
    public class FreteComum : IFrete
    {
        public double Calcula(double valor)
            => valor * 0.1;
    }
}
