using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _004_HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<String> nomes = new HashSet<String>();
            
            nomes.Add("Enio");
            nomes.Add("Beto");
            nomes.Add("Beto");
            nomes.Add("Beto");
            nomes.Add("Beto");
            nomes.Add("Garibaldo");

            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
