using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome; // Valor padrão 'null'
        public int Idade; // Valor padrão '0'

        public string Apresentar()
        {
            return string.Format($"Olá, me chamo {Nome} e tenho {Idade} anos."); // 'Format' vai formatar a mensagem
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }

        public void Zerar()
        {
            Nome = "";
            Idade = 0;
        }
    }
}
