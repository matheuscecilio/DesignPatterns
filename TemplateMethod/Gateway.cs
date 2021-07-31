using System;

namespace DesignPatterns.TemplateMethod
{
    public class Gateway
    {
        public void Cobrar(double valor) => Console.WriteLine($"Cobrado valor de R$ {valor}");
    }
}
