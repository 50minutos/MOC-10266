using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_FazNada
{
    class Program
    {
        static void Main(string[] args)
        {
            FazerNada();
            FazerNada();
            FazerNada();

            Console.ReadKey();
        }
    
        //modificadores -> static, private, ...
        //retorno -> void, int, String, Pessoa, ...
        //nome 
        //argumentos 
        //corpo -> implementação

        static void FazerNada() { Console.WriteLine("oi"); }
    }
}
