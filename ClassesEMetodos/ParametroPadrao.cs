using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametroPadrao
    {
        public static int Somar(int a = 2, int b = 1) // Caso o usuário não informe os valores, eles possuem valores padrão para serem utilizados
        {
            return a + b;
        }

        public static void Executar()
        {
            Console.WriteLine(Somar(10, 23));
            Console.WriteLine(Somar(50));
            Console.WriteLine(Somar());
            Console.WriteLine(Somar(b: 7));
        }
    }
}
