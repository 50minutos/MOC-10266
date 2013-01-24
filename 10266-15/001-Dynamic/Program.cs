using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            //erro de compilação:
            //x = "abc"; 

            var y = "abc"; //no assembly está String y = "abc";
            //erro de compilação:
            //y = 10;

            dynamic z = "abc";
            Console.WriteLine(z);
            z = 10;
            Console.WriteLine(z);
            //erro de execução:
            Console.WriteLine(z.CalcularArea()); 

            Console.ReadKey();
        }
    }
}
