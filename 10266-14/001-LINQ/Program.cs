using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var lema = "ORDEM E PROGRESSO";

            var letras = from x in lema 
                         select x;

            var deNovo = lema.Select(x => x);

            Console.WriteLine(letras);

            foreach (var item in letras)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            Console.WriteLine();
            
            Console.WriteLine(deNovo);

            foreach (var item in deNovo)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
