using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_Figura
{
    class Program
    {
        static void Main(string[] args)
        {
            //Figura f;
            //f = new Figura();

            var e = new Equilatero() { X = 1 };
            Console.WriteLine(e);

            var q = new Quadrado() { X = 1 };
            Console.WriteLine(q);

            var c = new Circulo() { X = 1 };
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }

    //abstract indica que a classe possui métodos abstract
    //abstract indica que a classe NÃO PODE SER instanciada
    abstract class Figura
    {
        public double X { get; set; }

        //abstract indica que o método NÃO TEM implementação
        //abstract indica que o método DEVE SER sobreposto
        public abstract double CalcularPerimetro();
        public abstract double CalcularArea();

        public override string ToString()
        {
            return String.Format("Tipo: {0}\n\tmedida: {1}\n\tPerímetro: {2}\n\tÁrea: {3}", GetType().Name, X, CalcularPerimetro(), CalcularArea());
        }
    }

    class Equilatero : Figura
    {
        public override double CalcularPerimetro()
        {
            return 3 * X;
        }

        public override double CalcularArea()
        {
            var sp = CalcularPerimetro()/2;
            return Math.Sqrt(sp * (sp - X) * (sp - X) * (sp - X));
        }
    }

    class Quadrado : Figura
    {
        public override double CalcularPerimetro()
        {
            return 4 * X;
        }

        public override double CalcularArea()
        {
            return Math.Pow(X, 2);
        }
    }

    class Circulo : Figura
    {
        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * X;
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(X, 2);
        }
    }
}
