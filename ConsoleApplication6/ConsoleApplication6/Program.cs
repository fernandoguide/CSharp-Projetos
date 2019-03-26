using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num_impares = 0, menor_numero, maior_numero;

            Console.WriteLine("Programa que mostra a quantidade de números ímpares entre dois números.");
            Console.WriteLine("-------------------------------------------------------------------------\n");

            Console.Write("\nDigite um número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("\nDigite outro número: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 <= num2)
            {
                menor_numero = num1;
                maior_numero = num2;
            }
            else
            {
                menor_numero = num2;
                maior_numero = num1;
            }
            for (int x = menor_numero; x <= maior_numero; x++)
            {
                if (x % 2 != 0) { num_impares++; }
            }
            Console.WriteLine("\nQuantidade de números ímpares entre {0} e {1} é {2}", menor_numero, maior_numero, num_impares);

            Console.WriteLine("\nPressione qualquer tecla para finalizar.");
            Console.ReadKey();
        }

    }
}
