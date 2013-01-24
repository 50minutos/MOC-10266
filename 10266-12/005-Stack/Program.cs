using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _005_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<String> pilha = new Stack<String>();
            //System.Collections.Stack-> de Objects

            pilha.Push("prato");
            pilha.Push("outro prato");
            pilha.Push("panela");

            foreach (var item in pilha)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(pilha.Peek());
            Console.WriteLine(pilha.Peek());
            Console.WriteLine(pilha.Peek());

            while(pilha.Count > 0)
                Console.WriteLine(pilha.Pop());

            Console.WriteLine(pilha.Count);

            Console.ReadKey();
        }
    }
}
