using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Cliente
    {
        public string Nome;
        readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;

            //Nascimento = new DateTime(2020, 07, 15);
        }

        public string GetDataNascimento()
        {
            return String.Format("{0}/{1}/{2}", Nascimento.Day,
                Nascimento.Month, Nascimento.Year);
        }


    }
    class Readonly
    {
        public static void Executar()
        {
            var novoCliente = new Cliente("Ana Silva",
                new DateTime(1987, 5, 22));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataNascimento());

            /*
             * O "readonly" é usado antes de um atributo (neste caso
             * foi utlizado o atributo DateTime como exemplo) para
             * que uma vez setado só pode ser usado como leitura,
             * não podendo mais ser modificado. Existe uma excessão,
             * dentro do construtor ele pode ser modificado.
             */


            //novoCliente.Nascimento = new DateTime(2020, 07, 15);
            //Console.WriteLine(novoCliente.GetDataNascimento());


        }
    }
}
