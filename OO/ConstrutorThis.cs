using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Animal
    {
        public string Nome { get; set; }

        public Animal(string nome)
        {
            Nome = nome;
        }
    }

    public class Cachorro : Animal
    {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome) // O 'base' chama o construtor da classe pai. Pelo menos um dos contrutores precisar chamar o 'base', ou seja, todas as instâncias de uma herança precisam ter seus construtores chamados.
        {
            Console.WriteLine($"Cachorro {nome} inicializado");
        }

        public Cachorro(string nome, double altura) : this(nome) // O 'this' chama o construtor da própria classe, que irá chamar o construtor 'base', nesse caso.
        {
            Altura = altura;
        }

        public override string ToString() // Sobreescrevendo o método 'ToString()' para converter um objeto em uma String
        {
            return $"{Nome} tem {Altura} cm de altura!";
        }

    }

    class ConstrutorThis
    {
        public static void Executar()
        {
            var spike = new Cachorro("Spike");
            var max = new Cachorro("Max", 40.0);

            Console.WriteLine(spike); // Utilizando o ToString()
            Console.WriteLine(max.ToString()); // Outra forma de utilizar o ToString()
        }
    }
}
