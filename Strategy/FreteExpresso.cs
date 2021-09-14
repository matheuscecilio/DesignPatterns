using DesignPatterns.Strategy.Interfaces;
using System;

namespace DesignPatterns.Strategy
{
    public class FreteExpresso : IFrete
    {
        public double Calcula(double valor)
            => valor * 0.05;
    }
}
