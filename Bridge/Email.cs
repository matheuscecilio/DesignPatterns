using System;

namespace DesignPatterns.Bridge
{
    public class Email : ICanalEnvio
    {
        public void EnviarMensagem(string assunto, string descricao)
        {
            Console.WriteLine($"Assunto: {assunto}");
            Console.WriteLine($"Mensagem: {descricao}");
        }
    }
}
