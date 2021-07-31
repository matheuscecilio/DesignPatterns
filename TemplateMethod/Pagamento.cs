namespace DesignPatterns.TemplateMethod
{
    public abstract class Pagamento
    {
        protected Pagamento(
            double valor, 
            Gateway gateway
        )
        {
            Valor = valor;
            Gateway = gateway;
        }

        protected double Valor { get; set; }
        protected Gateway Gateway{ get; set; }

        public virtual double CalcularTaxa() => 0;

        public abstract double CalcularDesconto();

        public void RealizarCobranca()
        {
            var taxa = CalcularTaxa();
            var desconto = CalcularDesconto();

            var valorFinal = Valor + taxa - desconto;

            Gateway.Cobrar(valorFinal);
        }
    }
}
