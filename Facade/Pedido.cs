using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class Pedido
    {
        public Pedido(Consumidor consumidor)
        {
            Consumidor = consumidor;
            Produtos = new();
            Valor = 0;
        }

        public Consumidor Consumidor { get; private set; }
        public List<Produto> Produtos { get; private set; }
        public double Valor { get; private set; }

        public void AdicionarConsumidor(Consumidor consumidor)
            => Consumidor = consumidor;

        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
            Valor += produto.Valor;
        }        
    }
}
