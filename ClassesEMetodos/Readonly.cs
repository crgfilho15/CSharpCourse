using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Cliente
    {
        public string Nome;
        public readonly DateTime Nascimento; // readonly: Após setar o valor dentro do construtor, ele não poderá mais ser alterado. O const não poderia ser usado pois ele teria que ser setado na declaração e não no construtor.

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento()
        {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }

    class Readonly
    {
        public static void Executar()
        {
            var novoCliente = new Cliente("Ana Silva", new DateTime(1987, 5, 22));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());

            //novoCliente.Nascimento = new DateTime(2000, 10, 05); // readonly: Após setar o valor dentro do construtor, ele não poderá mais ser alterado.
        }
    }
}
