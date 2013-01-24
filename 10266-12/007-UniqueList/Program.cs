using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _007_UniqueList
{
    class Program
    {
        static void Main(string[] args)
        {
            var nomes = new UniqueList<String>();

            nomes.Add("adão");
            nomes.Add("adão");
            nomes.Add("eva");
            nomes.Add("adão");

            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }

    class UniqueList<T> : List<T> 
    {
        public new void Add(T item) 
        {
            if (this.IndexOf(item) == -1)
                base.Add(item);
        }
    }
}
