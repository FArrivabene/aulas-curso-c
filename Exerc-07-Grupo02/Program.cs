using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_07_Grupo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ler um sequência de números inteiro terminada por -1 e apresentar
            //a soma de todos os valores, a média aritmética e quantos foram os nºs ímpares inseridos

            int num, soma = 0, quantidade = 0, ctimpares = 0;

            do
            {
                Console.Write("\n\tDigite um valor inteiro (Termine com -1):   ");
                if (int.TryParse(Console.ReadLine(), out num) && num > -1)
                {
                    soma += num;        //Soma recebe o que ja tem mais a varaivel num
                    quantidade++;
                    if(num % 2 != 0)
                        ctimpares++;
                }                
            } while (num != -1);

            Console.WriteLine($"\n\tA soma de todos os valores é: {soma}");
            Console.WriteLine($"\n\tA média é igual: {(float)soma/quantidade:0.00}");
            Console.WriteLine($"\n\tForam digitados {ctimpares} números ímpares");
        }
    }
}
