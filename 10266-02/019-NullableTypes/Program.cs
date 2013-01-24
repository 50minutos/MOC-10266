using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _019_NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int? inteiroAnulavel = 10;

            int inteiro = inteiroAnulavel.HasValue ? inteiroAnulavel.Value : 0;

            Console.WriteLine(inteiroAnulavel);
            Console.WriteLine(inteiro);

            Console.WriteLine();

            int? outroInteiro = null;
            inteiro = outroInteiro.HasValue ? outroInteiro.Value : 0;

            Console.WriteLine(outroInteiro);
            Console.WriteLine(inteiro);

            Console.ReadKey();
        }
    }
}
