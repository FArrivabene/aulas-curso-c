using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_02_Grupo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int num1, num2, num3, num4, soma = 0;

            do
            {
                Console.Write("\n\tDigite o número o 1º dígito:   ");
            } while (!int.TryParse(Console.ReadLine(), out num1) || num1 > 9);

            do
            {
                Console.Write("\n\tDigite o número o 2º dígito:   ");              
            } while (!int.TryParse(Console.ReadLine(), out num2) || num2  > 9);

            do
            {
                Console.Write("\n\tDigite o número o 3º dígito:   ");             
            } while (!int.TryParse(Console.ReadLine(), out num3) || num3 > 9);

            do
            {
                Console.Write("\n\tDigite o número o 4º dígito:   ");               
            } while (!int.TryParse(Console.ReadLine(), out num4) || num4 > 9);

            int r1, r2, r3, r4, digiControl;

            r1 = num4 * 1;
            r2 = num3 * 2;
            r3 = num3 * 3;
            r4 = num1 * 4;

            soma = r1 + r2 + r3 + r4;

            digiControl = soma % 7;
            Console.WriteLine($"\n\tCódigo final = {num1}{num2}{num3}{num4}{digiControl}");
            */



            //VERSÃO 2
            //Leitura do código uma unica vez
            /*
           int codigo, n1, n2, n3, n4;

           do
           {
               Console.Write("\n\tDigite o código (4 digitos):   ");
           } while (!int.TryParse(Console.ReadLine(), out codigo) || codigo < 1000 || codigo > 9999);

           int aux = codigo;

           n1 = aux / 1000;
           n2 = (aux % 1000) / 100;
           n3 = ((aux % 1000) % 100) / 10;
           n4 = ((aux % 1000) % 100) % 10;
           int soma1 = n1*4 + n2*3 + n3*2 + n4*1;
           int dcontrole = soma % 7;

           Console.WriteLine($"\n\tCodigo final = {codigo}{dcontrole}");
            */



            //VERSÃO 3
            //Leitura do código uma unica vez
            //Utilizar loop para 

            /*
            int numCod, codigo;
            int aux;

            do
            {
                Console.Write("\n\tQuantos digitos tem o código?   ");
            } while (!int.TryParse(Console.ReadLine(), out numCod) || numCod < 1000 || numCod > 9999);

            do
            {
                Console.Write("\n\tDigite o código:   ");
            } while (!int.TryParse(Console.ReadLine(), out codigo) || codigo < 1000 || codigo > 9999);


            for (int i = 1; i <= numCod; i++)
            {
                aux += 
                for (int i = 0; i < length; i++)
                {

                }
            }
            */

            /*
            uint codigo, total = 0, divisor, aux;
            byte numDig;

            do
            {
                Console.Write("\n\tQuantos digitos tem o código (mínimo 4 e máximo 8)?   ");
            } while (!byte.TryParse(Console.ReadLine(), out numDig) || numDig < 4 || numDig > 8);

            uint max = (uint)(Math.Pow(10, numDig) - 1);
            uint min = (uint)(Math.Pow(10, numDig - 1));
            divisor = min;

            do
            {
                Console.Write("\n\tDigite o código:   ");
            } while (!uint.TryParse(Console.ReadLine(), out codigo) || codigo < min || codigo > max);


            aux = codigo;
            do
            {
                //total = total + (aux / divisor) * numDig;
                total += (aux / divisor) * numDig;
                //aux = aux % divisor;
                aux %= divisor;
                //divisor = divisor / 10;
                divisor /= 10;
                numDig--;
            } while (divisor > 0);

            Console.WriteLine($"\n\tCodigo final = {codigo}{total % 7}");
            */


            //VERSÃO 4

            uint codigo, total = 0, aux;
            byte numDig, natural;

            do
            {
                Console.Write("\n\tQuantos digitos tem o código (mínimo 4 e máximo 8)?   ");
            } while (!byte.TryParse(Console.ReadLine(), out numDig) || numDig < 4 || numDig > 8);

            uint max = (uint)(Math.Pow(10, numDig) - 1);
            uint min = (uint)(Math.Pow(10, numDig - 1));

            do
            {
                Console.Write("\n\tDigite o código:   ");
            } while (!uint.TryParse(Console.ReadLine(), out codigo) || codigo < min || codigo > max);


            aux = codigo;
            natural = 1;
            do
            {
                total += (aux % 10) * natural;
                aux /= 10;
                natural++;
            } while (aux > 0);

            Console.WriteLine($"\n\tCodigo final = {codigo}{total % 7}");
        }
    }
}
