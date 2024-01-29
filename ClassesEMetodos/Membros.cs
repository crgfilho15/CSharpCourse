using System;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa siclano = new Pessoa(); // tipo (classe) + nome da variável = chamada do construtor (criação de objeto)
            siclano.Nome = "Carlos";
            siclano.Idade = 23;

            //Console.WriteLine($"{siclano.Nome} tem {siclano.Idade} anos.");

            siclano.ApresentarNoConsole();
            siclano.Zerar();
            siclano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Roberto";
            fulano.Idade = 30;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano);
            Console.WriteLine(apresentacaoDoFulano.Length);
        }
    }
}
