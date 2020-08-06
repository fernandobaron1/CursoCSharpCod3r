using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class UsandoBreak
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("O número que queremos é {0}.", numero);

            for (int i = 1; i <= 50; i++)
            {
                Console.Write("{0} é o numero que queremos? ", i);
                if (i == numero)
                {
                    Console.WriteLine("Sim!");

                    /*
                     * O Break geralmente é usado para sair de uma swich
                     * ou de um For. Neste caso Mesmo sendo colocado 
                     * após um If o comando Break sairá da repetição For.
                     * Não colocando o Break o For executaria até o final. 
                     * Colocando o Break irá terminar a execução quando 
                     * encontrar o número desejado.
                     */
                    break;
                } else
                {
                    Console.WriteLine("Não!");
                }
            }

            Console.WriteLine("Fim!");
        }
    }
}
