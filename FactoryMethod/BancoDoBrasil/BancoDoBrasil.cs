using System;

namespace DesignPatterns.FactoryMethod.BancoDoBrasil
{
    public class BancoDoBrasil : Banco
    {
        protected override Boleto CriarBoleto(int vencimento, double valor)
            => vencimento switch
            {
                10 => new BoletoBancoDoBrasil10Dias(valor),
                30 => new BoletoBancoDoBrasil30Dias(valor),
                60 => new BoletoBancoDoBrasil60Dias(valor),
                _ => throw new Exception("Vencimento inválido"),
            };
    }
}
