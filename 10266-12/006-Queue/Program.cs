using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _006_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<String> fila = new Queue<String>();
            //System.Collections.Queue -> de Objects

            fila.Enqueue("zé");
            fila.Enqueue("chico");
            fila.Enqueue("tião");
            fila.Enqueue("tonho");

            foreach (var item in fila)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Peek());

            while (fila.Count > 0)
                Console.WriteLine(fila.Dequeue());

            Console.WriteLine(fila.Count);

            Console.ReadKey();
        }
    }

}
