using System.Collections.Generic;
using NerdStore.Core.DomainObjects;

namespace NerdStore.Catalogo.Domain
{
    public class Categoria : Entity
    {
        public string Nome { get; private set; }
        public int Codigo { get; private set; }
        public IList<Produto> Produtos { get; private set; }

        protected Categoria() { }

        public Categoria(string nome, int codigo, IList<Produto> produtos)
        {
            Nome = nome;
            Codigo = codigo;
            Produtos = produtos;
        }

        public override string ToString()
        {
            return $"{Nome} - {Codigo}";
        }
    }
}
