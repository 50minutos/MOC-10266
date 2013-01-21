using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _008_Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t;

            t = new Escaleno(3, 4, 5);
            t = new Equilatero(1);
            t = new Isosceles(2, 1);
        }
    }

    abstract class Triangulo
    {
        int a, b, c;

        public Triangulo(int a, int b, int c)
        {
            this.a = a; this.b = b; this.c = c;
        }
    }

    class Escaleno : Triangulo
    {
        public Escaleno(int a, int b, int c) : base(a, b, c) { }
    }

    class Equilatero : Triangulo
    {
        public Equilatero(int x) : base(x, x, x) { }
    }

    class Isosceles : Triangulo
    {
        public Isosceles(int lado, int _base) : base(lado, lado, _base) {}
    }
}
