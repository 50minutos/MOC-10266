using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _005_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //quais membros eu "enxergo"? os de Ave
            //qual a versão dos membros que eu uso? os da instância (objeto)
            Ave a = new Ave();
            a.Acordar(); a.Comer(); a.Dormir();

            //polimorfismo
            a = new Galinha();
            a.Acordar(); a.Comer(); a.Dormir();

            //para acessar membros que não estão definidos na classe da variável precisamos fazer o cast para o tipo correto
            ((Galinha)a).Cacarejar();

            //para usar a versão do método que NÃO FOI sobreposto (usamos new) precisamos fazer o cast para o tipo correto
            ((Galinha)a).Dormir();

            Console.ReadKey();
        }
    }

    class Ave
    {
        public void Acordar() { Console.WriteLine("a ave acordou"); }
        public virtual void Comer() { Console.WriteLine("a ave comeu"); }
        public void Dormir() { Console.WriteLine("a ave dormiu"); }
    }

    class Galinha : Ave
    {
        public void Cacarejar() { Console.WriteLine("cóóó"); }

        public override void Comer() { Console.WriteLine("a galinha comeu milho"); }
        public new void Dormir() { Console.WriteLine("a galinha dormiu no poleiro"); }
    }
}
