using DesignPatterns.AbstractFactory;
using DesignPatterns.AbstractFactory.BancoDoBrasil;
using DesignPatterns.AbstractFactory.Caixa;
using DesignPatterns.FactoryMethod.BancoDoBrasil;
using DesignPatterns.FactoryMethod.Caixa;
using DesignPatterns.State;
using DesignPatterns.TemplateMethod;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //AbtractFactory();

            //FactoryMethod();

            //TemplateMethod();

            State();
        }

        private static void State()
        {
            var pedido = new Pedido();
            pedido.RealizarPagamento();
            pedido.DespacharPedido();
            pedido.CancelarPedido();
        }

        private static void TemplateMethod()
        {
            var valor = 1000;
            var gateway = new Gateway();

            Console.WriteLine("Crédito");
            var pagamentoCredito = new PagamentoCredito(valor, gateway);
            pagamentoCredito.RealizarCobranca();

            Console.WriteLine("Débito");
            var pagamentoDebito = new PagamentoDebito(valor, gateway);
            pagamentoDebito.RealizarCobranca();

            Console.WriteLine("Dinheiro");
            var pagamentoDinheiro = new PagamentoDinheiro(valor, gateway);
            pagamentoDinheiro.RealizarCobranca();
        }

        private static void AbtractFactory()
        {
            var banco = new Banco();
            var valor = 100;

            Console.WriteLine("***BANCO DO BRASIL***");
            Console.WriteLine($"Valor: R$ {valor}");
            var factoryBancoDoBrasil = new BancoDoBrasilCalculosFactory();
            banco.GerarBoleto(valor, factoryBancoDoBrasil);

            Console.WriteLine("***CAIXA***");
            Console.WriteLine($"Valor: R$ {valor}");
            var factoryCaixa = new CaixaCalculosFactory();
            banco.GerarBoleto(valor, factoryCaixa);
        }

        private static void FactoryMethod()
        {
            var valor = 100;

            Console.WriteLine("***CAIXA***");
            Console.WriteLine($"Valor: R$ {valor}");
            var bancoCaixa = new BancoCaixa();
            bancoCaixa.GerarBoleto(10, valor);
            bancoCaixa.GerarBoleto(30, valor);
            bancoCaixa.GerarBoleto(60, valor);

            Console.WriteLine("***BANCO DO BRASIL***");
            Console.WriteLine($"Valor: R$ {valor}");
            var bancoDoBrasil = new BancoDoBrasil();
            bancoDoBrasil.GerarBoleto(10, valor);
            bancoDoBrasil.GerarBoleto(30, valor);
            bancoDoBrasil.GerarBoleto(60, valor);
        }
    }
}
