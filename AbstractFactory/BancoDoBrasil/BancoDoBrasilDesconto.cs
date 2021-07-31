using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.BancoDoBrasil
{
    public class BancoDoBrasilDesconto : IDesconto
    {
        public double ObterDesconto() => 0.05;
    }
}
