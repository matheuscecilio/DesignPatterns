using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class PagamentoBoleto : Pagamento
    {
        public PagamentoBoleto(Pedido pedido) : base(pedido) { }

        public override bool RealizarPagamento()
        {
            if (Pedido.Valor > 0)
            {
                return true;
            }

            return false;
        }
    }
}
