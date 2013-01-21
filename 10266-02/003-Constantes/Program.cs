using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _003_Constantes
{
    class Program
    {
        static void Main(string[] args)
        {
            const String COR_DO_SANGUE = "VERMELHO";
            const double PI = 3.141592;
            const double E = 2.718281828459045;

            Console.WriteLine("a cor do meu sangue é {0}",
                COR_DO_SANGUE);

            Console.WriteLine("o valor de PI é {0}",
                            PI);
            
            Console.WriteLine("o valor de E é {0}",
                            E);

            Console.WriteLine("PI + PI = {0}", PI + PI);

            Console.ReadKey();

            //ALT+B, B OU CTRL+SHIFT+B - BUILD
        }
    }
}
