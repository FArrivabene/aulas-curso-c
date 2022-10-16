using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_04_Grupo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, fact = 1;

            do
            {
                Console.Write("\n\tDigite um número:   ");
            } while (!int.TryParse(Console.ReadLine(), out num) || num < 1);


            for (int i = 2; i <= num; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine($"\n\t{num}! = {fact}");

            Console.ReadKey();
        }
    }
}
