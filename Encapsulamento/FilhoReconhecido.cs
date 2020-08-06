﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    class FilhoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("Filho Reconhecido...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);

            //Porque é privada da class SubCelebridade
            //Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
