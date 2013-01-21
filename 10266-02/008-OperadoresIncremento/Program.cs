using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _008_OperadoresIncremento
{
    class Program
    {
        static void Main(string[] args)
        {
            //INCREMENTO -> ++
            //DECREMENTO -> --

            int x = 10;

            Console.WriteLine(x++); //x = x + 1 -> 11 (10)
            Console.WriteLine(++x); //x = x + 1 -> 12 (12)
            Console.WriteLine(x--); //x = x + 1 -> 11 (12)
            Console.WriteLine(--x); //x = x + 1 -> 10 (10)

            Console.WriteLine(x); //10

            Console.WriteLine(x += ++x); 

            //x += x + 1
            //x = x + x + 1
            //x = 10 + 10 + 1
            //x = 21

            x = 10;

            Console.WriteLine(x += x++); 

            //x += x 
            //x = x + x
            //x = 10 + 10
            //x = 20

            Console.WriteLine(x); //20

            Console.ReadKey();
        }
    }
}
