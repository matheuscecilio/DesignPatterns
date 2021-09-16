namespace DesignPatterns.Composite
{
    public class GerenciadorDeArquivos
    {
        public GerenciadorDeArquivos(Componente componente)
        {
            Componente = componente;
        }

        public Componente Componente { get; set; }

        public void ExibirTodos()
            => Componente.Exibir();
    }
}
