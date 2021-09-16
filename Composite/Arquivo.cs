using System;

namespace DesignPatterns.Composite
{
    public class Arquivo : Componente
    {
        public Arquivo(string nome, string caminho) : base(nome, caminho) { }

        public override void Exibir()
            => Console.Write($" - {Nome} - [{Caminho}] {Environment.NewLine}");
    }
}
