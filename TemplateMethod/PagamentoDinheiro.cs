namespace DesignPatterns.TemplateMethod
{
    public class PagamentoDinheiro : Pagamento
    {
        public PagamentoDinheiro(
            double valor,
            Gateway gateway
        ) : base(valor, gateway) { }

        public override double CalcularDesconto()
            => Valor * 0.01;
    }
}
