using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_14_Grupo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarar as variáveis
            int idade, sexo, idadeMaior = 0, idadeMenor = 0, soma = 0;
            int qtdHomens = 0, qtdMulheres = 0;

            Console.OutputEncoding = Encoding.UTF8;

            // Utilizar "FOR" por sabemos a qtd exata de repetições
            for (int i = 1; i <= 50; i++)
            {
                    do
                    {
                        // Validação da entrada com "DO WHILE"
                        Console.Write("\n\tDigite a sua idade:   ");
                    } while (!int.TryParse(Console.ReadLine(), out idade));

                    // Se validar entrada, já atualiza a soma da idade   
                    soma += idade;
                    if (idade >= 18)
                    {
                        // Vou colocar aqui uma valida para o "DO WHILE"
                        Console.Write("\n\tQual é o seu sexo?     [1]Feminino      [2]Masculino:   ");
                        if (int.TryParse(Console.ReadLine(), out sexo))
                            if (sexo == 1)
                            {
                                qtdMulheres++;
                                idadeMaior++;
                            }
                            else if (sexo == 2)
                            {
                                 qtdHomens++;
                            }
                            else
                            {
                                Console.WriteLine("\n\tSexo Inválido!");
                            }

                    }
                    else
                    {
                        Console.Write("\n\tQual é o seu sexo?     [1]Feminino      [2]Masculino:   ");
                        if (int.TryParse(Console.ReadLine(), out sexo))
                            if (sexo == 1)
                            {
                                qtdMulheres++;
                                idadeMenor++;
                            }
                            else if (sexo == 2)
                            {
                                qtdHomens++;
                            }
                            else
                            {
                                Console.WriteLine("\n\tSexo Inválido!");
                            }
                    }
            }

            Console.WriteLine($"\n\tSão do gênero feminino {qtdMulheres} e {idadeMaior} são maiores de idade.");
            Console.WriteLine($"\tSão do gênero masculino {qtdHomens} pessoa(s).");
            Console.WriteLine($"\tA média dessas idade é de {soma / (qtdHomens + qtdMulheres)} anos.");
            Console.WriteLine($"\tA porcentagem de homens é de {(qtdHomens * 100) / 5}%");
        }
    }
}
