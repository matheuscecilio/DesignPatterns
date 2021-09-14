using System;

namespace DesignPatterns.Bridge
{
    public class MensagemUsuario : Mensagem
    {
        public MensagemUsuario(ICanalEnvio canal) : base(canal) { }

        public override void Enviar()
        {
            Console.WriteLine("Enviado pelo usuário");
            Canal.EnviarMensagem(Assunto, Descricao);
        }
    }
}
