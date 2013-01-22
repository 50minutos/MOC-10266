using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _007_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Somar(new int[] { 1, 2, 3, 4 }));
            Console.WriteLine(Somar(new int[] { 10, 20 }));

            Console.ReadKey();
        }

        static int Somar(int[] numeros)
        {
            var soma = 0;

            foreach (var item in numeros)
            {
                soma += item;
            }

            return soma;
        }
    }
}
