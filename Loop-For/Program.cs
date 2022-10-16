using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            //Console.Write("\n\tDigite um número inteiro positivo:   ");
            //num = int.Parse(Console.ReadLine());

            //bool valido;
            //do
            //{
            //    Console.Write("\n\tDigite um número inteiro positivo:   ");
            //    valido = int.TryParse(Console.ReadLine(), out num);
            //} while (valido == false);

            // Ler e validar a entrade de um numero inteiro
            // Validação com "DO WHILE"
            do
            {
                Console.Write("\n\tDigite um número inteiro positivo:   ");
            } while (!int.TryParse(Console.ReadLine(), out num));

            /*-------------------------------------------------------------*/
            // Resolução com o FOR
            for (int i = 1; i <= 10;  i++)
            {
                Console.WriteLine($"\t{num} x {i} = {num*i}");
            }
            Console.WriteLine();

            /*-------------------------------------------------------------*/
            // Resolução com o DO WHILE
            int num1, qtd = 0;
            Console.Write("\n\tDigite um número inteiro positivo:   ");
            num1 = int.Parse(Console.ReadLine());
            do
            {
                qtd++;
                Console.WriteLine($"\t{num1} x {qtd} = {num1 * qtd}");
            } while (qtd <= 9);

            /*-------------------------------------------------------------*/
            // Resolução com o WHILE
            int num2, qtd1 = 0;
            Console.Write("\n\tDigite um número inteiro positivo:   ");
            num2 = int.Parse(Console.ReadLine());
            while (qtd1 <= 9)
            {
                qtd1++;
                Console.WriteLine($"\t{num2} x {qtd1} = {num2 * qtd1}");
            }
        }
    }
}
