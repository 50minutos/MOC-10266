using System;
using System.Collections.Generic;

using System.Text;
using System.Collections;

namespace _001_IEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 34, 54, 45, 32, 23, 2, 1 };

            IEnumerator e = numeros.GetEnumerator();

            while (e.MoveNext())
            {
                Console.WriteLine(e.Current);
            }

            Console.ReadKey();
        }
    }
}
