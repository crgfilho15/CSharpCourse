using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Array
    {
        public static void Executar()
        {
            //string []alunos = new string[6]; // Pode declarar dessa forma também
            string[] alunos = new string[6]; // Array é uma estrutura homogênea e estática, ou seja, só armazena 1 tipo de dado e não cresce mais do que o definido.
            alunos[0] = "Carlos";
            alunos[1] = "Érica";
            alunos[2] = "Marcus";
            alunos[3] = "Juliana";
            alunos[4] = "Mariana";
            alunos[5] = "Fernanda";

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach (var nota in notas)
            {
                somatorio += nota;
            }

            //for(int i = 0; i < notas.Length; i++)
            //{
            //    somatorio += notas[i];
            //}

            double media = somatorio / notas.Length;
            Console.WriteLine("Média: {0}", media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new String(letras);
            Console.WriteLine(palavra);
        }
    }
}
