using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipo[] nome; -> reference type

            int[] numeros;

            String[] palavras;

            //nome = new Tipo[qtdElementos]

            numeros = new int[4];

            palavras = new String[3];

            //nome[índice] = valor

            numeros[0] = 10;
            numeros[1] = 100;
            numeros[2] = 1000;

            palavras[0] = "abacate";
            palavras[1] = "abacaxi";
            palavras[2] = "banana";

            //var nome = new Tipo[]{lista de elementos}

            var doubles = new Double[]{ 1.1, 2.2, 3.3 };

            //Tipo[] nome = {lista de elementos}
            float[] floats = { 1.1F, 2.2F, 3.3F };

            Array.Sort(palavras);

            Array.Reverse(numeros);

            Console.WriteLine(Array.IndexOf(palavras, "banana"));
            Console.WriteLine(Array.LastIndexOf(palavras, "maçã"));

            for (int i = 0; i < palavras.Length; i++)
            {
                Console.WriteLine("{0} -> {1}", i, palavras[i]);
            }

            foreach (var item in palavras)
            {
                Console.WriteLine(item);
            }

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
