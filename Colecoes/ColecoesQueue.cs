using System;
using System.Collections.Generic; // Precisa desse import para utilizar o Queue com Generics: <string>
using System.Collections; // Precisa desse import para utilizar Queue sem o Generics

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue // Queue = Fila [FIFO (First In, First Out) - Primeiro a chegar, primeiro a sair]
    {
        public static void Executar()
        {
            var fila = new Queue<string>(); // Fila Genérica

            fila.Enqueue("Carlos"); // Adicionando um item na Fila
            fila.Enqueue("Roberto");
            fila.Enqueue("Érica");
            fila.Enqueue("Érica"); // Aceita Repetição

            Console.WriteLine(fila.Peek()); // Peek: Pega o próximo elemento a sair da fila (não o remove)
            Console.WriteLine(fila.Count); // Número de objetos na Fila

            Console.WriteLine(fila.Dequeue()); // Dequeue: Remove o próximo elemento a sair da fila e o retorna
            Console.WriteLine(fila.Count);

            foreach(var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            // Fila Não Genérica
            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("Item")); // Verifica se na Queue tem o objeto indicado
        }
    }
}
