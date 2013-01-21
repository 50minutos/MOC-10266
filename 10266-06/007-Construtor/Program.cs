using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _007_Construtor
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

            Console.ReadKey();
        }
    }

    class Livro
    {
        public int Codigo { get; set; }
        public String Titulo { get; set; }
        public int QtdPaginas { get; set; }

        //sobrecarga (overload)

        public Livro(int c, String t, int q)
        {
            Codigo = c;
            Titulo = t;
            QtdPaginas = q;
        }

        public Livro()
        {

        }
    }
}
