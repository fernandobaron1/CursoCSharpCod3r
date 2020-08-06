using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2;

            Console.WriteLine(p1 == p2);
            //False porque seus locais de armazenamento são diferentes.

            Console.WriteLine(p3 == p2);
            //True porque apontam para o mesmo local de armazenamento.

            Console.WriteLine(p1.Equals(p2));
            /*
             * Para que p1 seja igual a p2 você terá
             * que fazem um comando e override na classe
             * ColeçõesList.
             */
        }
    }
}
