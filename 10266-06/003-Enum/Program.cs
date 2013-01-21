using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _003_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = Combustivel.gasolina;
            Console.WriteLine(c);

            var f = Combustivel.gasolina | Combustivel.álcool | Combustivel.gás;

            Console.WriteLine((f & Combustivel.gasolina) == Combustivel.gasolina);
            Console.WriteLine((f & Combustivel.álcool) == Combustivel.álcool);
            Console.WriteLine((f & Combustivel.gás) == Combustivel.gás);
            Console.WriteLine((f & Combustivel.diesel) == Combustivel.diesel);

            Console.ReadKey();
        }
    }

    enum Combustivel
    { 
        gasolina = 0x1, 
        álcool = 0x2, 
        diesel = 0x4, 
        gás = 0x8
    }
}
