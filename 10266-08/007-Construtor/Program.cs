using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _007_Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Derivada();

            Console.ReadKey();

            //sempre a construção do objeto é "de cima para baixo"
            //Object -> Base -> Derivada
        }
    }

    class Base
    {
        public Base() { Console.WriteLine("Base()"); }
    }

    class Derivada : Base
    {
        public Derivada() { Console.WriteLine("Derivada()"); }
    }
}
