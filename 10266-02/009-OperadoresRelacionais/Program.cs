using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _009_OperadoresRelacionais
{
    class Program
    {
        static void Main(string[] args)
        {
            // == != < > <= >=            
            
            int x = 10;            
            int y = 5;            
            
            Console.WriteLine(x == y); //false          
            Console.WriteLine(x == y * 2); //true         
            Console.WriteLine(x != y); //true 
            Console.WriteLine(x < y); //false           
            Console.WriteLine(x / 2 <= y); //true         
            Console.WriteLine(x > y); //true
            Console.WriteLine(x / 2 >= -y); //true          
            
            Console.ReadKey();
        }
    }
}
