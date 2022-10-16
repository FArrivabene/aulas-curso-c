using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_04_Grupo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*-------------------------------------------------------------*/
            // Resolução com "FOR"
            int num, aux = 0;
            for (int i = 1; i <= 10; i++)
            {
                do
                {
                    Console.Write("\n\tDigite um número:   ");
                } while (!int.TryParse(Console.ReadLine(), out num));

                if (num < 40 && num % 2 == 0)
                    aux = num + aux;
            }
            Console.WriteLine($"\n\tA soma é {aux}");

            /*-------------------------------------------------------------*/
            // Resolução com "DO WHILE"
            int qtd = 0, num2, aux1 = 0;
            do
            {
                qtd++;
                Console.Write("\n\tDigite um número:   ");
                num2 = int.Parse(Console.ReadLine());
                if (num2 < 40)
                {
                    aux1 = num2 + aux1;
                }
            } while (qtd <= 9);
            Console.WriteLine($"\n\tA soma é {aux1}");

            /*-------------------------------------------------------------*/
            // Resolução com "WHILE"
            int qtd1 = 0, num3, aux2 = 0;
            while (qtd1 < 10)
            {
                qtd1++;
                Console.Write("\n\tDigite um número:   ");
                num3 = int.Parse(Console.ReadLine());
                if (num3 < 40)
                {
                    aux2 = num3 + aux2;
                }
            }
            Console.WriteLine($"\n\tA soma é {aux2}");
        }
    }
}
