﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _006_OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            // + - * / %

            int x = 10, y = 3;

            Console.WriteLine(x + y); //13
            Console.WriteLine(x - y); //7
            Console.WriteLine(x * y); //30
            Console.WriteLine(x / y); //3
            Console.WriteLine(x % y); //1

            Console.ReadKey();
        }
    }
}
