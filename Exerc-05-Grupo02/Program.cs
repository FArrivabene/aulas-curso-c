using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_05_Grupo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Resposta A
            //int num1, num2, aux = 0;
            //do
            //{
            //    Console.Write("\n\tDigite o primeiro número:   ");
            //} while (!int.TryParse(Console.ReadLine(), out num1));

            //do
            //{
            //    Console.Write("\n\tDigite o segundo número:   ");
            //} while (!int.TryParse(Console.ReadLine(), out num2));

            //for (int i = num1; i <= num2; i++)
            //{
            //    aux = i + aux;
            //}
            //Console.WriteLine($"\n\t Soma {aux}");

            // Resposta B
            int num3, num4, aux = 0;
            do
            {
                Console.Write("\n\tDigite o primeiro número:   ");
            } while (!int.TryParse(Console.ReadLine(), out num3));

            do
            {
                Console.Write("\n\tDigite o segundo número:   ");
            } while (!int.TryParse(Console.ReadLine(), out num4));

            //if (num3 > num4)
            //{
            //    aux = num3;
            //    num3 = num4;
            //    num4 = aux;
            //}

            for (int i = num3; i <= num4; i++)
            {
                if (i % 2 == 0) //Resultado do exerc 06
                    aux += i;
            }
            Console.WriteLine($"\n\t Soma {aux}");
        }
    }
}
