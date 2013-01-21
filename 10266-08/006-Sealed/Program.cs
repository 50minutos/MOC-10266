using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _006_Sealed
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Animal
    {
        public virtual void Comer() { Console.WriteLine("comeu"); }
    }

    class Reptil : Animal
    {
        //sealed indica que o método NÃO PODE ser sobreposto
        public sealed override void Comer() { Console.WriteLine("réptil comeu"); }
    }

    //sealed indica que a classe NÃO PODE ser herdada
    sealed class Serpente : Reptil
    { 

    }

    //class Jararaca : Serpente { }
}
