using System;
using Encapsulamento;

namespace CursoCSharp.OO
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("Filho Não Reconhecido...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            //Console.WriteLine(NumeroCelular); // Sem acesso
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoFamilia); // Sem acesso
            //Console.WriteLine(UsaMuitoPhotoshop); // Sem acesso
        }
    }

    public class AmigoDistante
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("Amigo Distante...");

            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDoOlho); // Sem acesso
            //Console.WriteLine(amiga.NumeroCelular); // Sem acesso
            //Console.WriteLine(amiga.JeitoDeFalar); // Sem acesso
            //Console.WriteLine(amiga.SegredoFamilia); // Sem acesso
            //Console.WriteLine(amiga.UsaMuitoPhotoshop); // Sem acesso
        }
    }

    class Encapsulamento
    {
        public static void Executar()
        {
            // Forma 1
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            //Forma 2
            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}
