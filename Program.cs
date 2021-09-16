using DesignPatterns.AbstractFactory;
using DesignPatterns.AbstractFactory.BancoDoBrasil;
using DesignPatterns.AbstractFactory.Caixa;
using DesignPatterns.Adapter;
using DesignPatterns.Adapter.Terceiros;
using DesignPatterns.Bridge;
using DesignPatterns.ChainOfResponsability;
using DesignPatterns.Composite;
using DesignPatterns.Facade;
using DesignPatterns.FactoryMethod.BancoDoBrasil;
using DesignPatterns.FactoryMethod.Caixa;
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

            //Facade();

            //Bridge();

            //ChainOfResponsability();

            Composite();
        }

        private static void Composite()
        {
            var raiz = new Pasta("Raiz", "/");

            var pasta1 = new Pasta("Pasta 1", "/pasta1");
            var pasta2 = new Pasta("Pasta 2", "/pasta2");
            var pasta2_1 = new Pasta("Pasta 2.1", "/pasta2-1");
            var pasta3 = new Pasta("Pasta 3", "/pasta3");

            var arq1 = new Arquivo("Arquivo 1", "/arquivo1");
            var arq2 = new Arquivo("Arquivo 2", "/arquivo2");
            var arq3 = new Arquivo("Arquivo 3", "/arquivo3");
            var arq4 = new Arquivo("Arquivo 4", "/arquivo4");
            var arq5 = new Arquivo("Arquivo 5", "/arquivo5");
            var arq6 = new Arquivo("Arquivo 6", "/arquivo6");

            raiz.Adicionar(pasta1);
            raiz.Adicionar(pasta2);
            raiz.Adicionar(pasta3);

            pasta2.Adicionar(pasta2_1);
            pasta1.Adicionar(arq1);
            pasta1.Adicionar(arq2);
            pasta2.Adicionar(arq3);
            pasta2.Adicionar(arq4);
            pasta2_1.Adicionar(arq5);
            pasta3.Adicionar(arq6);

            var gerenciador = new GerenciadorDeArquivos(raiz);
            gerenciador.ExibirTodos();
        }

        private static void ChainOfResponsability()
        {
            var pedido = new ChainOfResponsability.Pedido(109);

            var pontos = CalculadorDePontos.CalcularPontosPedido(
                pedido,
                16
            );

            Console.WriteLine($"Pontos: {pontos}");
        }

        private static void Bridge()
        {
            ICanalEnvio canal = new Email();

            Mensagem mensagem = new MensagemAdmin(canal);
            mensagem.Assunto = "Assunto 1";
            mensagem.Descricao = "Desc 1";
            mensagem.Enviar();

            mensagem = new MensagemUsuario(canal);
            mensagem.Assunto = "Assunto 2";
            mensagem.Descricao = "Desc 2";
            mensagem.Enviar();

            canal = new SMS();

            mensagem = new MensagemAdmin(canal);
            mensagem.Assunto = "Assunto 3";
            mensagem.Descricao = "Desc 3";
            mensagem.Enviar();

            mensagem = new MensagemUsuario(canal);
            mensagem.Assunto = "Assunto 4";
            mensagem.Descricao = "Desc 4";
            mensagem.Enviar();
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
