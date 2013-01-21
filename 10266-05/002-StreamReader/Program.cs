using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _002_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            var arquivo = new StreamReader("arquivo.txt", Encoding.UTF8);

            //var todasAsLinhas = arquivo.ReadToEnd();

            String linha = String.Empty;

            //while ((linha = arquivo.ReadLine()) != null)
            //  Console.WriteLine(linha);
            
            while (linha != null)
            {
                linha = arquivo.ReadLine();

                Console.WriteLine(linha);
            }

            arquivo.Close();

            Console.ReadKey();
        }
    }
}