using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_Propriedade
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Pessoa
    {
        int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        String nome; //backing field

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public bool Sexo { get; set; }  //autoimplemented property

        public String CorDoSangue
        {
            get { return "VERMELHO"; }
        }

        //code snippet
        //prop
        public bool Fumante { get; set; }

        //propf
        private String cpf;

        public String Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        //propg
        public String Rg { get; private set; }
    }

    class Quadrado
    {
        int lado;

        //ctor
        public Quadrado(int lado) { this.lado = lado; }

        public int Area { get { return lado * lado; } }
        public int Perimetro { get { return 4 * lado; } }
    }

    internal class Circulo
    {
        private int raio;
        private double area;
        private double perimetro;

        public Circulo(int raio)
        {
            this.raio = raio;

            area = Math.PI * Math.Pow(raio, 2);
            perimetro = 2 * Math.PI * raio;
        }

        public double Area
        {
            get { return area; }
        }

        public double Perimetro
        {
            get { return perimetro; }
        }

        //evento, campo, construtor, propriedade, metodo, metodo sobrescrito
    }
}
