using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_Lambda
{
    class Program
    {
        static bool Par(int x) { return x % 2 == 0; }

        static Func<int, bool> Impar = x => x % 2 == 0;

        static int Somar(int x, int y) { return x + y; }

        static Func<int, int, int> SomarInt = (x, y) => x + y;

        static void Main(string[] args)
        {
            //entrada => processamento
            // x => x*2

            Console.WriteLine(Impar(11));

            Console.WriteLine(SomarInt(10,20));
            
            var s = "c# é bico!";

            //sem LINQ (Language Integrated Query)
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }

            //com LINQ
            var colecaoLetras = from c in s
                                select c;

            //com LINQ e Lambda
            var letras = s.Select(c => c.ToString().ToUpper());

            foreach (var item in letras)
            {
                Console.WriteLine(item);
            }



            Console.ReadKey();
        }
    }
}
