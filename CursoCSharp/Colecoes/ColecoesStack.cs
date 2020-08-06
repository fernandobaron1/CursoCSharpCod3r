using System;
//Remover o .Generic
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach (var item in pilha)
            {
                Console.Write($"{item} ");
            }

            //remove o último da fila
            Console.WriteLine($"\nPop: {pilha.Pop()}");

            foreach (var item in pilha)
            {
                Console.Write($"{item} ");
            }

            //seleciona o último da fila mas não remove
            Console.WriteLine($"\nPeek: {pilha.Peek()}");

            foreach (var item in pilha)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\n{pilha.Count}");
        }
    }
}
