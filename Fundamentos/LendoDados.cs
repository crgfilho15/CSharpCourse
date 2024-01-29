using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome?");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade?");
            int idade = int.Parse(Console.ReadLine()); // O ReadeLine recebe uma String

            Console.Write("Qual é o seu salário?");
            double salario = double.Parse(Console.ReadLine());

            Console.Write("Qual é o seu 2º salário?");
            double salario2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Para aceitar entradas com o ponto sendo o separador de casas decimais e não a vírgula (tem que importarno início: using System.Globalization;)

            Console.WriteLine($"{nome} {idade} R${salario} e R${salario2}");
        }
    }
}
