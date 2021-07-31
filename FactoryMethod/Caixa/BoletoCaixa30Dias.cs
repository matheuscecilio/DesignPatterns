namespace DesignPatterns.FactoryMethod.Caixa
{
    public class BoletoCaixa30Dias : Boleto
    {
        public BoletoCaixa30Dias(double valor) : base(valor)
        {
            Juros = 0.05;
            Desconto = 0.05;
            Multa = 0.1;
        }
    }
}
