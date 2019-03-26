using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programatriangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado1, lado2, lado3;
            Console.WriteLine("Descobre se um triangulo é Equilatero,Isosceles e Escaleno");
            Console.Write("\nInforme o Lado 1 do Triangulo: "); lado1 = int.Parse(Console.ReadLine());
            Console.Write("\nInforme o Lado 2 do Triangulo: "); lado2 = int.Parse(Console.ReadLine());
            Console.Write("\nInforme o Lado 3 do Triangulo: "); lado3 = int.Parse(Console.ReadLine());
            if (lado1 + lado2 >= lado3 && lado1 + lado3 >= lado2 && lado2 + lado3 >= lado1)
            {
                if (lado1 == lado2 && lado2 == lado3 && lado3 == lado1)
                {
                    Console.WriteLine("\nEsse Triangulo é Equilatero");
                }
                else if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
                {
                    Console.WriteLine("\nEsse Triangulo é Isosceles");
                }
                else if (lado1 != lado2 && lado2 != lado3 && lado3 != lado1)
                {
                    Console.WriteLine("\nEsse Triangulo é Escaleno");
                }
            }
            else
                Console.WriteLine("\nValores invalidos para formar um triangulo.");

            Console.WriteLine("\n\n\tPressione qualquer tecla para finalizar");
            Console.ReadKey();
        }
    }
}
