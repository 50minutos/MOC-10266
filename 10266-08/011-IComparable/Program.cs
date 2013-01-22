using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _011_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inteiros = { 1, 2, 4, 3, 5, -9, 10, 0 };

            Array.Sort(inteiros);

            foreach (var item in inteiros)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            String[] nomes = { "ADÃO", "EVA", "CAIM", "ABEL" };

            Array.Sort(nomes);

            foreach (var item in nomes)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            Pessoa[] pessoas = { new Pessoa("ADÃO"), new Pessoa("EVA"), new Pessoa("CAIM"), new Pessoa("ABEL") };

            Array.Sort(pessoas);

            foreach (var item in pessoas)
            {
                Console.Write("{0} ", item);    
            }

            Console.ReadKey();
        }
    }

    class Pessoa : IComparable<Pessoa>
    {
        public String Nome { get; set; }
        public Pessoa(String nome) { Nome = nome; }
        public override string ToString(){ return Nome; }

        public int CompareTo(Pessoa other) { return Nome.CompareTo(other.Nome); }
    }
}
