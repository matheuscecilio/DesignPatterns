using System;

namespace DesignPatterns.FactoryMethod
{
    public abstract class Banco
    {
        public Boleto GerarBoleto(int vencimento, double valor)
        {
            var boleto = CriarBoleto(vencimento, valor);

            Console.WriteLine($"Juros: {boleto.CalcularJuros()}");
            Console.WriteLine($"Desconto: {boleto.CalcularDesconto()}");
            Console.WriteLine($"Multa: {boleto.CalcularMulta()}");

            return boleto;
        }

        protected abstract Boleto CriarBoleto(int vencimento, double valor);
    }
}
