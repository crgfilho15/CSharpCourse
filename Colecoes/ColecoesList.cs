using System;
using System.Collections.Generic; // Precisa desse import para utilizar o Generics: <Produto> (Exceto para o ArrayList, que não precisa importar o Generics)
using System.Text;

namespace CursoCSharp.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj) // Implementando para fazer comparações de objetos sem ser por Endereço de Memória
        {
            var produto = obj as Produto;
            return produto != null &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public override int GetHashCode() // Implementando para fazer comparações de objetos sem ser por Endereço de Memória
        {
            var hashCode = -347481536;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + Preco.GetHashCode();
            return hashCode;
        }
    }

    class ColecoesList
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new List<Produto>(); // Uma 'List' para armazenar objetos do tipo "Produto". A lista é dinâmica, pode crescer indefinidamente
            carrinho.Add(livro);

            var combo = new List<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("8ªT Game of Thrones", 99.9),
                new Produto("Poster", 10)
            };

            carrinho.AddRange(combo); // Adicionar uma Lista dentro da outra
            Console.WriteLine(carrinho.Count); // Conta o número de itens da Lista
            carrinho.RemoveAt(3); // Removendo o item 3 da Lista através do índice

            foreach(var item in carrinho)
            {
                Console.WriteLine(carrinho.IndexOf(item)); // Pega o índice do item na Lista
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro); // List aceita repetição (2 elementos iguais)
            Console.WriteLine(carrinho.Count);
        }
    }
}
