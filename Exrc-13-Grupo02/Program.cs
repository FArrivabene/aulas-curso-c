using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_13_Grupo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int hab = 0, res, idade, auxIdade = 0, maiorIdade = 0, menorIdade = 0, salario = 0, auxSalario = 0;
            int sexo, salarioMulher = 0;
            bool inicioLeitura = true;

            do
            {
                
                Console.Write("\n\tQual a sua idade?:   ");
                if(int.TryParse(Console.ReadLine(), out idade))
                {
                    auxIdade += idade;

                    // Inicio a verificação e atribuição dos valores nas variáveis utilizando um bool
                    if (inicioLeitura == true)
                    {
                        maiorIdade = idade;
                        menorIdade = idade;
                    }

                    // Altero para falso, pois ja realizou o loop
                    inicioLeitura = false;

                    // Realizo a comparação MAIOR
                    if (idade > maiorIdade)
                    {
                        maiorIdade = idade;
                    }

                    // Realizo a comparação MENOR
                    if (idade < menorIdade)
                    {
                        menorIdade = idade;
                    }

                    // Pedido de informaçõ MASCULINO ou FEMININO
                    do
                    {
                        Console.Write("\n\tQual o seu sexo? \t[1]Masculino        \t[2]Feminino:   ");
                    } while (!int.TryParse(Console.ReadLine(), out sexo));
                    if (sexo == 1)
                    {
                        hab++;
                        Console.Write("\n\tDigite o seu salário:   ");
                        if(int.TryParse(Console.ReadLine(), out salario) && salario > 0)
                        auxSalario += salario;
                    }
                    if (sexo == 2)
                    {
                        Console.Write("\n\tDigite o seu salário:   ");
                        if (int.TryParse(Console.ReadLine(), out salario) && salario > 0)
                            if(salario <= 800)
                            {
                                hab++;
                                salarioMulher++;
                                auxSalario += salario;
                            }
                            else
                            {
                                hab++;
                                auxSalario += salario;
                            }
                    }
                    
                }
                else
                {
                    Console.WriteLine("\n\tIdade Inválida!");
                }

                do
                {
                    // Pedido de um novo habitante
                    Console.Write("\n\tRegistrar novo habitante? \t[1]SIM \t[2]NÃO:   ");
                } while (!int.TryParse(Console.ReadLine(), out res));
            } while (res != 2);

            Console.WriteLine($"\n\tO número de habitantes é de {hab} pessoa(s)");
            Console.WriteLine($"\tMaior idade {maiorIdade}");
            Console.WriteLine($"\tMenor idade {menorIdade}");
            Console.WriteLine($"\tA média salarial é {auxSalario / hab}€");
            Console.WriteLine($"\tMulher com salário até 800 euros = {salarioMulher} pessoa(s)");

        }
    }
}
