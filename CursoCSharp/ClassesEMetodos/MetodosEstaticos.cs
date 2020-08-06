using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    /* Em outras palavras quanto a palavra "static"
     * é acrescentada ao método, o método não pertence 
     * mais ao objeto, e sim, a classe.
     */
    public class CalculadoraEstatica
    {
        //Método de Classe ou Método Estático!!!
        public static int SomarEx1(int a, int b)
        {
            return a + b;
        }

        //Método de Instância(Objeto)!!!
        public int SomarEx2(int a, int b)
        {
            return a + b;
        }

        //Método de Classe ou Método Estático!!!
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }
    class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            Console.WriteLine(CalculadoraEstatica.SomarEx1(2,2));

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.SomarEx2(2,2));

        }
    }
}
