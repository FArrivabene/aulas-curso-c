using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_06_Grupo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numDigi, numDigi2;
            float quociente, produto, soma = 0;

            do
            {
                Console.Write("\n\tDigite o primeiro número inteiro:   ");
            } while (!float.TryParse(Console.ReadLine(), out numDigi) || numDigi == 0);

            do
            {
                Console.Write("\n\tDigite o segundo número inteiro:   ");
            } while (!float.TryParse(Console.ReadLine(), out numDigi2) || numDigi2 == 0);

            quociente = numDigi;
            produto = numDigi2;

            while (quociente >= 1)
            {
                if (quociente % 2 != 0)
                    soma += produto;
                quociente /= 2;
                produto *= 2;
            }

            Console.WriteLine($"\n\tSoma = {soma} | {numDigi} x {numDigi2} = {numDigi * numDigi2}");
            
        }
    }
}
