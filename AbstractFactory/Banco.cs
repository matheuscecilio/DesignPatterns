using DesignPatterns.AbstractFactory.Interfaces;
using System;

namespace DesignPatterns.AbstractFactory
{
    public class Banco
    {
        public Boleto GerarBoleto(double valor, ICalculosFactory factory) 
        {
            var boleto = new Boleto(valor, factory);

            Console.WriteLine($"Juros: {boleto.CalcularJuros()}");
            Console.WriteLine($"Desconto: {boleto.CalcularDesconto()}");
            Console.WriteLine($"Multa: {boleto.CalcularMulta()}");

            return boleto;
        }
    }
}
