using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _017_For
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++) //sempre "zera" a variável
            {
                Console.WriteLine("primeiro: {0}", i);
            }

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("segundo: {0}", i);
            }

            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0} x {1} = {2}\t", i, j, i * j);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
