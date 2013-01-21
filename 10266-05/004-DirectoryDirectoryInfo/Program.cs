using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _004_DirectoryDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string verbatim -> string que não contém caracteres de escape
            // \n -> enter 
            // \t -> tab
            // \\ -> \
            // \" -> "

//            var s1 = "linha 1\n\"linha 2";
//            Console.WriteLine(s1);

//            var s2 = @"linha 3
//""linha 4";
//            Console.WriteLine(s2);

            DirectoryInfo di = new DirectoryInfo(@"C:\Windows");

            foreach (var item in di.GetFiles())
            {
                Console.WriteLine(item.FullName);
            }

            Console.WriteLine();

            foreach (var item in Directory.GetFiles(@"C:\Windows"))
            {
                Console.WriteLine(item);
            }
       
            Console.ReadKey();
        }
    }
}
