using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _003_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 1, 2, 34, 54, 76, 234, 213, 1, -12 };

            var ordenado = from x in numeros
                           orderby x
                           select x;

            var deNovo = numeros.OrderBy(x => x);

            Console.WriteLine(ordenado);

            foreach (var item in ordenado)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(deNovo);

            foreach (var item in deNovo)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
