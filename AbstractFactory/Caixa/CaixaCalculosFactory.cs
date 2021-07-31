using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Caixa
{
    public class CaixaCalculosFactory : ICalculosFactory
    {

        public IDesconto CriarDesconto() => new CaixaDesconto();

        public IJuros CriarJuros() => new CaixaJuros();

        public IMulta CriarMulta() => new CaixaMulta();
    }
}
