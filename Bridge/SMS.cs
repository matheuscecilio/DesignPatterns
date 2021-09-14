using System;

namespace DesignPatterns.Bridge
{
    public class SMS : ICanalEnvio
    {
        public void EnviarMensagem(string assunto, string descricao)
        {
            Console.WriteLine($"Assunto: {assunto}");
            Console.WriteLine($"Mensagem: {descricao}");
        }
    }
}
