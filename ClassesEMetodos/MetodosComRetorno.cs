using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class calculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Dividir(int a, int b)
        {
            return a / b;
        }

        //public int Somar(int c, int d, int e) // Posso criar 2 métodos com o mesmo nome, desde que o número de parâmetros ou a ordem deles seja diferente (caso o tipo de dado do parâmetro seja diferente)
        //{
        //    return c + d + e;
        //}
    }

    class CalculadoraCadeia
    {
        int memoria; // variável interna dentro da classe (não é pública), por isso, letra minúscula

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this; // Retornando o próprio objeto do tipo CalculadoraCadeia, serve para encadear várias chamadas
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado()
        {
            return memoria;
        }
    }

    class MetodosComRetorno
    {
        public static void Executar()
        {
            // Calculadora Comum
            Console.WriteLine("Calculadora Comum");
            var calculadoraComum = new calculadoraComum();
            var resultado = calculadoraComum.Somar(5, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(7, 5));
            Console.WriteLine(calculadoraComum.Multiplicar(3, 3));
            Console.WriteLine(calculadoraComum.Dividir(6, 2));

            // Calculadora Cadeia
            Console.WriteLine("Calculadora Cadeia");
            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();
            resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado();
            Console.WriteLine(resultado);
        }
    }
}
