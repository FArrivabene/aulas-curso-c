using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_02_Grupo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*-------------------------------------------------------------*/
            // Apresentar nºs de 0 até 20
            int a = 0;
            while (a <= 20)
            {
                Console.Write($"    {a}");
                a++;
            }
            Console.WriteLine();

            /*-------------------------------------------------------------*/
            // Apresentar nºs de 0 até 20 pares
            int b = 0;
            while (b <= 20)
            {
                Console.Write($"    {b}");
                b += 2;
            }
            Console.WriteLine();

            /*-------------------------------------------------------------*/
            // Não apresentar 5, 10, 15, 20
            int c = 0;
            while (c <= 20)
            {
                if (c % 5 != 0)
                    Console.Write($"    {c}");
                c++;
            }
            Console.WriteLine();

            /*-------------------------------------------------------------*/
            //Resolução com "FOR"
            for (int i = 0; i <= 20; i++)
            {
                if (i % 5 != 0)
                {
                    Console.Write($"    {i}");
                }
            }
            Console.WriteLine();
        }
    }
}
