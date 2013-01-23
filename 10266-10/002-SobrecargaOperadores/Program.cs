using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_SobrecargaOperadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Terreno t1 = new Terreno(8, 25);
            Terreno t2 = new Terreno(16, 25);

            Console.WriteLine(t1);
            Console.WriteLine(t2);

            Terreno t3 = t1 + t1;
            Console.WriteLine(t3);

            Console.WriteLine(t1 > t2);

            Console.WriteLine(t2 == t3);
            Console.WriteLine(t2.Equals(t3));
            Console.WriteLine(t2.GetHashCode());

            Console.ReadKey();
        }
    }

    //class Terreno no arquivo Terreno.cs
}
