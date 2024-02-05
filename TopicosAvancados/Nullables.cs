using System;
using System.Collections.Generic;
using System.Text;

// Nullables: Fazer que com que alguns tipos possam receber nulo
// É recomendado evitar trabalhar com valores nulos, porém quando eventualmente fore preciso, tem formas mais recomendadas abaixo

namespace CursoCSharp.TopicosAvancados
{
    class Nullables
    {
        public static void Executar()
        {
            Nullable<int> num1 = null;
            int? num2 = null;
            //int num3 = null; // Erro

            if (num1.HasValue)
            {
                Console.WriteLine("Valor de num: {0}", num1);
            } else
            {
                Console.WriteLine("A variável não possui valor.");
            }

            int valor = num1 ?? 1000; // Valor padrão de num1 estiver nulo
            Console.WriteLine(valor);

            bool? booleano = null;
            bool resultado = booleano.GetValueOrDefault(); // Default = false

            Console.WriteLine(resultado);

            try
            {
                int x = num1.GetValueOrDefault();
                int y = num2.GetValueOrDefault();
                Console.WriteLine(x + y);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
