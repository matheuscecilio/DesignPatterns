namespace DesignPatterns.FactoryMethod.BancoDoBrasil
{
    public class BoletoBancoDoBrasil10Dias : Boleto
    {
        public BoletoBancoDoBrasil10Dias(double valor) : base(valor)
        {
            Juros = 0.03;
            Desconto = 0.05;
            Multa = 0.02;
        }
    }
}
