using System;

namespace DesignPatterns.Composite
{
    public class Pasta : Componente
    {
        public Pasta(string nome, string caminho) : base(nome, caminho) { }

        public override void Adicionar(Componente componente)
            => Componentes.Add(componente);

        public override void Remover(Componente componente)
            => Componentes.Remove(componente);

        public override Componente RecuperarFilho(int indice)
            => Componentes[indice];

        public override void Exibir()
        {
            Console.Write("    ");
            Console.Write($" - {Nome} - [{Caminho}] {Environment.NewLine}");
            Console.Write($"--------------------------------------{Environment.NewLine}");

            foreach(var componente in Componentes)
            {
                componente.Exibir();
            }
        }


    }
}
