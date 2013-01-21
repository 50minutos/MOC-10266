using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_SobrecargaDeMetodo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Somadora.Somar(10, 20));
            Console.WriteLine(Somadora.Somar(10, 20, 30));
            Console.WriteLine(Somadora.Somar(1.1, 2.2));
            Console.WriteLine(Somadora.Somar(1.1f, 2.2f));
            Console.WriteLine(Somadora.Somar(1, 2.2f));

            Console.ReadKey();
        }
    }

    class Somadora
    {
        //assinatura: Somar(int, int)
        public static int Somar(int x, int y) { return x + y; }

        //Somar(int, int)
        //public int Somar(int a, int b) { return a + b; }
        
        //Somar(int, int, int)
        public static int Somar(int x, int y, int z) { return x + y + z; }

        //Somar(double, double)
        public static double Somar(double x, double y) { return x + y; }
    }
}

