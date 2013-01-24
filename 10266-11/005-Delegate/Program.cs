using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _005_Delegate
{
    delegate double DelegateOperacao(double a, double b);

    class Calculadora
    {
        public static double Somar(double a, double b) { return a + b; }
        public static double Subtrair(double a, double b) { return a - b; }
        public double Multiplicar(double a, double b) { return a * b; }
        public double Dividir(double a, double b) { return a / b; }
    }

    class NovaCalculadora
    {
        public double Elevar(double n, double p) { return Math.Pow(n, p); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double x = 10;
            double y = 3;

            Console.Write("Escolha uma operação (+-*/^): ");
            String op = Console.ReadLine();

            DelegateOperacao _do = null;

            switch (op)
            {
                case "+":
                    _do = new DelegateOperacao(Calculadora.Somar);
                    break;
                case "-":
                    _do = new DelegateOperacao(Calculadora.Subtrair);
                    break;
                case "*":
                    _do = new DelegateOperacao(new Calculadora().Multiplicar);
                    break;
                case "/":
                    _do = new DelegateOperacao(new Calculadora().Dividir);
                    break;
                case "^":
                    _do = new DelegateOperacao(new NovaCalculadora().Elevar);
                    break;
                default:
                    return;
            }

            //Console.WriteLine(_do.Invoke(x, y));
            Console.WriteLine(_do(x,y));

            Console.ReadKey();
        }
    }
}
