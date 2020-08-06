using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    // class ou struct... substitua por "struct" e veja a diferença.
    public class Dependente
    {   //(ctrl + ponteiro do mouse - string) string é uma classe por isso se trata de REFERÊNCIA.
        public string Nome;
        //(ctrl + ponteiro do mouse - int) int é um struct por isso se trata dos VALORES.
        public int Idade;
    }
    class ValorVsReferencia
    {
        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");

            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");

            Dependente dep = new Dependente
            {
                Nome = "Beto",
                Idade = 20
            };

            Dependente copiaDep = dep;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

            copiaDep.Nome = "Renato";
            dep.Idade = 21;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");
        }
    }
}
