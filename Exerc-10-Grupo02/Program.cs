using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_10_Grupo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float valorMerc, aux = 0;
            int qtd = 0, cont = 0;

            do
            {
                cont++;
                Console.Write("\n\tDigite o valor da mercadoria:   ");
                valorMerc = float.Parse(Console.ReadLine());
                aux = aux + valorMerc;

                Console.Write("\n\tRegistrar mais mercadoria? [1]SIM    [2]NÃO:   ");
                qtd = int.Parse(Console.ReadLine());
            } while (qtd != 2);

            Console.WriteLine($"\n\tO valor total é de {aux:0.00}");
            Console.WriteLine($"\tForam registados um total de {cont} mercadoria(s)");                        
            Console.WriteLine($"\tO valor médio do stock é de {aux / cont:0.00}");
        }
    }
}
