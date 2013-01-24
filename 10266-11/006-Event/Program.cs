using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _006_Event
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto() { Codigo = 1, Nome = "MARTELO", EstoqueMinimo = 15, Estoque = 50 };

            p.EventoEstoqueBaixo += new DelegateEstoqueBaixo(p_EventoEstoqueBaixo);

            while (p.Estoque-- > 1) ;

            Console.ReadKey();
        }

        static void p_EventoEstoqueBaixo(Produto p)
        {
            Console.WriteLine("O estoque ({0}) do produto ({1}) está abaixo do mínimo ({2})", p.Estoque, p.Nome, p.EstoqueMinimo);
        }
    }

    delegate void DelegateEstoqueBaixo(Produto p);

    class Produto
    {
        public int Codigo { get; set; }
        public String Nome { get; set; }
        public int EstoqueMinimo { get; set; }

        private int estoque;

        public int Estoque
        {
            get { return estoque; }
            set 
            { 
                estoque = value;

                if (estoque < EstoqueMinimo && EventoEstoqueBaixo != null)
                    EventoEstoqueBaixo(this);
            }
        }

        public event DelegateEstoqueBaixo EventoEstoqueBaixo;
    }
}
