using DesignPatterns.State.Interfaces;
using System;

namespace DesignPatterns.State
{
    public class Pedido
    {
        public IEstadoPedido AguardandoPagamento { get; private set; }
        public IEstadoPedido Pago { get; private set; }
        public IEstadoPedido Cancelado { get; private set; }
        public IEstadoPedido Enviado { get; private set; }
        private IEstadoPedido EstadoAtual { get; set; }

        public Pedido()
        {
            AguardandoPagamento = new AguardandoPagamento(this);
            Pago = new Pago(this);
            Cancelado = new Cancelado();
            Enviado = new Enviado();

            EstadoAtual = AguardandoPagamento;
        }

        public void RealizarPagamento()
        {
            try
            {
                EstadoAtual.SucessoAoPagar();
                Console.WriteLine("Pedido pago com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DespacharPedido()
        {
            try
            {
                EstadoAtual.DespacharPedido();
                Console.WriteLine("Pedido despachado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void CancelarPedido()
        {
            try
            {
                EstadoAtual.CancelarPedido();
                Console.WriteLine("Pedido cancelado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ModificarEstadoAtual(IEstadoPedido estado)
        {
            EstadoAtual = estado;
        }
    }
}
