using System;
using System.Collections.Generic;
using System.Collections; // Precisa desse import para utilizar Stack sem o Generics

namespace CursoCSharp.Colecoes
{
    class ColecoesStack // Stack = Pilha [FILO (First In, Last Out) - Primeiro a chegar, último a sair]
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push(3); // Adiciona à Pilha
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach(var item in pilha)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}"); // Remove o elemento do topo da pilha e retorna o objeto

            foreach (var item in pilha)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nPeek: {pilha.Peek()}"); // Retorna o elemento do topo da pilha, sem remover
            Console.WriteLine(pilha.Count);
        }
    }
}
