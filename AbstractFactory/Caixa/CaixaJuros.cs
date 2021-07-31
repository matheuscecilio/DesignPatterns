using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Caixa
{
    public class CaixaJuros : IJuros
    {
        public double ObterJuros() => 0.02;
    }
}
