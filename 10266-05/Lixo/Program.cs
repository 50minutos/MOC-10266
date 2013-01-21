using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lixo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculadora.Multiplicar(12, 32));
            Console.WriteLine(Calculadora.Dividir(120, 32));
            Console.WriteLine();

            var c = new Calculadora();
            Console.WriteLine(c.Somar(1, 2));
            Console.WriteLine(c.Subtrair(1, 2));

            Console.ReadKey();
        }
    }

    class Calculadora
    {
        public int Somar(int x, int y) { return x + y; }
        public int Subtrair(int x, int y) { return x - y; }
   
        public static int Multiplicar(int x, int y) { return x * y; }        
        public static int Dividir(int x, int y) { return x / y; }
    }
}
