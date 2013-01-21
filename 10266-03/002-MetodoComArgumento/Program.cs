using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_MetodoComArgumento
{
    class Program
    {
        static void Main(string[] args)
        {
            Imprimir("oi");
            Imprimir("opa");
            Imprimir("tá ligado na qualéquié?");
            
            Somar(2, 3);

            Console.ReadKey();
        }

        static void Imprimir(String msg) { Console.WriteLine(msg); }

        static void Somar(int x, int y) { Console.WriteLine(x+y); }
    }
}
