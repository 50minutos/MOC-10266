using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _004_Output
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado;

            Somar(10, 20, out resultado);

            Console.WriteLine(resultado);

            int menor, maior;

            Calcular(10, 23, -3, 
                out menor, out maior);

            Console.WriteLine(menor);
            Console.WriteLine(maior);

            Console.ReadKey();
        }

        static void Somar(int x, int y, out int z) 
        {
            z = x + y; 
        }

        static void Calcular(int x, int y, int z,
            out int menor, out int maior)
        { 
            //operador ternário
            //condição ? true : false

            menor = x < y ? x : y;
            menor = menor < z ? menor : z;

            maior = x > y ? x : y;
            maior = maior > z ? maior : z;
        }
    }
}
