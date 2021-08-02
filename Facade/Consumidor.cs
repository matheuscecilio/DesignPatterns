namespace DesignPatterns.Facade
{
    public class Consumidor
    {
        public Consumidor(
            string nome, 
            string cpf, 
            string email
        )
        {
            Nome = nome;
            CPF = cpf;
            Email = email;
        }

        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string Email { get; private set; }
    }
}
