using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _013_CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = 188;

            Console.WriteLine("R$ 100,00 = {0}", v / 100); v %= 100;
            Console.WriteLine("R$  50,00 = {0}", v / 50); v %= 50;
            Console.WriteLine("R$  20,00 = {0}", v / 20); v %= 20;
            Console.WriteLine("R$  10,00 = {0}", v / 10); v %= 10;
            Console.WriteLine("R$   5,00 = {0}", v / 5); v %= 5;
            Console.WriteLine("R$   2,00 = {0}", v / 2); v %= 2;
            Console.WriteLine("R$   1,00 = {0}", v );

            Console.ReadKey();
        }
    }
}
