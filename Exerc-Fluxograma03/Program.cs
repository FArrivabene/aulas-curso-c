using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_Fluxograma03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float nota, maior = 0, menor = 20, soma = 0 ;
            int negativas = 0;
            bool valido;

            for (int cont = 0; cont < 10; cont++)
            {
                do
                {
                    Console.Write($"\n\tInsira a {cont+1}º nota:   ");
                    if ((valido = float.TryParse(Console.ReadLine(), out nota)) == false || nota < 0 || nota > 20)
                        Console.WriteLine("\n\tNota inválida, insira a nota de 0 a 20");
                } while (valido == false || nota < 0 || nota > 20);

                soma += nota;
                if (nota > maior)
                    maior = nota;
                if(nota < menor)
                    menor = nota;
                if(nota < 10)
                    negativas++;
            }

            Console.WriteLine($"\n\tMedia = {soma / 10:0.00}");
            Console.WriteLine($"\n\tA nota mais alta = {maior}\n\tMenor nota = {menor}");
            Console.WriteLine($"\n\tA quantidade de notas negativas = {negativas}");
        }
    }
}
