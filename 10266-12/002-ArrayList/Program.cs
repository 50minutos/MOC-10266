using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace _002_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList nomes = new ArrayList();

            nomes.Add("adão");
            nomes.Add("eva");
            nomes.Add("caim");
            nomes.Add("abel");
            nomes.Add(42);

            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }

            var numeros = new ArrayList { 1, 2, 3, 45 };

            int soma = 0;

            foreach (var item in numeros)
            {
                soma += (int)item;
            }

            Console.WriteLine(soma);

            numeros.Reverse();

            numeros.Sort();

            Console.WriteLine(nomes.Count);
            Console.WriteLine(nomes.Capacity);

            nomes.TrimToSize();
            
            Console.WriteLine(nomes.Capacity);

            Console.ReadKey();
        }
    }
}
