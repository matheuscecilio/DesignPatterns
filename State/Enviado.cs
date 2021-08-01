using DesignPatterns.State.Interfaces;
using System;

namespace DesignPatterns.State
{
    public class Enviado : IEstadoPedido
    {
        public void CancelarPedido()
        {
            throw new Exception("Opeação inválida! O pedido já foi pago e enviado!");
        }

        public void DespacharPedido()
        {
            throw new Exception("Opeação inválida! O pedido já foi pago e enviado!");
        }

        public void SucessoAoPagar()
        {
            throw new Exception("Opeação inválida! O pedido já foi pago e enviado!");
        }
    }
}
