using System;
using System.Collections.Generic;
using System.Text;

// Classe Sealed não permite herança.
// Método Sealed não permite sobreescrita.
// Só é possível sobreescrever um método sealed ocultando-o com 'new'.

namespace CursoCSharp.OO
{
    sealed class SemFilho
    {
        public double ValorDaFortuna()
        {
            return 1_407_033.65;
        }
    }

    // Classe Sealed não permite herança

    //class SouFilho : SemFilho
    //{
    //}

    class Avo
    {
        public virtual bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    class Pai : Avo
    {
        public sealed override bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    class FilhoRebelde : Pai
    {
        // Não é possível sobreescrever um método sealed

        //public override bool HonrarNomeFamilia()
        //{
        //    return false;
        //}

        // Só é possível sobreescrever um método sealed ocultando-o com 'new'

        //public new bool HonrarNomeFamilia()
        //{
        //    return false;
        //}
    }

    class Sealed
    {
        public static void Executar()
        {
            SemFilho semfilho = new SemFilho();
            Console.WriteLine(semfilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }
    }
}
