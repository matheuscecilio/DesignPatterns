using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.BancoDoBrasil
{
    public class BancoDoBrasilJuros : IJuros
    {
        public double ObterJuros() => 0.03;
    }
}
