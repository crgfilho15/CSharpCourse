using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Params
    {
        public static void Recepcionar(params string[] pessoas) // ao utilizar 'params' eu posso passar vários parâmetros para a função, ela irá receber todos e armazenar no array 'pessoas'
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine("Olá {0}", pessoa);
            }
        }

        public static void Executar()
        {
            Recepcionar("Carlos", "Roberto", "Érica", "Marcus");
        }
    }
}
