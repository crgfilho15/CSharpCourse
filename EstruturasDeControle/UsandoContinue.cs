using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class UsandoContinue
    {
        public static void Executar()
        {
            int intervalo = 50;
            Console.WriteLine("Números pares entre 1 e {0}!", intervalo);

            for (int i = 1; i <= intervalo; i++)
            {
                if (i % 2 == 1)
                {
                    continue; // O 'continue' irá para a próxima repetição (próximo 'i') sem executar nada que está abaixo dentro do laço de repetição.
                }

                Console.Write(i + " ");
            }
        }
    }
}
