using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_Destrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                new Objeto();
                
                GC.Collect();
            }
        }
    }

    class Objeto
    {
        public Objeto()
        {
            Console.WriteLine("Objeto()");
        }

        ~Objeto() //Finalize()
        {
            Console.WriteLine("~Objeto()");
        }
    }
}
