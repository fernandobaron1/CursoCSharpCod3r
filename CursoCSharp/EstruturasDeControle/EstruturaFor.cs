using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {
            /*
            int i = 1;

            while (i <= 10)
            {   
                Console.WriteLine($"O valor de i é {i}.");
                i += 2; // de dois em dois
                //i++; de 1 em 1
            }
            */

            /*
            for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"Ovalor de i é {i}.");
                }
            */
            double somatorio = 0;
            string entrada;

            Console.Write("Informe o tamanho da turma: " );
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++) 
            {
                Console.WriteLine("Informe a nota do aluno {0}:", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }
            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("Media da turma: {0}", media);



        }
    }
}
