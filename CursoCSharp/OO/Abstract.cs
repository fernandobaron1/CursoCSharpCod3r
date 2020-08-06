using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    /*
     * O conceito de classe abstrata é que ela pode
     * ou não estar acabada. Por este motivo ela não 
     * pode ser instanciada.
     */
    public abstract class Celular
    {
        public abstract string Assistente();

        public string Tocar()
        {
            return "Trim trim trim...";
        }
    }

    public class Samsung : Celular
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é Bixby!";
        }
    }

    public class Iphone : Celular
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é Siri!";
        }
    }

   
    class Abstract
    {
        public static void Executar()
        {
            var celulares = new List<Celular>
            {
                new Iphone(),
                new Samsung()
            };

            foreach (var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }

        }
    }
}
