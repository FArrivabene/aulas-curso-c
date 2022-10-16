using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_11_Grupo02_Prof
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n, maior = Int32.MinValue, menor = Int32.MaxValue, soma = 0, num;

            do
            {
                Console.Write("\n\tQuantos números pretende inserir?   ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

            for (int i = 1; i <= n; i++)
            {
                do
                {
                    Console.Write($"\n\tDigite o {i}º número:   ");
                } while (!int.TryParse(Console.ReadLine(), out num));

                if (num > maior)
                    maior = num;

                if (num < menor)
                    menor = num;

                soma += num;

            }

            Console.WriteLine($"\n\tMaior = {maior}\n\tMenor = {menor}\n\tMédia = {(float)soma / n} ");

         }
    }
}
