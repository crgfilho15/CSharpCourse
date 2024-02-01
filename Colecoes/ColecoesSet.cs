using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("8ªT Game of Thrones", 99.9),
                new Produto("Poster", 10)
            };

            carrinho.UnionWith(combo); // Une os 2 (Set e Set, Set e List...)
            Console.WriteLine(carrinho.Count); // Conta o número de itens
            //carrinho.RemoveAt(3); // Set não é indexado

            foreach (var item in carrinho)
            {
                //Console.WriteLine(carrinho.IndexOf(item)); // Set não é indexado
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro); // Set não aceita repetição (2 elementos iguais)
            Console.WriteLine(carrinho.Count);
        }
    }
}
