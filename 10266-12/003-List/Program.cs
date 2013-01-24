using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _003_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> nomes = new List<String>();

            nomes.Add("adão");
            nomes.Add("eva");
            nomes.Add("caim");
            nomes.Add("abel");
            //nomes.Add(42);

            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }

            var numeros = new List<int> { 1, 2, 3, 45 };

            int soma = 0;

            foreach (var item in numeros)
            {
                soma += item;
            }

            Console.WriteLine(soma);

            numeros.Reverse();

            numeros.Sort();

            Console.WriteLine(nomes.Count);
            Console.WriteLine(nomes.Capacity);

            nomes.TrimExcess();

            Console.WriteLine(nomes.Capacity);

            Console.ReadKey();
        }
    }
}
