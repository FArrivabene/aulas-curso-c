using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_09_Grupo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float valorMerc, aux = 0;
            int qtd, cont = 0;

            do
            {
                Console.Write("\n\tDigite o número total de mercadorias em stock:   "); //Resposta (A)
            } while (!int.TryParse(Console.ReadLine(), out qtd) || qtd == 0);
                do
                {
                    cont++;
                    Console.Write("\n\tDigite o valor da mercadoria:   ");          //Resposta (B)
                    valorMerc = float.Parse(Console.ReadLine());
                    aux += valorMerc;
                } while (cont < qtd);
                
            Console.WriteLine($"\n\tO valor total é de {aux}");                     //Resposta (C)
            Console.WriteLine($"\n\tO valor médio do stock é de {aux / qtd:0.00}"); //Resposta (C)
        }
    }
}
