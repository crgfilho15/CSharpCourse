using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1; // private (padrão se não definir)

        string nome; // private (padrão se não definir)
        public string Nome
        {
            get
            {
                return "Opcional: " + nome;
            }
            set
            {
                nome = value;
            }
        }

        // Propriedade autoimplementada
        public double Preco { get; set; }

        // Somente leitura
        public double precoComDesconto
        {
            // Forma 1 (Lambda)
            get => Preco - (desconto * Preco);

            // Forma 2
            //get
            //{
            //    return Preco - (desconto * Preco);
            //}
        }

        public CarroOpcional()
        {

        }

        public CarroOpcional(string nome, double preco)
        {
            //this.nome = nome;
            Nome = nome;
            Preco = preco;
        }

    }

    class Props
    {
        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar Condicionado", 3499.9);

            //op1.precoComDesconto = 3000; // Somente leitura

            var op2 = new CarroOpcional();
            op2.Nome = "Direção elétrica";
            op2.Preco = 2349.9;

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);
            Console.WriteLine(op1.precoComDesconto);

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.precoComDesconto);
        }
    }
}
