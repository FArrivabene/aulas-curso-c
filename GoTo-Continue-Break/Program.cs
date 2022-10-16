using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTo_Continue_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Calcula a soma de 5 números ppsitivos no máximo
            // Se inserir um numero negativo termina logo o loop

            // break termina a execução do loop

            int num, soma = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("\n\tDigite um numero inteiro:   ");
                num = int.Parse(Console.ReadLine());

                if (num < 0)
                    break;
                soma += num;                
            }
            Console.WriteLine($"\n\tSoma = {soma}");



            // Calcula a soma dos números positivos até um máximo de 5
            // Se inserir um numero negativo termina logo o loop

            // continue - salta a iteração corrente sem executar as instruções

            int num1, soma1 = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("\n\tDigite um numero inteiro:   ");
                num1 = int.Parse(Console.ReadLine());

                if (num1 < 0)
                    continue;
                soma1 += num1;
            }
            Console.WriteLine($"\n\tSoma = {soma1}");


        }
    }
}
