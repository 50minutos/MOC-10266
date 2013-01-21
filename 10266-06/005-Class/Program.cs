using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _005_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p;

            p = new Pessoa();
            
            p.codigo = 1;
            p.nome = "adão";
            p.sexo = 'M';

            Console.WriteLine(p);

            Console.ReadKey();
        }
    }

    class Pessoa
    {
        //campo deveria ser private
        internal int codigo;
        internal String nome;
        internal char sexo;

        public override string ToString()
        {
            return String.Format("{0} -> {1} {2}", codigo, nome, sexo);
        }
    }
}
