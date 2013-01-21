using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _005_FileFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(File.Exists(@"C:\batatinha.txt"));

            Console.WriteLine(new FileInfo(@"C:\batatinha.txt").Exists);

            Console.ReadKey();
        }
    }
}
