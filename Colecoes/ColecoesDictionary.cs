using System;
using System.Collections.Generic; // Precisa desse import para utilizar Dictionary com o Generics

namespace CursoCSharp.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>(); // Aceita repetição de valor (nesse caso, string), mas não na chave (nesse caso, int)

            filmes.Add(2000, "Gladiador"); // Adiciona um novo objeto ao Dicionário
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            if(filmes.ContainsKey(2004)) // Verifica se existe objeto com a chave indicada
            {
                Console.WriteLine("2004: " + filmes[2004]); // Não indicado: Retorna uma exceção (erro) caso não haja correspondência,
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004)); // Indicado: Retorna uma String vazia caso não haja correspondência, ao invés de uma exceção

                Console.WriteLine(filmes.ContainsValue("Amnésia")); // Verifica se existe objeto com o valor indicado, retorna true ou false

                Console.WriteLine($"Removeu? {filmes.Remove(2004)}"); // Remove e retorna true ou false (caso não exista a chave)

                filmes.TryGetValue(2006, out string filmes2006); // Pega o objeto referente à chave indicada e atribui na variável passada no segundo parâmetro. Não gera erro se não existir.
                Console.WriteLine($"Filme {filmes2006}");

                // Percorrer chaves
                foreach(var chave in filmes.Keys)
                {
                    Console.WriteLine(chave);
                }

                // Percorrer valores
                foreach(var valor in filmes.Values)
                {
                    Console.WriteLine(valor);
                }

                // Forma 1 - Percorrer chave e valor
                foreach(KeyValuePair<int, string> filme in filmes)
                {
                    Console.WriteLine($"{filme.Value} é de {filme.Key}.");
                }

                // Forma 2 - Percorrer chave e valor
                foreach (var filme in filmes)
                {
                    Console.WriteLine($"{filme.Value} é de {filme.Key}.");
                }
            }
        }
    }
}
