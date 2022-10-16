using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_Fluxograma02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //    Ler as faltas do aluno e se igualar ou ultrapassar as 25, o aluno esta automaticamente reprovado!
            //    Com as faltas menores que 25, ler e pedir a validação dos testes e calcular a media do Aluno, o
            //    aluno será reprovado caso a média seja inferior a 8 valores irá para a recuperação com a media entre
            //    8 e 10 valores, e acima de 10 será aprovado! 

            byte faltas;
            float teste1=0, teste2=0, teste3=0, media;
            bool valido;

            do
            {
                Console.Write("\n\tDigite o nº de faltas do aluno:   ");
                valido = byte.TryParse(Console.ReadLine(), out faltas);
                if (valido == false)
                    Console.Write("\n\tEntrada Inválida! Digite novamente.");
            } while (valido == false);

            if (faltas >= 25)
                Console.WriteLine("\n\tReprovado por faltas!");
            else
            {
                //do
                //{
                //    Console.Write("\n\tInsira a nota do primeiro teste:   ");
                //    if((valido = float.TryParse(Console.ReadLine(), out teste1)) == false || teste1 < 0 || teste1 > 20)
                //        Console.Write("\n\tNota Inválida! Digite a nota de 0 a 20.");
                //} while (valido == false || teste1 < 0 || teste1 > 20);

                //do
                //{
                //    Console.Write("\n\tInsira a nota do primeiro teste:   ");
                //    if ((valido = float.TryParse(Console.ReadLine(), out teste2)) == false || teste2 < 0 || teste2 > 20)
                //        Console.Write("\n\tNota Inválida! Digite a nota de 0 a 20.");
                //} while (valido == false || teste2 < 0 || teste2 > 20);

                //do
                //{
                //    Console.Write("\n\tInsira a nota do primeiro teste:   ");
                //    if ((valido = float.TryParse(Console.ReadLine(), out teste3)) == false || teste3 < 0 || teste3 > 20)
                //        Console.Write("\n\tNota Inválida! Digite a nota de 0 a 20.");
                //} while (valido == false || teste3 < 0 || teste3 > 20);

                float nota;
                for (int i = 1; i <= 3; i++)
                {
                    do
                    {
                        Console.Write($"\n\tInsira a nota do {i} teste:   ");
                        if ((valido = float.TryParse(Console.ReadLine(), out nota)) == false || nota < 0 || nota > 20)
                            Console.Write("\n\tNota Inválida! Digite a nota de 0 a 20.");
                    } while (valido == false || nota < 0 || nota > 20);

                    float n = i == 1 ? teste1 = nota : (i == 2 ? teste2 = nota : teste3 = nota);

                }

                media = (teste1 + teste2 + teste3) / 3;
                if (media < 8)
                    Console.WriteLine($"\n\tReprovado com {media:0.00} valores.");
                else if (media <10)
                    Console.WriteLine($"\n\tObteve {media:0.00} valores. Vai fazer recuperação.");
                else
                    Console.WriteLine($"\n\tAprovado com {media:0.00} valores.");
            }
        }
    }
}
