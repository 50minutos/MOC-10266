using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _005_Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            //atribuição múltipla

            int x, y, z;

            x = y = z = 10;

            Console.WriteLine(x);

            byte b;
            short s;
            int i;
            long l;

            //b = s = i = l = 10;

            l = i = s = b = 10;

            Console.ReadKey();
        }
    }
}
