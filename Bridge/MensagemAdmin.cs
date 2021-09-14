using System;

namespace DesignPatterns.Bridge
{
    public class MensagemAdmin : Mensagem
    {
        public MensagemAdmin(ICanalEnvio canal) : base(canal) { }

        public override void Enviar()
        {
            Console.WriteLine("Enviado pelo admin");
            Canal.EnviarMensagem(Assunto, Descricao);
        }
    }
}
