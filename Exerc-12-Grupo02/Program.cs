using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_12_Grupo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int eleitor = 0, branco = 0, nulo = 0, valido = 0;
            int res, voto;

            do
            {
                // Pedido e entrada de valores
                Console.Write("\n\t       [1]Branco       [2]Nulo         [3]Válido");
                Console.Write("\n\tDigite o seu voto:   ");
                // Validação da entrada
                if (int.TryParse(Console.ReadLine(), out voto) && voto >= 1 && voto <= 3)   
                {
                    if (voto == 1)          // Escolha 1 - Poderia tbm ser feito com um SWITCH
                    {
                        branco++;
                        eleitor++;
                    }
                    if (voto == 2)          // Escolha 2 - Poderia tbm ser feito com um SWITCH
                    {
                        nulo++;
                        eleitor++;
                    }
                    if (voto == 3)          // Escolha 3 - Poderia tbm ser feito com um SWITCH
                    {
                        valido++;
                        eleitor++;
                    }
                }
                else
                {
                    // Caso seja entrada inválida, mostrar a msg
                    Console.WriteLine("\n\tVoto inválido!");                                
                }

                //Loop para ser adicionado mais um eleitor
                do
                {
                    // Pedido de um novo eleito
                    Console.Write("\n\tRegistrar novo eleitor? \n\t[1]SIM \n\t[2]NÃO:   ");
                } while (!int.TryParse(Console.ReadLine(), out res));
            } while (res != 2); // Até que a resposta seja 2

            Console.WriteLine($"\n\tO número total de votos foi de {eleitor}");                                             // Total de eleitores
            Console.WriteLine($"\tO total de votos em BRANCO foi de {branco} votos equivale à {(branco*100) / eleitor}%");  // % de votos Brancos
            Console.WriteLine($"\tO total de votos em NULO foi de {nulo} votos equivale à {(nulo*100) / eleitor}%");        // % de votos Nulos
            Console.WriteLine($"\tO total de votos em VÁLIDO foi de {valido} votos equivale à {(valido*100) / eleitor}%");  // % de votos Válidos

            Console.ReadKey();
        }
    }
}
