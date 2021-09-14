namespace DesignPatterns.Bridge
{
    public interface ICanalEnvio
    {
        void EnviarMensagem(
            string assunto,
            string descricao
        );
    }
}
