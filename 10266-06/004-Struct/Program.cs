using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _004_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            //CTRL+R, CTRL+R -> RENAME 

            Fracao x;

            x.numerador = 3;
            x.denominador = 4;

            Console.WriteLine(x);

            Fracao y;

            y.numerador = 4;
            y.denominador = 3;

            Console.WriteLine(y);

            Console.ReadKey();
        }
    }

    //internal indica que o tipo pode ser "visto" por outros tipos que estão no mesmo assembly
    /*internal*/ struct Fracao
    {
        //private indica que o membro do tipo (campo) só pode ser "visto" dentro do próprio tipo 
        /*private*/ internal int numerador;
        /*private*/ internal int denominador;

        //override indica sobreposição de método
        public override string ToString()
        {
            return String.Format("{0}/{1}", numerador, denominador);
        }
    }
}
