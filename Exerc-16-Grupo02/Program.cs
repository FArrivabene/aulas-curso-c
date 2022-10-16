using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_16_Grupo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int eleitor;
            int votoD = 0, votoC = 0, votoB = 0, votoA = 0;
          
            for (int votos = 1; votos <= 2; votos++)
            {
                do
                {
                    Console.Write("\n\t[1]Candidato A \n\t[2]Candidato B \n\t[3]Indeciso \n\t[4]Não vão votar \n\n\tDigite a sua intenção de voto:   ");
                } while (!(int.TryParse(Console.ReadLine(), out eleitor) && eleitor >=1 && eleitor <= 4));

                if (eleitor == 1)
                {                   
                    votoA++;
                }

                if (eleitor == 2)
                {                    
                    votoB++;
                }

                if (eleitor == 3)
                {                 
                    votoC++;
                }

                if (eleitor == 4)
                {                   
                    votoD++;
                }
            }
            int totalVotos;
            totalVotos = votoA + votoB + votoC + votoD;

            Console.WriteLine($"\n\tO total de votos para cada opção é de: " +
                $"\nopção A = {(votoA * 100) / totalVotos}% " +
                $"\nopção B = {(votoB * 100) / totalVotos}% " +
                $"\nopção C = {(votoC * 100) / totalVotos}% " +
                $"\nopção D = {(votoD * 100) / totalVotos}%");
        }
    }
}
