using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    class LINQ2
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno() {Nome = "Carlos", Idade = 24, Nota = 8.0},
                new Aluno() {Nome = "Érica", Idade = 21, Nota = 4.3},
                new Aluno() {Nome = "Marcus", Idade = 25, Nota = 9.5},
                new Aluno() {Nome = "Érica", Idade = 20, Nota = 7.5},
                new Aluno() {Nome = "Mariana", Idade = 21, Nota = 7.7},
                new Aluno() {Nome = "Juliana", Idade = 22, Nota = 7.5},
                new Aluno() {Nome = "Fernanda", Idade = 18, Nota = 6.8}
            };

            var carlos = alunos.Single(aluno => aluno.Nome.Equals("Carlos"));
            Console.WriteLine($"{carlos.Nome} {carlos.Nota}");

            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano"));
            if (fulano == null)
            {
                Console.WriteLine("Aluno inexistente!");
            }

            var erica = alunos.First(aluno => aluno.Nome.Equals("Érica"));
            Console.WriteLine(erica.Nota);

            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nome.Equals("Sicrano"));
            if (sicrano == null)
            {
                Console.WriteLine("Aluno inexistente!");
            }

            var outraErica = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Érica"));
            Console.WriteLine(outraErica.Nota);

            var exemploSkip = alunos.Skip(1).Take(3);
            foreach (var item in exemploSkip)
            {
                Console.WriteLine(item.Nome);
            }

            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);

            var somaNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somaNotas);

            var mediaDaTurma = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine(mediaDaTurma);

            var mediaDosAprovados = alunos.Where(a => a.Nota >= 7).Average(aluno => aluno.Nota);
            Console.WriteLine(mediaDosAprovados);
        }
    }
}
