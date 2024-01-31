using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 10;

        public static void Executar()
        {
            // Acessar a variável 'a' dentro do método Executar()
            DesafioAtributo desafio = new DesafioAtributo();

            Console.WriteLine(desafio.a);
        }
    }
}
