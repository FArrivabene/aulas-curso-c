using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_01_Grupo02
{
    internal class Program
    {
        static void Main(string[] args)

        //1.Crie umprograma em que apareça uma listagem de números entre 0 e 20.
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
            // Apresentar nºs de 0 até 20
            for (int c = 0; c <= 20; c++)
            {
                Console.Write($"    {c}");
            }
            Console.WriteLine();

            /*-------------------------------------------------------------*/
            // Apresentar nºs de 0 até 20
            // Sempre começa com 1 pois o código é executado primeiro, indepentende da condição.
            int d = 0;
            do
            {
                d+= 1;
                Console.Write($"    {d}");
            } while (d <= 19);
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
        }
    }
}
