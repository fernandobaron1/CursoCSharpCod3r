using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamentos
{
    public class SubCelebridade
    {
        // Todos
        public string InfoPublica = "Tenho um instagram!";

        // Heranca
        protected string CorDoOlho = "Verde";

        // mesmo projeto (assembly)
        internal ulong NumeroCelular = 5547999999999;

        // herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        // mesma class ou herança no mesmo projeto (C# >= 7.2)
        private protected string SegredoFamilia = "Bla bla";

        // private é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCellebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
