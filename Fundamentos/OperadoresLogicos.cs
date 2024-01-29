using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            bool comprouTv50 = executouTrabalho1 && executouTrabalho2; // Operador binário - AND (E)
            Console.WriteLine("Comprou a TV 50? {0}", comprouTv50);

            bool comprouSorvete = executouTrabalho1 || executouTrabalho2; // Operador binário - OR (Ou)
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2; // Operador binário - XOR (Ou exclusivo)
            Console.WriteLine("Comprou a TV 32? {0}", comprouTv32);

            Console.WriteLine("Mais saudável? {0}", !comprouSorvete); // Operador unário - NOT (Negação)
        }
    }
}
