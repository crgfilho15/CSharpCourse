using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // 1 casa decimal
            Console.WriteLine(valor.ToString("C")); // Valor monetário
            Console.WriteLine(valor.ToString("P")); // Percentual (multiplica por 100 e coloca o %)
            Console.WriteLine(valor.ToString("#.##")); // Especifica as casas decimais

            CultureInfo cultura = new CultureInfo("pt-BR"); // P/ utilizar os padrões de determinado país
            Console.WriteLine(valor.ToString("C0", cultura)); // Valor monetário sem casas decimais

            CultureInfo cultura1 = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C2", cultura1)); // Valor monetário com 2 casas decimais

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // Completa com zeros à esquerda para ficar com 10 caracteres
        }
    }
}
