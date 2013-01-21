using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace _006_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            String eu = "agnaldo";

            Console.WriteLine(eu.Reverter());

            Console.ReadKey();

        }
    }

    static class StringExtension
    {
        public static String Reverter(this String s)
        {
            return new String(s.Reverse().ToArray<char>());
        }
    }
}
