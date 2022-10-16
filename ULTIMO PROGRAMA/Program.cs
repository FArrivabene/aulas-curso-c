using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTIMO_PROGRAMA
{
  internal class Program
  {
    static void Main(string[] args)
    {
      float codigoP, qtd, soma = 0, aux = 0;
      char escolha;
      bool valido;

      Console.WriteLine("\n\tEspecificação              Código          Preço");
      Console.Write("\n\tCachorro Quente             100            2.50€");
      Console.Write("\n\tHambúrguer Simples          101            3.50€");
      Console.Write("\n\tHambúrguer Especial         102            4.50€");
      Console.Write("\n\tBifana Simples              103            2.70€");
      Console.Write("\n\tBifana com Queijo/Bacon     104            3.55€");
      Console.WriteLine("\n\tRefrigerante                105            1.75€");

      do
      {
        do
        {
          Console.Write("\n\tDigite o código do pedido:   ");
        } while (!(float.TryParse(Console.ReadLine(), out codigoP) && (codigoP <= 105 && codigoP >= 100)));

        do
        {
          Console.Write("\n\tDigite a quantidade:   ");
        } while (!float.TryParse(Console.ReadLine(), out qtd));


        if (codigoP == 100)
        {
          aux += +2.5f * qtd;
        }
        if (codigoP == 101)
        {
          aux += +3.5f * qtd;
        }
        if (codigoP == 102)
        {
          aux += +4.5f * qtd;
        }
        if (codigoP == 103)
        {
          aux += +2.7f * qtd;
        }
        if (codigoP == 104)
        {
          aux += +3.55f * qtd;
        }
        if (codigoP == 105)
        {
          aux += +1.75f * qtd;
        }

        soma = aux;

        do
        {
          Console.Write("\n\tGostaria de realizar mais uma eleição?  \n\t[S] - SIM       \n\t[N] - NÃO   \n\t» ");
          if ((valido = char.TryParse(Console.ReadLine().ToUpper(), out escolha)) == false || (escolha != 'N' && escolha != 'S'))
            Console.WriteLine("\n\tEscolha inválida, digite novamente!");
        } while (valido == false && (escolha != 'N' && escolha != 'S'));

      } while (escolha != 'N');

      Console.WriteLine($"\n\t{soma}");

    }
  }
}
