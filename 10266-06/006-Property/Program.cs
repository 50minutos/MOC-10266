using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _006_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            
            p.Codigo = 1;
            p.Nome = "adão";
            p.Sexo = Sexo.masculino;

            Console.WriteLine(p.Codigo);
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Sexo);

            Console.ReadKey();
        }
    }

    enum Sexo { masculino, feminino }

    class Pessoa
    {
        //int codigo; //campo
        //public int Codigo //propriedade
        //{
        //    get { return codigo; }
        //    set { codigo = value; }
        //}
        
        //String nome;
        //public String Nome
        //{
        //    get { return nome; }
        //    set { nome = value; }
        //}
        
        //Sexo sexo; //os campos são chamados backing field quando são usados juntamente com propriedades
        //public Sexo Sexo 
        //{
        //    get { return sexo; }
        //    set { sexo = value; }
        //}

        //propriedade autoimplementada
        public int Codigo { get; set; }
        public String Nome { get; set; }
        public Sexo Sexo { get; set; }
    }
}
