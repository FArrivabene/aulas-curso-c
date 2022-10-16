using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_03_Grupo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte alt, comp;

            do
            {
                Console.Write("\n\tDigite a largura do retângulo:   ");
            } while (!byte.TryParse(Console.ReadLine(), out alt) || alt == 0);

            do
            {
                Console.Write("\n\tDigite o comprimento do retângulo:   ");
            } while (!byte.TryParse(Console.ReadLine(), out comp) || comp == 0);

            //Escrever a parte superior
            for (int i = 0; i < comp; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            //Escrever as laterais (Dir e Esq)
            for (int j = 0; j < alt-2; j++)
            {
                Console.Write("*");
                for (int l = 0; l < comp-2; l++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }

            //Escrever a parte inferior
            for (int k = 0; k < comp; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
