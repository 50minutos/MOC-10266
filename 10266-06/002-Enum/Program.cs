using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Season.Autumn;

            Console.WriteLine(s == Season.Fall);

            Console.ReadKey();
        }
    }

    enum Season
    {
        Summer,
        Winter,
        Autumn,
        Spring,
        Fall = Autumn
    }
}
