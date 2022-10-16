using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_08_Grupo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double j = 1.5, z = 1.1;
            double anos = 0;

            do
            {
                anos++;
                if (j > z)
                {
                    j = j + 0.10;
                    z = z + 0.15;
                }
            } while (!(z > j)); 

            Console.WriteLine($"\n\tSerão necessários {anos} anos!");
            Console.WriteLine($"\tALtura do Joao {j}");
            Console.WriteLine($"\tALtura do Zé {z}");
        }
    }
}
