using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Caixa
{
    public class CaixaDesconto : IDesconto
    {
        public double ObterDesconto() => 0.1;
    }
}
