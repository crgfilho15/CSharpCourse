using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro; // double > int (não há risco de perda de informação)
            Console.WriteLine(quebrado);

            double nota = 9.7;
            //int notaTruncada = nota; // int < double (quando há risco de perda de informação, não é possível fazer a conversão de forma implícita)
            int notaTruncada = (int) nota; // Conversão explícita de double para int (casting)
            Console.WriteLine("Nota Truncada: {0}", notaTruncada);

            Console.Write("Digite a sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString); // Resultará em erro caso o usuário não digite um número
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString); // Outra forma de converter
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            // FORMA MAIS SEGURA DE FAZER A CONVERSÃO:
            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero); // Converte 'palavra' e salva em 'numero'. Tenta converter, se não conseguir, passa o valor zero ao invés de retornar um erro
            Console.WriteLine("Resultado 1: {0}", numero);

            // Compactando:
            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2: {0}", numero2);
        }
    }
}
