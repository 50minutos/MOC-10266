using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _009_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Fracao<int> fi = new Fracao<int>(3, 4);
            Fracao<byte> fb = new Fracao<byte>(10, 13);

            Console.WriteLine(fi);
            Console.WriteLine(fb);

            Console.ReadKey();
        }
    }

    struct Fracao<T>
    {
        public T N { get; set; }
        public T D { get; set; }

        public Fracao(T n, T d) : this()
        {
            N = n;
            D = d;
        }

        public override String ToString() { return String.Format("{0}/{1}", N, D); }
    }
}
