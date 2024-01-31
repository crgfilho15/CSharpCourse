using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano)
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano); // ':D2' formata para completar o número com zeros à esquerda até ficar com 2 caracteres, caso necessário
        }

        public static void Executar()
        {
            Formatar(mes: 1, dia: 6, ano: 1996); // Parâmetros nomeados: Facilita a chamada da função, ainda mais no caso de 3 parâmetros do mesmo tipo
        }
    }
}
