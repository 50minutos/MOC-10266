using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _009_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IDoc
    {
        String Developer { get; set; }
    }

    interface IVoador
    {
        void Voar(); 
    }

    class Passarinho : IVoador, IDoc
    {
        public void Voar() { Console.WriteLine("o passarinho voou"); }

        public string Developer
        {
            get;
            set;
        }
    }

    class Aviao : IVoador
    {
        public void Voar() { Console.WriteLine("o avião voou"); }
    }
}
