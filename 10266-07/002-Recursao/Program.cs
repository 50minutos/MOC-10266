using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_Recursao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Somatorio(100));
            Console.WriteLine(SomatorioRec(100));

            //short -32768 a 32767

            //short s = 32767;

            //checked
            //{
            //    Console.WriteLine(s += 10);
            //}

            Console.ReadKey();
        }

        //iterativo
        static int Somatorio(int x)
        {
            int retorno = 0;

            for (int i = 1; i <= x; i++)
            {
                retorno += i;
            }

            return retorno;
        }

        //recursivo
        static int SomatorioRec(int x)
        {
            return x == 1 ? 1 : x + SomatorioRec(x - 1); 
        }
    }
}
