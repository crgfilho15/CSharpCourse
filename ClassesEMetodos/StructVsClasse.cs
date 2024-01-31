using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public struct SPonto
    {
        public int X;
        public int Y;
    }

    public class CPonto
    {
        public int X;
        public int Y;
    }

    class StructVsClasse
    {
        public static void Executar()
        {
            // A atribuição na 'struct' é sempre feita por valor e não por referência
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaPonto1 = ponto1; // Atribuição por valor (uma cópia é atribuída à variável 'copiaPonto1', e não o endereço de memória de 'ponto1')
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 X: {0}", ponto1.X);
            Console.WriteLine("Copia Ponto 1 X: {0}", copiaPonto1.X);

            // A atribuição na 'classe' é sempre feita por referência e não por valor
            CPonto ponto2 = new CPonto { X = 2, Y = 4 };
            CPonto copiaPonto2 = ponto2; // Atribuição por referência (o endereço de memória é atribuído à variável 'copiaPonto1', e não uma cópia de 'ponto1')
            ponto2.X = 4;

            Console.WriteLine("Ponto 2 X: {0}", ponto2.X);
            Console.WriteLine("Copia Ponto 2 X: {0}", copiaPonto2.X);
        }
    }
}
