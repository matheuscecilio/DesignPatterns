using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.BancoDoBrasil
{
    public class BancoDoBrasilCalculosFactory : ICalculosFactory
    {
        public IDesconto CriarDesconto() => new BancoDoBrasilDesconto();

        public IJuros CriarJuros() => new BancoDoBrasilJuros();

        public IMulta CriarMulta() => new BancoDoBrasilMulta();
    }
}
