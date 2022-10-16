using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_11_Grupo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada das variaveis, vou escrevendo conforme vou precisando
            int valorMerc, maior = 0, menor = 0;
            int auxT = 0;
            int cont = 0;
            int qtd = 0;

            bool inicioLeitura = true;

            do
            {   // Validação da entrada
                do
                {
                    Console.Write("\n\tDigite um número inteiro:   ");
                } while (!int.TryParse(Console.ReadLine(), out valorMerc));
                cont++;                 // Variavel contador
                auxT += valorMerc;      // Variavel para somar os nºs digitados

                // Inicio a verificação e atribuição dos valores nas variáveis utilizando um bool
                if( inicioLeitura == true)
                {
                    maior = valorMerc;
                    menor = valorMerc;
                }

                // Altero para falso, poi realizou o loop
                inicioLeitura = false;

                // Realizo a comparação MAIOR
                if (valorMerc > maior)  
                {
                    maior = valorMerc;
                }

                // Realizo a comparação MENOR
                if (valorMerc < menor)
                {
                    menor = valorMerc;
                }

                // Validação para mais nºs
                do
                {
                    Console.Write("\n\tRegistrar mais números? [1]SIM    [2]NÃO:   ");
                } while (!int.TryParse(Console.ReadLine(), out qtd));
            } while (qtd != 2);

            // Saída dos resultados
            Console.WriteLine($"\tO valor médio é de {auxT / cont}");   // Soma dividida pela quantidade
            Console.WriteLine($"\tO valor maior é {maior}");            // Maior nº
            Console.WriteLine($"\tO valor menor é {menor}");            // Menor nº
        }
    }
}
