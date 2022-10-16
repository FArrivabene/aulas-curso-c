using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LerAno
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ano;

            ano = DateTime.Now.Year;
            int mes = DateTime.Now.Month;
            int dia = DateTime.Now.Day;
            int hora = DateTime.Now.Hour;

            Console.WriteLine($"\n\t{ano}");
            Console.WriteLine($"\n\t{mes}");
            Console.WriteLine($"\n\t{dia}");
            Console.WriteLine($"\n\t{hora}");

        }
    }
}
