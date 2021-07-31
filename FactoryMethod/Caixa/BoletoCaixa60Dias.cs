namespace DesignPatterns.FactoryMethod.Caixa
{
    public class BoletoCaixa60Dias : Boleto
    {
        public BoletoCaixa60Dias(double valor) : base(valor)
        {
            Juros = 0.1;
            Desconto = 0;
            Multa = 0.2;
        }
    }
}
