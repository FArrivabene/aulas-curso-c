using System;

namespace Exerc_07_B_Grupo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  7)  Escreva um algoritmo que leia o código de um aluno e as suas três notas. 
             *  Calcule a média ponderada do aluno, considerando que o peso para a maior nota seja 4 e para  as  duas  restantes,  3.  
             *  Mostre  o  código  do  aluno,  suas três  notas,  a  média calculada  e  uma  mensagem  "APROVADO"  se  a  média  for  maior  ou  igual  a  10  e "REPROVADO" se a média for menor que 10.
             */

            float n1, n2, n3, notaMaior, notaMenor1, notaMenor2, media;
            int cod;

            do
            {
                Console.Write("\n\tDigite o código do aluno:   ");
            } while (!int.TryParse(Console.ReadLine(), out cod) && (cod > 0) && (cod <= 100));

            for (int i = 1; i < 3; i++)
            {
                do
                {
                    Console.Write("\n\tDigite a primeira nota do aluno:   ");
                } while (!float.TryParse(Console.ReadLine(), out n1) && (n1 > 0) && (n1 <= 20));
                i++;

                do
                {
                    Console.Write("\n\tDigite a segunda nota do aluno:   ");
                } while (!float.TryParse(Console.ReadLine(), out n2) && (n2 > 0) && (n2 <= 20));
                i++;

                do
                {
                    Console.Write("\n\tDigite a terceira nota do aluno:   ");
                } while (!float.TryParse(Console.ReadLine(), out n3) && (n3 > 0) && (n3 <= 20));
                i++;
            }
        }
    }
}

