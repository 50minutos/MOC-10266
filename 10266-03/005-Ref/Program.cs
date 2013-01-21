using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _005_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            
            Swap(ref a, ref b);
            
            Console.WriteLine(a);
            Console.WriteLine(b);

            Dobrar(ref b);

            Console.WriteLine(b);

            Console.ReadKey();
        }

        static void Dobrar(ref int x)
        {
            x *= 2;
        }

        static void Swap(ref int x, ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }
    }
}
