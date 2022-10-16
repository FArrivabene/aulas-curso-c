using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_01_Grupo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numP, numC;
            bool val, val2;

            do
            {
                Console.Write("\n\tDigite o numero de pontos:   ");
                val = int.TryParse(Console.ReadLine(), out numP);
                if (val == false || numP == 0)
                    Console.WriteLine("\n\tNúmero inválido, digite novamente");
            } while (val == false || numP == 0 || numP == 0);

            do
            {
                Console.Write("\n\tDigite o numero de casas:   ");
                val2 = int.TryParse(Console.ReadLine(), out numC);
                if (val2 == false || numC == 0)
                    Console.WriteLine("\n\tNúmero inválido, digite novamente");
            } while (val2 == false || numP == 0 || numP == 0);

            for (int i = 1; i <= numP; i++)
            {
                for (int j = 1; j <= numC; j++)
                {
                    Console.WriteLine($"\n\t{i} - {j}");
                }
            }
        }
    }
}
