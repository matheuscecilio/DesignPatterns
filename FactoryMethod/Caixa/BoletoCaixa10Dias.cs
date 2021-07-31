namespace DesignPatterns.FactoryMethod.Caixa
{
    public class BoletoCaixa10Dias : Boleto
    {
        public BoletoCaixa10Dias(double valor) : base(valor)
        {
            Juros = 0.02;
            Desconto = 0.1;
            Multa = 0.05;
        }
    }
}
