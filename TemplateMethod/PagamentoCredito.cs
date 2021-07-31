namespace DesignPatterns.TemplateMethod
{
    public class PagamentoCredito : Pagamento
    {
        public PagamentoCredito(
            double valor,
            Gateway gateway
        ) : base(valor, gateway) { }

        public override double CalcularDesconto()
        {
            if (Valor > 300)
            {
                return Valor * 0.02;
            }

            return 0;
        }
    }
}
