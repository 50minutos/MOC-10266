using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Sexo sexo = Sexo.masculino;

            switch (sexo)
            {
                case Sexo.masculino:
                    Console.WriteLine("Hómi");
                    break;
                case Sexo.feminino:
                    Console.WriteLine("Mulé");
                    break;
            }

            Console.WriteLine(Sexo.masculino);
            Console.WriteLine((int)Sexo.masculino);

            Console.ReadKey();
        }
    }

    enum Sexo 
    {
        masculino, feminino
    }
    
    enum EstadoCivil
    {
        solteiro = 10, 
        casado = 100, 
        divorciado = 1000, 
        outros = 0
    }
}
