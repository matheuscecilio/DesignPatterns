using DesignPatterns.State.Interfaces;
using System;

namespace DesignPatterns.State
{
    public class Pago : IEstadoPedido
    {
        private Pedido Pedido { get; set; }

        public Pago(Pedido pedido)
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
            var estadoEnviado = Pedido.Enviado;
            Pedido.ModificarEstadoAtual(estadoEnviado);
        }

        public void SucessoAoPagar()
        {
            throw new Exception("Opeação inválida! O pedido já foi pago!");
        }
    }
}
