using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            char resp;
            string mens;
            
                Console.WriteLine("Analisa o tipo de triangulo a partir das medidas de seus lados");
                do
                {
                    Console.Write("\nInforme o Lado A do Triangulo: ");a = int.Parse(Console.ReadLine());
                    Console.Write("\nInforme o Lado B do Triangulo: ");b = int.Parse(Console.ReadLine());
                    Console.Write("\nInforme o Lado C do Triangulo: ");c = int.Parse(Console.ReadLine());
                    
                    if (a + b > c && a + c > b && b + c > a)
                    {
                        if ((a == b) && (b == c) && (c == a))
                        {
                            mens="\nEsse Triangulo é Equilatero";
                        }
                        else if ((a == b) || (b == c) || (c== a))
                        {
                            mens="\nEsse Triangulo é Isosceles";
                        }
                        else
                        {
                            mens="\nEsse Triangulo é Escaleno";
                        }// fim do 2° if
                    } // fim do  1° if
                    else
                            mens = "\nTais medidas não formam um triângulo.";
                    Console.WriteLine(mens);
                    Console.Write("\nDeseja executar novamente?\n\nDigite [s] para SIM ou [n] para NÃO. ");
                    resp = char.Parse(Console.ReadLine());
                }
                while ((resp == 's') || (resp == 's'));
            Console.WriteLine("\n\n\tPressione qualquer tecla para finalizar");
            Console.ReadKey();
        }
    }
}
