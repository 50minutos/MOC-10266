using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //inteiros
            Console.WriteLine("tipo byte -> de {0} até {1}", 
                byte.MinValue, Byte.MaxValue);

            Console.WriteLine("tipo short -> de {0} até {1}",
                short.MinValue, Int16.MaxValue);

            Console.WriteLine("tipo int -> de {0} até {1}",
                int.MinValue, Int32.MaxValue);

            Console.WriteLine("tipo long -> de {0} até {1}",
                long.MinValue, Int64.MaxValue);

            Console.WriteLine();

            //decimais

            Console.WriteLine("tipo decimal -> de {0} até {1}",
                decimal.MinValue, Decimal.MaxValue);

            //ponto flutuante

            Console.WriteLine("tipo float -> de {0} até {1}",
                float.MinValue, Single.MaxValue);

            Console.WriteLine("tipo double -> de {0} até {1}",
                double.MinValue, Double.MaxValue);

            Console.WriteLine();

            //lógicos

            Console.WriteLine("tipo bool -> ou {0} ou {1}",
                bool.TrueString, Boolean.FalseString);

            //date e time

            Console.WriteLine();

            Console.WriteLine("tipo DateTime -> de {0} até {1}",
                DateTime.MinValue, DateTime.MaxValue);

            //string
            
            Console.WriteLine();

            Console.WriteLine("tipo char -> de {0} até {1}",
                char.MinValue, Char.MaxValue);

            Console.ReadKey();
        }
    }
}
