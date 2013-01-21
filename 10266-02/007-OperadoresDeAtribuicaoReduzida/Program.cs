using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _007_OperadoresDeAtribuicaoReduzida
{
    class Program
    {
        static void Main(string[] args)
        {
            // += -= *= /= %=

            int x = 10;

            Console.WriteLine(x += 1); //x = x + 1 -> 11
            Console.WriteLine(x -= 3); //x = x - 3 -> 8
            Console.WriteLine(x *= 2); //x = x * 2 -> 16
            Console.WriteLine(x /= 4); //x = x / 4 -> 4
            Console.WriteLine(x %= 2); //x = x % 2 -> 0

            Console.WriteLine(x); //0

            Console.ReadKey();
        }
    }
}
