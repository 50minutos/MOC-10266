﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MOIE = Microsoft.Office.Interop.Excel;
using System.Diagnostics;

//adicionar referência para Microsoft.Office.Interop.Excel

namespace _002_Interop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Livro> lista = new List<Livro>();

            lista.Add(new Livro() { Codigo = 1, Titulo = "ABC do Palitinho" });
            lista.Add(new Livro() { Codigo = 2, Titulo = "Truco sem mistério" });
            lista.Add(new Livro() { Codigo = 3, Titulo = "LINQ" });
            lista.Add(new Livro() { Codigo = 4, Titulo = "C# 4.0" });
            lista.Add(new Livro() { Codigo = 5, Titulo = "Eu pudia tá matano, eu pudia tá robanu, mais tô programanu em VB.NET 10" });

            //repare que não temos aquele monte de Type.Missing usados nas versões anteriores do framework!!!

            var excel = new MOIE.Application();

            excel.Workbooks.Add();

            var planilha = excel.ActiveSheet;

            int linha = 1;

            planilha.Cells[linha, "A"] = "Código";
            planilha.Cells[linha, "B"] = "Título";

            foreach (var item in lista)
            {
                planilha.Cells[++linha, "A"] = item.Codigo;
                planilha.Cells[linha, "B"] = item.Titulo;
            }

            planilha.Range["A1"].AutoFormat(MOIE.XlRangeAutoFormat.xlRangeAutoFormatClassic3);

            var nomeArquivo = String.Format(@"{0}\{1}", Environment.CurrentDirectory, "planilha.xlsx");

            planilha.SaveAs(nomeArquivo);

            excel.Quit();

            Process.Start(nomeArquivo);
        }
    }

    class Livro
    {
        public int Codigo { get; set; }
        public String Titulo { get; set; }
    }
}