using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _003_TryCatches
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite um número inteiro: ");
                int x = Int32.Parse(Console.ReadLine());

                //de String para XXX -> XXX.Parse(String)

                Console.WriteLine(10 / x);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divisão por ZERO!!!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Digite um número INTEIRO!!!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Não sabe o que é um número INTEIRO???");
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
