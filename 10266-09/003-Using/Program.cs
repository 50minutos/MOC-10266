using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace _003_Using
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo de quem já implementa IDisposable
            using (var c = new SqlConnection())
            {
                using (var k = new SqlCommand())
                { 
                
                }
            }
            #endregion

            #region Carro

            using (var carro = new Carro(1987, "FIAT", "147 L", "AB 1234", 1300, Combustivel.álcool))
            { 
                //todo: qualquer código aqui...
            }

            #endregion 

            Console.ReadKey();
        }
    }

    enum Combustivel
    { 
        gasolina, álcool, gás
    }

    class Motor
    {
        public int CC { get; set; }
        public Combustivel Combustivel { get; set; }
    }

    class Carro : IDisposable
    {
        public int Ano { get; set; }
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public String Placa { get; set; }
        public Motor Motor { get; set; }

        public Carro(int ano, String marca, String modelo, String placa, int cc, Combustivel combustivel)
        {
            Motor = new Motor() { CC=cc, Combustivel = combustivel };
            Ano = ano;
            Marca = marca;
            Modelo = modelo;
            Placa = placa;
        }

        public void Dispose() { Motor = null; }
    }
}
