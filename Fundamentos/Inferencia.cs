using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "Carlos";
            Console.WriteLine(nome);
            //nome = 123;

            int a; // Declaração
            a = 3; // Inicialização
            int b = 2; // Declaração e Inicialização
            Console.WriteLine(a+b);

            //var idade; // Não pode somente declarar um var e não inicializar
            var idade = 32;
            Console.WriteLine(idade);


        }
    }
}
