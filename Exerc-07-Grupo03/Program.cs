using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_07_Grupo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, soma = 0;

            do
            {
                Console.Write("\n\tDigite um número:   ");
            } while (!int.TryParse(Console.ReadLine(), out num));

            for (int i = 1; i <= num/2; i++)
            {
                if (num % i == 0)
                {
                    soma += i;
                }
            }
            if (soma == num) 
            {
                Console.WriteLine("\n\tO número é perfeito");
                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine($"\t{i}");
                    }
                }
            }
               
            else
                Console.WriteLine("\n\tO número não é perfeito");
        }
    }
}
