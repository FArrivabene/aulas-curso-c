using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_05_Grupo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            double capInici = 1500, capAcumu = 0;
            double tAnual = 0.02f, tJuros = 0.005f;
            double aux = capInici;

            for (float i = 0; i <= 3; i++)
            {
                capAcumu = capInici * Math.Pow((1 + tAnual), i);
                Console.WriteLine($"\n\tNo {i}º ano do capital acumulado será {capAcumu:0.00}€");
                tAnual += tJuros;
                aux = capAcumu;
            }
            Console.WriteLine($"\n\tNo final dos 3 anos, o capital acumulado será de: {capAcumu:0.00}€");
        }
    }
}
