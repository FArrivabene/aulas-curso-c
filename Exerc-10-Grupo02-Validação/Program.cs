using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_10_Grupo02_Validação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            float valorMerc, aux = 0;
            int cont = 0;
            int qtd = 0;

            do
            {
                do
                {
                    Console.Write("\n\tDigite o valor da mercadoria:   ");
                } while (!float.TryParse(Console.ReadLine(), out valorMerc));
                cont++;
                aux += valorMerc;

                do
                {
                    Console.Write("\n\tRegistrar mais mercadoria? [1]SIM    [2]NÃO:   ");
                } while (!int.TryParse(Console.ReadLine(), out qtd));
            } while (qtd != 2);

            Console.WriteLine($"\n\tO valor total é de {aux}€");
            Console.WriteLine($"\tForam registados um total de {cont} mercadoria(s)");
            Console.WriteLine($"\tO valor médio do stock é de {aux / cont:0.00}€");
        }
    }
}
