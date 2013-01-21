using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            var batman = new Morcego();

            batman.Nome = "Bruce Wayne";

            Console.WriteLine(batman.Nome);

            batman.Acordar();
            batman.Comer();
            batman.BeberSangue();
            batman.Mamar();
            batman.Dormir();

            Console.ReadKey();
        }
    }

    class Animal //herda de Object
    {
        public String Nome { get; set; }

        public void Acordar() { Console.WriteLine("o Animal acordou"); }
        public void Comer() { Console.WriteLine("o Animal comeu"); }
        public void Dormir() { Console.WriteLine("o Animal dormiu"); }
    }

    class Mamifero : Animal //Mamifero herda de Animal
    {
        public void Mamar() { Console.WriteLine("o Mamifero mamou"); }
    }

    class Morcego : Mamifero 
    {
        public void BeberSangue() { Console.WriteLine("o Morcego bebeu sangue"); }
    }

    class Baleia : Mamifero
    {
        public void Nadar() { Console.WriteLine("a Baleia nadou"); }
    }
}
