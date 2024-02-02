using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            } else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            } else
            {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        public virtual int Acelerar() // Usar o modificador 'virtual' permite que o método seja sobreescrito
        {
            return AlterarVelocidade(5);
        }

        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro
    {
        public Uno() : base(200) // A Classe pai não tem um construtor padrão (vazio), logo, sou obrigado a chamar o construtor base aqui
        {
        }
    }

    public class Ferrari : Carro
    {
        public Ferrari() : base(350)
        {
        }

        // Sobreescrevendo um método da classe pai que possui o modificador 'virtual'
        // Ao fazer um polimorfismo dinâmico [Tipo mais genérico (carro) recebe um tipo mais específico (Ferrari) ao instânciar o objeto], ele chamará o método sobreescrito
        public override int Acelerar()
        {
            return AlterarVelocidade(15);
        }

        // Sobreescrevendo um método da classe pai, porém ocultando-o dela. Dessa forma não precisa que o modificador 'virtual' seja utilizado no método da classe pai
        // Porém, ao fazer um polimorfismo dinâmico [Tipo mais genérico (carro) recebe um tipo mais específico (Ferrari) ao instanciar o objeto], ele não chamará o método sobreescrito
        public new int Frear()
        {
            return AlterarVelocidade(-15);
        }
    }

    class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrai com tipo Carro...");
            Carro carro3 = new Ferrari(); // Polimorfismo dinâmico: Tipo mais genérico (carro) recebe um tipo mais específico (Ferrari)
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Uno com tipo Carro...");
            Carro carro4 = new Uno(); // Polimorfismo dinâmico
            Console.WriteLine(carro4.Acelerar());
            Console.WriteLine(carro4.Acelerar());
            Console.WriteLine(carro4.Frear());
            Console.WriteLine(carro4.Frear());
            Console.WriteLine(carro4.Frear());
        }
    }
}
