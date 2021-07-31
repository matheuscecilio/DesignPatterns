namespace DesignPatterns.TemplateMethod
{
    public class PagamentoDebito : Pagamento
    {
        public PagamentoDebito(
            double valor,
            Gateway gateway
        ) : base(valor, gateway) { }

        public override double CalcularDesconto()
            => Valor * 0.05;

        public override double CalcularTaxa()
        {
            return 4;
        }
    }
}
