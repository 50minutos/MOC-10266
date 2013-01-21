using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _008_ParametroOpcional
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro l = new Livro();

            Console.WriteLine(l.Codigo);
            Console.WriteLine(l.Titulo);
            Console.WriteLine(l.QtdPaginas);

            Livro o = new Livro(2, "ABC do Truco", 128);

            Console.WriteLine(o.Codigo);
            Console.WriteLine(o.Titulo);
            Console.WriteLine(o.QtdPaginas);

            Livro p = new Livro(t: "Porrinha sem Mestre");

            Console.WriteLine(p.Codigo);
            Console.WriteLine(p.Titulo);
            Console.WriteLine(p.QtdPaginas);

            Console.ReadKey();
        }
    }

    class Livro
    {
        public int Codigo { get; set; }
        public String Titulo { get; set; }
        public int QtdPaginas { get; set; }

        public Livro(int c = 0, String t = "não informado", int q = 0)
        {
            Codigo = c;
            Titulo = t;
            QtdPaginas = q;
        }
    }
}
