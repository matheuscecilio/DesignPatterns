using System;

namespace DesignPatterns.FactoryMethod.Caixa
{
    public class BancoCaixa : Banco
    {
        protected override Boleto CriarBoleto(int vencimento, double valor)
            => vencimento switch
            {
                10 => new BoletoCaixa10Dias(valor),
                30 => new BoletoCaixa30Dias(valor),
                60 => new BoletoCaixa60Dias(valor),
                _ => throw new Exception("Vencimento inválido"),
            };
    }
}
