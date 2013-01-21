using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace _001_StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            var arquivo = new StreamWriter("arquivo.txt", true, Encoding.UTF8);

            arquivo.WriteLine("linha 1");
            arquivo.WriteLine("linha 2");

            arquivo.Close();

            Process.Start("notepad", "arquivo.txt");
        }
    }
}
