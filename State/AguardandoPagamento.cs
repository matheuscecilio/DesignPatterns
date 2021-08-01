using DesignPatterns.State.Interfaces;
using System;

namespace DesignPatterns.State
{
    public class AguardandoPagamento : IEstadoPedido
    {
        private Pedido Pedido { get; set; }

        public AguardandoPagamento(Pedido pedido)
        {
            Pedido = pedido;
        }

        public void CancelarPedido()
        {
            var estadoCancelado = Pedido.Cancelado;
            Pedido.ModificarEstadoAtual(estadoCancelado);
        }

        public void DespacharPedido()
        {
            throw new Exception("Opeação inválida. O pedido ainda não pago!");
        }

        public void SucessoAoPagar()
        {
            var estadoPago = Pedido.Pago;
            Pedido.ModificarEstadoAtual(estadoPago);
        }
    }
}
