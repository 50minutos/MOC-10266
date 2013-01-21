using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _006_Optional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Somar(1, 2));
            Console.WriteLine(Somar(1, 2, 3));

            Console.ReadKey();
        }

        static int Somar(int x, int y, int z = 0)
        {
            return x + y + z;
        }

        static int Multiplicar(int x, int y, int z = 1)
        {
            return x * y * z;
        }
    }
}
