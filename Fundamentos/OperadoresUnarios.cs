using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); // Inverte o sinal
            Console.WriteLine(!booleano); // Inverte a lógica

            numero1++; // colocar o ++/-- depois do nome da variável implica em uma prioridade menor na incrementação/decrementação
            Console.WriteLine(numero1);

            --numero1; // colocar o ++/-- depois do nome da variável implica em uma prioridade maior na incrementação/decrementação
            Console.WriteLine(numero1);

            // Exemplificando a prioridade na incrementação/decrementação
            Console.WriteLine(numero1++ == --numero2); // Só vai incrementar o numero1 somente depois da comparação, já o numero2 vai ser decrementado antes da comparação
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}
