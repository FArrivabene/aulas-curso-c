using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Incrementos_Decrementos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //      Operador Incremento: "++"   x++ ou ++x
            //      Operador Decremento: "--"   y-- ou --y

            int x = 2, y = 5;

            //operação realizada apenas na próxima linha
            Console.WriteLine($"\n\tPosfixo: {x}++ = {x++}");
            Console.WriteLine($"\n\t x= {x}");

            //operação realizada apenas na próxima linha
            Console.WriteLine($"\n\tPosfixo: {y}-- = {y--}");
            Console.WriteLine($"\n\t x= {y}");

            //operação realizada na mesma linha
            Console.WriteLine($"\n\tPrefixo: ++{x} = {++x}");
            Console.WriteLine($"\n\t x= {x}");

            //operação realizada na mesma linha
            Console.WriteLine($"\n\tPrefixo: --{y} = {--y}");
            Console.WriteLine($"\n\t x= {y}");
        }
    }
}
