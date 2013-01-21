using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _010_OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            //&& || !            
            //&& -> retorna true se TODOS forem true            
            //|| -> retorna true se ALGUM for true            
            //! -> inverte o valor de true/false            
            
            Console.WriteLine (true && false); //false           
            Console.WriteLine(false || true); //true    
            Console.WriteLine(!!true); //true
            
            Object o = null;
            
            //short circuit            
            if(o != null && o.ToString() == "System.Object")                
                Console.WriteLine("é objeto");            
            else                
                Console.WriteLine("é null ou não é objeto");            

             Console.ReadKey();
        }
    }
}
