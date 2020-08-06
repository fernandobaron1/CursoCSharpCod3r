using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            //O comando Enqueue serve para adicionar a fila. 
            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");

            // O comando Peek pega o primeiro da fila mas não apaga. 
            Console.WriteLine(fila.Peek());

            // O comando Count faz a contagem de quantos itens tem na fila.
            Console.WriteLine(fila.Count);

            //O comando Dequeue seleciona e apaga o primeiro da fila.
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            /* Para fazer funcionar o Queue abaixo
             * deve-se importar: using System.Collections; 
             * OBS: O Queue(fila) aceita repetição.
             */
            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item"));
            Console.WriteLine(salada.Contains("Item"));
            Console.WriteLine(salada.Contains(3));
            Console.WriteLine(salada.Contains(4));
            Console.WriteLine(salada.Contains(3.14));
            Console.WriteLine(salada.Contains(3.15));




        }
    }
}
