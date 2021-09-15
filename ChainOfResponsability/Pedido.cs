namespace DesignPatterns.ChainOfResponsability
{
    public class Pedido
    {
        public Pedido(double valor)
        {
            Valor = valor;
        }

        public double Valor { get; set; }
    }
}
