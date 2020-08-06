using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    //Classe selada não poder ter herança.
    sealed class SemFilho
    {
        public double ValorFortuna()
        {
            return 1_407_033.65;
        }
    }

    // SouFilho não poder herdar de SemFilho
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
        //Método selado não pode ser subescrito.
        //Metodo pode ficar escondido mas subescrito não.
        public sealed override bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    class FilhoRebelde : Pai
    {
        //public override bool HonrarNomeFamilia()
        //{
        //    return false;
        //}
    }
    class Sealed
    {
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }
    }
}
