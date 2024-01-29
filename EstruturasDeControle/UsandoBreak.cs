using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class UsandoBreak
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("O número que queremos é o {0}", numero);

            for (int i = 1; i <= 50; i++)
            {
                Console.Write("{0} é o número que queremos? ", i);
                if(i == numero)
                {
                    Console.WriteLine("Sim!");
                    break; // O 'break' funciona para 'switch' ou a um laço de repetição ('for', ...), ele não está associado ao 'if'. Ele serve para interromper um laço de repetição.
                } else
                {
                    Console.WriteLine("Não!");
                }
            }

            Console.WriteLine("Fim!");
        }
    }
}
