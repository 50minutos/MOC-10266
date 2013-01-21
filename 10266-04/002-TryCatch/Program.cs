using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //try - tentativa de execução
            //catch - captura de exceptions
            //finally - executa sempre

            try
            {
                Console.Write("Digite um número inteiro: ");
                int x = Int32.Parse(Console.ReadLine());

                //de String para XXX -> XXX.Parse(String)

                Console.WriteLine(10 / x);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Tipo: {0}", ex.GetType().Name);
                Console.WriteLine("Mensagem: {0}", ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
