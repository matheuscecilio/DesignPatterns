namespace DesignPatterns.FactoryMethod.BancoDoBrasil
{
    public class BoletoBancoDoBrasil30Dias : Boleto
    {
        public BoletoBancoDoBrasil30Dias(double valor) : base(valor)
        {
            Juros = 0.05;
            Desconto = 0.02;
            Multa = 0.05;
        }
    }
}
