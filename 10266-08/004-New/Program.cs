using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _004_New
{
    class Program
    {
        static void Main(string[] args)
        {
            Ave a = new Ave();
            a.Acordar(); a.Comer(); a.Dormir();

            Galinha g = new Galinha();
            g.Acordar(); g.Comer(); g.Dormir();

            Console.ReadKey();
        }
    }

    class Ave
    {
        public void Acordar() { Console.WriteLine("a ave acordou"); }
        public virtual void Comer() { Console.WriteLine("a ave comeu"); }
        public void Dormir() { Console.WriteLine("a ave dormiu"); }
    }

    class Galinha : Ave
    {
        public override void Comer() { Console.WriteLine("a galinha comeu milho"); }
        public new void Dormir() { Console.WriteLine("a galinha dormiu no poleiro"); }
    }
}
