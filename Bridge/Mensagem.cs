namespace DesignPatterns.Bridge
{
    public abstract class Mensagem
    {
        protected Mensagem(ICanalEnvio canal)
        {
            Canal = canal;
        }

        public string Descricao { get; set; }
        public string Assunto { get; set; }
        public ICanalEnvio Canal { get; set; }

        public abstract void Enviar();
    }
}
