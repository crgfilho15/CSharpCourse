using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2;

            // Comparando por Endereço de Memória
            Console.WriteLine(p1 == p2); // False
            Console.WriteLine(p2 == p3); // True
            Console.WriteLine(p1.Equals(p2)); // False. Tem a opção de implementar o Método Equals e HashCode na classe 'Produtos' para fazer a comparação sem ser por Endereço de Memória


        }
    }
}
