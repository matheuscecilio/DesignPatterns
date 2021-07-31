namespace DesignPatterns.FactoryMethod.BancoDoBrasil
{
    public class BoletoBancoDoBrasil60Dias : Boleto
    {
        public BoletoBancoDoBrasil60Dias(double valor) : base(valor)
        {
            Juros = 0.1;
            Desconto = 0;
            Multa = 0.15;
        }
    }
}
