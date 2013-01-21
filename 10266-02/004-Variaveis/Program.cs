using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _004_Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar 
            //Tipo nome;

            int x;
            char c;
            double e, pi;

            //atribuir valor
            //nome = conteúdo;

            x = 10;
            c = 'x';
            pi = Math.PI;
            e = Math.E;

            x = x + 2;

            //usar/acessar o conteúdo
            Console.WriteLine(x + pi + e);
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
