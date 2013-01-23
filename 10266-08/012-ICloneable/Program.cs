using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _012_ICloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.Codigo = 1;
            p1.Nome = "adão";

            Pessoa p2 = p1;
            Pessoa p3 = p1.Clone() as Pessoa;

            p3.Nome = "eva";

            Console.WriteLine(p1.Nome);
            Console.WriteLine(p2.Nome);
            Console.WriteLine(p3.Nome);

            Console.ReadKey();
        }
    }

    class Pessoa : ICloneable
    {
        public int Codigo { get; set; }
        public String Nome { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
