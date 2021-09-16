using System;
using System.Collections.Generic;

namespace DesignPatterns.Composite
{
    public abstract class Componente
    {
        protected Componente(string nome, string caminho)
        {
            Nome = nome;
            Caminho = caminho;
            Componentes = new();
        }

        public string Nome { get; set; }
        public string Caminho { get; set; }
        public List<Componente> Componentes { get; set; }

        public virtual void Adicionar(Componente componente)
            => throw new NotImplementedException();

        public virtual void Remover(Componente componente)
            => throw new NotImplementedException();

        public virtual Componente RecuperarFilho(int indice)
            => throw new NotImplementedException();

        public abstract void Exibir();
    }
}
