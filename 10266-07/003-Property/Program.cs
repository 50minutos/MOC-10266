using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _003_Property
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Pessoa
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        

        private char sexo;

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        
    }
}
