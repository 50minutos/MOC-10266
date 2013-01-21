using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _004_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Pessoa() { codigo = 1, nome = "adão" }; //inicializador de objeto 

            Console.WriteLine(p1);

            var p2 = new Pessoa() { codigo = 2, nome = "eva" };

            Pessoa.fumante = true;

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Console.ReadKey();
        }
    }

    class Pessoa
    {
        public int codigo;
        public String nome;
        public static bool fumante;

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}", codigo, nome, fumante);
        }
    }
}
