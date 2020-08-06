using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        //public Carro() { }

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;
        
             if (novaVelocidade < 0) {
                VelocidadeAtual = 0;
            } else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            } else
            {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        //Para poder subscrever o método usa-se: "Virtual". 
        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);
        }

        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro
    {
        /*
         * Com a ausência do construtor padrão
         *tem-se a nescessidade de se fazer o
         *construtor base. 
         */

            //Abaixo temos um construtor base.
         public Uno() : base(200)
        {

        }
    }

    public class Ferrari : Carro
    {
        public Ferrari() : base(350)
        {

        }

        public override int Acelerar()
        {
            return AlterarVelocidade(15);
            /*
             * Para alterar o método deve-se se
             * usar "virtual"  no método pai.
             */
        }

        
        //Oculta-se o método pai. Diferente de Subscrever.
        public new int Frear()
        {
            return AlterarVelocidade(-15);
        }

    }
    class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();

            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrari com tipo carro...");
            Carro carro3 = new Ferrari();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Uno com tipo Carro...");
            carro3 = new Uno(); //Exemplo de Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}
