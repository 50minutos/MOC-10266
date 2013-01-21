using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _016_Do
{
    class Program
    {
        static void Main(string[] args)
        {
            //variáveis tipadas implicitamente
            var x = 1; //int x = 1;
            var b = false; //bool b = false;
            var s = "agnaldo"; //String s = "agnaldo";

            do
            {
                Console.WriteLine("primeiro {0}", x++);
            } while (x <= 5);
            
            do
            {
                Console.WriteLine("segundo {0}", x++);
            } while (x <= 5);

            Console.ReadKey();
        }
    }
}
