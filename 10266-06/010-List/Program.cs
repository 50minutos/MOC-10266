using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _010_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> nomes = new List<String>()
            {
                "ADÃO", 
                "EVA", 
                "CAIM", 
                "ABEL"
            };

            nomes.Add("AGNALDO");
            nomes.Remove("ABEL");

            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            ArrayList maisNomes = new ArrayList()
            {
                "adão", 
                "eva", 
                "caim", 
                "abel", 
                new Random(), 
                10,
                (Object)190
            };

            foreach (var item in maisNomes)
            {
                Console.WriteLine(item.GetType().Name);
            }

            Console.ReadKey();
        }
    }
}
