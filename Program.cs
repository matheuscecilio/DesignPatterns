using DesignPatterns.AbstractFactory;
using DesignPatterns.AbstractFactory.BancoDoBrasil;
using DesignPatterns.AbstractFactory.Caixa;
using DesignPatterns.Adapter;
using DesignPatterns.Adapter.Terceiros;
using DesignPatterns.Facade;
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

            //State();

            //Adapter();

            Facade();
        }

        private static void Facade()
        {
            var consumidor = new Consumidor(
                "José",
                "123.456.789-00",
                "jose@jose.com.br"
            );

            var vendaFacade = new VendaFacade(consumidor);
            vendaFacade.AdicionarProduto(new Produto("P1", "P1", 15));
            vendaFacade.AdicionarProduto(new Produto("P2", "P2", 25));
            vendaFacade.AdicionarProduto(new Produto("P3", "P3", 35));

            vendaFacade.PedidoCredito();
        }

        private static void Adapter()
        {
            var pagFacilAdapter = new PagFacilAdapter();
            var cobranca = new Cobranca(pagFacilAdapter);
            cobranca.AdicionarValor(100);
            cobranca.AdicionarParcelas(5);
            cobranca.AdicionarNumeroCartao("1234 5678 9012 3456");
            cobranca.AdicionarCVV("123");

            if (cobranca.RealizarPagamento())
            {
                Console.WriteLine("Pagamento realizado com sucesso");
            }
            else
            {
                Console.WriteLine("Erro o realizar pagamento");
            }

            var topPagamentos = new TopPagamentos();
            var topPagamentosAdapter = new TopPagamentosAdapter(topPagamentos);
            cobranca.AdicionarGateway(topPagamentosAdapter);
            cobranca.AdicionarValor(100);
            cobranca.AdicionarParcelas(5);
            cobranca.AdicionarNumeroCartao("1234 5678 9012 3456");
            cobranca.AdicionarCVV("123");

            if (cobranca.RealizarPagamento())
            {
                Console.WriteLine("Pagamento realizado com sucesso");
            }
            else
            {
                Console.WriteLine("Erro o realizar pagamento");
            }
        }

        private static void State()
        {
            var pedido = new State.Pedido();
            pedido.RealizarPagamento();
            pedido.DespacharPedido();
            pedido.CancelarPedido();
        }

        private static void TemplateMethod()
        {
            var valor = 1000;
            var gateway = new Gateway();

            Console.WriteLine("Crédito");
            var pagamentoCredito = new TemplateMethod.PagamentoCredito(valor, gateway);
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
