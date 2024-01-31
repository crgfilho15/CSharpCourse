using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Dependente
    {
        public string Nome;
        public int Idade;
    }

    class ValorVsReferencia
    {
        public static void Executar()
        {
            // O tipo 'int' é uma 'struct', logo, passagem por valor
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");

            numero++; // Alterando o 'numero', não altera o 'copiaNumero' e vice-versa
            Console.WriteLine($"{numero} {copiaNumero}");

            // Classe => passagem por referência
            Dependente dep = new Dependente
            {
                Nome = "Beto",
                Idade = 20
            };

            Dependente copiaDep = dep;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

            copiaDep.Nome = "Renato"; // Alterando na 'CopiaDep', altero no 'dep' também
            dep.Idade = 21; // Alterando no 'dep', altero no 'CopiaDep' também

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");
        }
    }
}
