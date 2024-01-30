using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        //Métodos de Classe - Estáticos
        public static int Somar(int a, int b) // Método estático, método da classe, consigo utilizá-lo sem precisar de uma instância de um objeto
        {
            return a + b;
        }

        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        // Método de instância - Não estático
        public int Dividir(int a, int b)
        {
            return a / b;
        }
    }
    class MetodosEstaticos
    {
        public static void Executar()
        {
            //Métodos de Classe - Estáticos
            var resultado = CalculadoraEstatica.Multiplicar(2, 2); // Não precisou de uma instância da classe para utilizar o método
            Console.WriteLine("Resultado: {0}", resultado);

            Console.WriteLine(CalculadoraEstatica.Somar(2, 2));

            // Método de instância - Não estático
            CalculadoraEstatica calc = new CalculadoraEstatica(); 

            Console.WriteLine(calc.Dividir(100, 20)); // Precisou de uma instância da classe para utilizar o método
        }
    }
}
