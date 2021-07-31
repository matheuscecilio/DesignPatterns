namespace DesignPatterns.AbstractFactory.Interfaces
{
    public interface ICalculosFactory
    {
        IJuros CriarJuros();

        IMulta CriarMulta();

        IDesconto CriarDesconto();
    }
}
