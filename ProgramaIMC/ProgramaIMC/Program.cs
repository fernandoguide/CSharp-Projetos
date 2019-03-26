using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaIMC
{
    class Program
    {
        static void Main(string[] args)
        { 
            float A, P, imc = 0;
            char resp;
            do
            {
                Console.WriteLine("\nCalcula o Indice de Massa Corporal.");
                Console.Write("\nDigite o seu peso: "); P = float.Parse(Console.ReadLine());
                Console.Write("\nDigite o seu altura: "); A = float.Parse(Console.ReadLine());
                imc = (P) / ((A) * (A));
                Console.WriteLine(" Seu IMC é:{0} ", imc);

                if (imc < 18.5)
                {
                    Console.WriteLine("\nPeso abaixo do normal");
                }
                else if (imc == 18.5)
                {
                    Console.WriteLine("\nPeso normal");
                }
                else if (imc < 25)
                {
                    Console.WriteLine("\nPeso normal");
                }
                else if (imc == 25)
                {
                    Console.WriteLine("\nSobre o Peso");
                }
                else if (imc < 30)
                {
                    Console.WriteLine("\nSobre o Peso");
                }
                else if (imc == 30)
                {
                    Console.WriteLine("\nObesidade Grau I");
                }
                else if (imc < 35)
                {
                    Console.WriteLine("\nObesidade Grau I");
                }
                else if (imc == 35)
                {
                    Console.WriteLine("\nObesidade Grau II");
                }
                else if (imc <= 40)
                {
                    Console.WriteLine("\nObesidade Grau II");
                }
                else if (imc >= 40)
                {
                    Console.WriteLine("\nObesidade Grau III");
                }
                Console.WriteLine("\nDeseja Calcular o IMC Novamente ?\nDigite [s] p/ SIM\nDigite [n] p/ NAO. ");
                resp = char.Parse(Console.ReadLine());
            } while (resp == 's' || resp == 's');

            Console.WriteLine("\n\tPressione qualquer tecla p/ finalizar.");
            Console.ReadKey();

            }
        }
    }
    

