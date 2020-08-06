using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    class AmigoProximo
    {
        //Chamando a classe
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("Amigo Próximo...");

            Console.WriteLine(amiga.InfoPublica);

            // Só pode ser transmitido por herança
            //Console.WriteLine(amiga.CorDoOlho);

            Console.WriteLine(amiga.NumeroCelular);
            Console.WriteLine(amiga.JeitoDeFalar);

            //Não tem herança e nem da mesma classe.
            //Console.WriteLine(amiga.SegredoFamilia);

            //Somente pode ser usado na classe SubCelebridade.
            //Console.WriteLine(amiga.UsaMuitoPhotoshop);
            
        }
    }
}
