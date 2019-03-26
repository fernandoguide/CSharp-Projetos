using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Ordem decrescente de números pares existentes de 2500 a 111.\n");

            for (n = 2500;  n >= 111; n--)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("{0} ", n);
                }
            }

            Console.WriteLine("\nPressione qualquer tecla pra continuar");
            Console.ReadKey();
        }
    }
}
