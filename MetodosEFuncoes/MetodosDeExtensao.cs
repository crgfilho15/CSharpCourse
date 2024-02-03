using System;
using System.Collections.Generic;
using System.Text;

// Uma função é de extensão quando utiliza-se o 'this' associado com o tipo do parâmetro: public static int Soma(this int num, int outroNumero)
// O primeiro parâmetro junto com o 'this' definirá o tipo que queremos extender com a função
// Dá para criar funções que não existiam previamente nos tipos e utilizá-las como se fossem próprias da API do C#

namespace CursoCSharp.MetodosEFuncoes
{
    public static class ExtensoesInteiro
    {
        public static int Soma(this int num, int outroNumero)
        {
            return num + outroNumero;
        }

        public static double Subtracao(this double num, double outroNumero)
        {
            return num - outroNumero;
        }
    }

    class MetodosDeExtensao
    {
        public static void Executar()
        {
            int numero = 5;
            double numeroReal = 5.5;

            Console.WriteLine(numero.Soma(3));
            Console.WriteLine(numeroReal.Subtracao(10));

            Console.WriteLine(2.Soma(3));
            Console.WriteLine(2.9.Subtracao(4.9));
        }
    }
}
