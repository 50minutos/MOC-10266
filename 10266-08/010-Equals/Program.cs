using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _010_Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 10;

            Console.WriteLine(x == y);

            String a = "abc", b = "abc";

            //Console.WriteLine(a == b); 
            //não recomendado para REFERENCE TYPES
            
            Console.WriteLine(a.Equals(b));

            Pessoa p1 = new Pessoa { Codigo = 1, Nome = "ADÃO" };
            Pessoa p2 = new Pessoa { Codigo = 1, Nome = "ADÃO" };

            Console.WriteLine(p1.Equals(p2));

            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());

            Console.ReadKey();
        }
    }

    //hashcode - representação numérica do objeto
    //se dois hashcodes são diferentes, então os objetos são diferentes

    class Pessoa
    {
        public int Codigo { get; set; }
        public String Nome { get; set; }

        public override bool Equals(object obj)
        {
            Pessoa p = (Pessoa)obj;

            return Codigo == p.Codigo && Nome.Equals(p.Nome);
        }

        public override int GetHashCode()
        {
            return Codigo + Nome.GetHashCode();
        }
    }
}
