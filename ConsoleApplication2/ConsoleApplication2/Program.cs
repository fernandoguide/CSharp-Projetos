using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Escreva um programa que exiba na tela em ordem decrescente, apenas os números pares existentes de 111 a 2500.\n");
            Console.Write("Digite um numero: ");
            n = int.Parse(Console.ReadLine());

            for (n = 111; n <= 2500; n++)
                if (n % 2 == 0)
                {
                    {
                        Console.WriteLine("\nOs numeros pares são {0} ", n);
                    }
                }
            Console.WriteLine("\nTecle algo para continuar");
            Console.ReadKey();
        }
    }
}
