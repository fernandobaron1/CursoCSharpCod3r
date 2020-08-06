using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            // conversão implícita
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            // conversão explícita
            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            //Convertendo String para Inteiro
            Console.Write("Digite dua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("idade inserida: {0}", idadeInteiro);

            // Outra forma de conversão
            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            /* Dessa maneira caso você digitar algo que não
             * seja um valor int, uma letra por exemplo, não
             * irá dar erro e sim apresentará o valor "0"
             */
            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine("Reseultado 1: {0}", numero1);

            // Uma maneira mais otimizada
            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2: {0}", numero2); ;

        }
    }
}
