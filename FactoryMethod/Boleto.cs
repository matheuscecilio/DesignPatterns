namespace DesignPatterns.FactoryMethod
{
    public abstract class Boleto
    {
        protected double Valor { get; set; }
        protected double Desconto { get; set; }
        protected double Juros { get; set; }
        protected double Multa { get; set; }

        public Boleto(double valor)
        {
            Valor = valor;
        }

        public double CalcularJuros() => Valor * Juros;

        public double CalcularDesconto() => Valor * Desconto;

        public double CalcularMulta() => Valor * Multa;
    }
}
