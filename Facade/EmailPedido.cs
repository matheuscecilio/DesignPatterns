using System;

namespace DesignPatterns.Facade
{
    public class EmailPedido
    {
        public EmailPedido(Pedido pedido)
        {
            Pedido = pedido;
        }

        protected Pedido Pedido { get; set; }

        public void EnviarEmail(string mensagem)
        {
            Console.WriteLine($"E-mail enviado para {Pedido.Consumidor.Email}.");
            Console.WriteLine($"Mensagem: {mensagem}");
        }
    }
}
