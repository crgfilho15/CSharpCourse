using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // Área da Circunferência
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 3.1415;

            double area = PI * raio * raio;

            Console.WriteLine(area);
            Console.WriteLine("A área é " + area);

            // Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo? " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade: " + idade);

            sbyte saldoDeGols = sbyte.MinValue; // byte com sinal negativo
            Console.WriteLine("Saldo de Gols: " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário: " + salario);

            int menorValorInt = int.MinValue; // Mais usado dos inteiros
            Console.WriteLine("Menor Valor Int: " + menorValorInt);

            uint populacaoBrasileira = 207_600_000; // Int sem sinal negativo // Pode usar '_' no número para facilitar a identificação visual
            Console.WriteLine("População Brasileira: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Long: " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000; // Long sem sinal negativo
            Console.WriteLine("População Mundial: " + populacaoMundial);

            float precoComputador = 1299.99f; // O doble tem o dobro de armazenamento do float, no float precisa colocar um 'f' na frente do número.
            Console.WriteLine("Preço do Computador: " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; // O double é o tipo mais utilizado dos reais
            Console.WriteLine("Valor Apple: " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue; // Valor astronômicos
            Console.WriteLine("Distância Estrelas: " + distanciaEntreEstrelas);

            char letra = 'b'; // Aspas simples para char
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao Curso de C#"; // Aspas duplas para string
            Console.WriteLine(texto);
        }
    }
}
