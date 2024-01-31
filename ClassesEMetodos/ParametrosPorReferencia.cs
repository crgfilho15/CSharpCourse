using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero)
        {
            numero = numero + 1000;
        }

        public static void AlterarOut(out int numero)
        {
            numero = 0;
            numero = numero + 15;
        }

        public static void Executar()
        {
            // Ref
            int a = 3;
            AlterarRef(ref a); // Passei a referência de 'a'
            Console.WriteLine(a);

            // Out (Mais recomendado para utilizar)
            //int b;
            AlterarOut(out int b); // O 'out' é unidirecional, ou seja, somente recebo a variável sem atribuir nenhum valor à ela antes de passar à função. Também dá para passar 2 valores e receber 2 valores de saída.
            Console.WriteLine(b);
        }
    }
}
