using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _008_GenericType
{
    class Program
    {
        static void Main(string[] args)
        {
            var p2d = new Ponto<int> { X = 10, Y = 5 };
            var p3d = new Ponto3D<double> { X = 10.25, Y = 5.5, Z=12.5 };

            Console.WriteLine(p2d);
            Console.WriteLine(p3d);

            Console.ReadKey();
        }
    }

    class Ponto<T>
    {
        public T X { get; set; }
        public T Y { get; set; }

        public override string ToString()
        {
            return String.Format("x = {0}, y = {1}", X, Y);
        }
    }

    class Ponto3D<T> : Ponto<T>
    {
        public T Z { get; set; }

        public override string ToString()
        {
            return String.Format("{0}, z = {1}", base.ToString(), Z);
        }
    }
}
