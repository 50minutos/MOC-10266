using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _005_Calculadoras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculadora1.Somar(10, 20));
            Console.WriteLine(Calculadora1.Subtrair(10, 20));

            var c = new Calculadora2 { X = 10, Y = 20 };
            
            Console.WriteLine(c.Somar());
            Console.WriteLine(c.Subtrair());

            Console.WriteLine(Math.Sqrt(100));
            Console.WriteLine((10).ToString());
            
            Console.ReadKey();
        }
    }

    class Calculadora1
    {
        public static int Somar(int x, int y) { return x + y; }
        public static int Subtrair(int x, int y) { return x - y; }
    }

    class Calculadora2
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int Somar() { return X + Y; }
        public int Subtrair() { return X - Y; }
    }
}
