using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que faz uma tabuada\n");

            Console.Write("Digite um número: ");
            int numero, resultado;
            numero = int.Parse(Console.ReadLine());

            for (int x = 1; x <= 10; x++)
            {
                resultado = numero * x;
                Console.Write("{0}x{1}={2}\n", numero, x, resultado);
            }
            Console.WriteLine("\nPressione qualquer tecla para finalizar.");
            Console.ReadKey();
        }
    }

}
