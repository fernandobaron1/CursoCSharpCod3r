using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Apresentar()
        {
            
            /*
             * O IfElse foi incrementado neste exercício
             * de acordo com o pedido no final do vídeo.
             * caso contrário só ficaria o conteúdo que 
             * está dentro do Else... mas sem o conteúdo
             * If.
             */
            if ((Nome == null) && (Idade <= 0))
            {
                return string.Format($"Os dados não foram preenchidos corretamente");

            }
            else
            {
                return string.Format(
                $"Olá!! Me chamo {Nome} e tenho {Idade} anos.");

            }
            

        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }

        public void Zerar()
        {
            Nome = "";
            Idade = 0;
        }
    }
}
