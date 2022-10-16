using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_17_Grupo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            char resPessoa, genero, res;
            int qtdPessoa = 0, simM = 0, naoM = 0, simF = 0, naoF = 0;

            do
            {
                Console.Write("\n\t[S] - SIM \n\t[N] - NÃO \n\tRegistrar mais uma pessoa?   ");
                if (!char.TryParse(Console.ReadLine().ToUpper(), out resPessoa) || (resPessoa != 'S' && resPessoa != 'N'))
                    Console.WriteLine("\n\tResposta inválida!");

                if (resPessoa == 'S')
                {
                    do
                    {
                        Console.Write("\n\t[M] - Masculino\n\t[F] - Feminino \n\tQual é o seu género?:   ");
                        if (!char.TryParse(Console.ReadLine().ToUpper(), out genero) || (genero != 'M' && genero != 'F'))
                            Console.WriteLine("\n\tGénero inválido!");
                    } while ((genero != 'M' && genero != 'F'));

                    if (genero == 'M')
                    {
                        do
                        {
                            Console.Write("\n\t[S] - SIM \n\t[N] - NÃO \n\tGostou do produto?   ");
                            if (!char.TryParse(Console.ReadLine().ToUpper(), out res) || (res != 'S' && res != 'N'))
                                Console.WriteLine("\n\tResposta inválida!");
                        } while ((res != 'S' && res != 'N'));

                        if (res == 'S')
                        {
                            qtdPessoa++;
                            simM++;
                        }
                        else
                        {
                            qtdPessoa++;
                            naoM++;
                        }
                    }

                    if (genero == 'F')
                    {
                        do
                        {
                            Console.Write("\n\t[S] - SIM \n\t[N] - NÃO \n\tGostou do produto?   ");
                            if (!char.TryParse(Console.ReadLine().ToUpper(), out res) || (res != 'S' && res != 'N'))
                                Console.WriteLine("\n\tResposta inválida!");
                        } while ((res != 'S' && res != 'N'));

                        if (res == 'S')
                        {
                            qtdPessoa++;
                            simF++;
                        }
                        else
                        {
                            qtdPessoa++;
                            naoF++;
                        }
                    }

                }

            } while (resPessoa != 'N') ;

                Console.WriteLine($"\n\tNúmero total de pessoas que gostaram do produto: {simF + simM}");
                Console.WriteLine($"\tNúmero total de pessoas que não gostaram do produto: {naoF + naoM}");
                Console.WriteLine($"\tA porcentagem de pessoas Masculinas que não gostaram do produto foi de: {(naoM * 100) / qtdPessoa}%");
                Console.WriteLine($"\t");
            
        }
    }
}
