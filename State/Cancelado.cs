using DesignPatterns.State.Interfaces;
using System;

namespace DesignPatterns.State
{
    public class Cancelado : IEstadoPedido
    {
        public void CancelarPedido()
        {
            throw new Exception("Opeação inválida! O pedido já se econtra cancelado!");
        }

        public void DespacharPedido()
        {
            throw new Exception("Opeação inválida! O pedido se encontra cancelado!");
        }

        public void SucessoAoPagar()
        {
            throw new Exception("Opeação inválida! O pedido se encontra cancelado!");
        }
    }
}
