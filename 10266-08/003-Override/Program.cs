using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _003_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = new Homem();
            h.Comer();

            h = new Mulher();
            h.Comer();

            h = new Crianca();
            h.Comer();

            Console.ReadKey();
        }
    }

    class Homem
    {
        //virtual indica que o método PODE SER sobreposto
        public virtual void Comer() { Console.WriteLine("{0} comeu com a boca aberta e falando", GetType().Name); }
    }

    class Mulher : Homem
    {
        public override void Comer()
        {
            Console.WriteLine("a Mulher comeu");
        } 
    }

    class Crianca : Homem { }
}
