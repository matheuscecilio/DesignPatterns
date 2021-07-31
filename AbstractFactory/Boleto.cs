using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory
{
    public class Boleto
    {
        protected double Valor { get; set; }
        protected IDesconto Desconto { get; set; }
        protected IJuros Juros { get; set; }
        protected IMulta Multa { get; set; }

        public Boleto(double valor, ICalculosFactory factory)
        {
            Valor = valor;
            Juros = factory.CriarJuros();
            Desconto = factory.CriarDesconto();
            Multa = factory.CriarMulta();
        }

        public double CalcularJuros() => Valor * Juros.ObterJuros();

        public double CalcularDesconto() => Valor * Desconto.ObterDesconto();

        public double CalcularMulta() => Valor * Multa.ObterMulta();
    }
}
