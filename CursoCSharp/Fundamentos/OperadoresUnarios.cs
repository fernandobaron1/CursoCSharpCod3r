using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!booleano);

            numero1++;
            Console.WriteLine(numero1);

            --numero1;
            Console.WriteLine(numero1);

            /*
             * No exemplo abaixo a variável numero2
             * diminui 1 antes da comparação, enquanto
             * a variável numero1 acrescenta 1 depois da
             * comparação. Por este motivo a comparação
             * será verdadeira, embora o valor numero1
             * será 3 e valor numero2 será 2. Neste 
             * exemplo podemos ver o quanto é nescessário
             * um codigo limpo e boas práticas.
             */
            Console.WriteLine(numero1++ == --numero2);
            Console.WriteLine($"{numero1} {numero2} ");

        }
    }
}
