using System;
using System.Collections.Generic;
using System.Text;

// Action é uma função sem retorno (void).
// Func eu defino passando os parâmetros e o último é o retorno: Func<int, int, int, string> formatarData
// Funcções Lambda (Funções Anônimas): Func/Action nomeFunção = (Parâmetros) => Escopo;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            // Action sem parâmetro
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lambda com C#!");
            };

            algoNoConsole();

            // Action com parâmetro
            Action<string> algoNoConsole1 = a =>
            {
                Console.WriteLine("Lambda com C#!" + a);
            };

            algoNoConsole1("!!!!");

            // Função que não recebe parâmetro e retorna um inteiro
            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            // Função que recebe um numero como parâmetro e retorna uma string, o ToString()
            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            // Função que recebe 3 números como parâmetro e retorna uma string
            Func<int, int, int, string> formatarData = (dia, mes, ano) => String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(1, 1, 2000));
        }
    }
}
