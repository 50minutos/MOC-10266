using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _018_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(x);
                Console.WriteLine(i);
            }

            //Console.WriteLine(i); 

            {
                //int x = 100;
                int z = 1;
                Console.WriteLine(z);
            }

            {
                //int x = 100;
                int z = 10;
                Console.WriteLine(z);
            }
        }
    }
}
