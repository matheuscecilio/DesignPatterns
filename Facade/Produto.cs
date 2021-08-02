namespace DesignPatterns.Facade
{
    public class Produto
    {
        public Produto(
            string nome, 
            string descricao, 
            double valor
        )
        {
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
        }

        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public double Valor { get; private set; }
    }
}
