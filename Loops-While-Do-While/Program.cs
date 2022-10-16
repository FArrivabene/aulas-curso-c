using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_While_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Com loop "while"
            int a = 1;
            Console.WriteLine("\n\tMúltiplos de 3");
            while (a <= 50)
            {
                if(a % 3 == 0)
                    Console.Write($" {a} ");
                a++;
            }
            Console.WriteLine();

            // Com loop "do while"
            // O loop "do while" primeiro executa o bloco de código e só testa no fim
            // Repete uma ou mais vezes

            int b = 1;
            do
            {
                if (b % 3 == 0)
                    Console.Write($" {b} ");
                b++;
            } while (b <= 50);
            Console.WriteLine();
        }
    }
}
