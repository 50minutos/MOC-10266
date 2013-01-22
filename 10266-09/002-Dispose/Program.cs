using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_Dispose
{
    class Program
    {
        static void Main(string[] args)
        {
            var o = new Objeto();
            
            o.Dispose();
            o.Dispose();

            o = null;

            Console.ReadKey();
        }
    }

    class Objeto : IDisposable
    {
        public Objeto()
        {
            Console.WriteLine("Objeto()");
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose()");
        }
    }
}
