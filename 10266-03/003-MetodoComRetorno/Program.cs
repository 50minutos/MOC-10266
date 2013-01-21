using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _003_MetodoComRetorno
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20, c;

            c = Somar(a, b);

            Console.WriteLine(c);

            Console.WriteLine(Somar(10, 40));

            Console.ReadKey();
        }

        static int Somar(int x, int y) 
        {
            return x + y; 
        }
    }
}
