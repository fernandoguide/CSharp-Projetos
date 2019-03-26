using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                char sexo, resp ;
                float peso, altura, imc;
                

                do
                {
                    Console.WriteLine("Programa que calcula o indice de massa corporal e diz peso ideal.");
                    Console.WriteLine("-----------------------------------------------------------------\n\n");

                    Console.Write("\nDigite o sexo 'f' para feminino ou 'm' para masculino: "); sexo = char.Parse(Console.ReadLine());
                    while ((sexo != 'F') && (sexo != 'f') && (sexo != 'M') && (sexo != 'm'))
                    {
                        Console.Write("Sexo inválido! Digite M para masculino ou F para feminino: ");
                        sexo = char.Parse(Console.ReadLine());
                    }

                    Console.Write("\nDigite a altura em metros: "); altura = float.Parse(Console.ReadLine());
                   /* if (float.TryParse(altura.Text.Trim(), out altura) == false)
                    {
                       Console.WriteLine("Altura inválida! Digite a Altura em números em decimais");
                        return;
                    }*/

                    Console.Write("\nDigite o peso em quilos: "); peso = float.Parse(Console.ReadLine());
                    /*if (float.TryParse(peso.Text.Trim(), out peso) == false)
                    {
                        Console.WriteLine("Peso inválido! Digite o Peso em números em decimais");
                        return;
                    }*/
                    imc = peso / (float)Math.Pow(altura, 2);
                    Console.WriteLine("\nSeu IMC é:{0} ", imc);

                    if ((sexo == 'F') || (sexo == 'f'))
                    {
                        if (imc < 19.1)
                        {
                            Console.WriteLine("\nPeso Abaixo do ideal.");
                        }
                        else if ((imc >= 19.1) && (imc <= 25.8))
                        {
                            Console.WriteLine("\nPeso Ideal.");
                        }
                        else if (imc <= 32.3)
                        {
                            Console.WriteLine("\nPeso acima do Ideal.");
                        }
                        else
                        {
                            Console.WriteLine("\nPeso muito acima do Ideal.");
                        }
                    }
                    if ((sexo == 'M') || (sexo == 'm'))
                    {
                        if (imc < 20.7)
                        {
                            Console.WriteLine("\nPeso Abaixo do ideal.");
                        }
                        else if ((imc >= 20.7) && (imc <= 26.4))
                        {
                            Console.WriteLine("\nPeso Ideal.");
                        }
                        else if (imc <= 31.1)
                        {
                            Console.WriteLine("\nPeso acima do Ideal.");
                        }
                        else
                        {
                            Console.WriteLine("\nPeso muito acima do Ideal.");
                        }
                    }
                    Console.WriteLine("\nDeseja Calcular o IMC Novamente ?\nDigite [s] p/ SIM\nDigite [n] p/ NAO. ");
                    resp = char.Parse(Console.ReadLine());
                } while (resp == 's' || resp == 's');

                Console.WriteLine("\n\tPressione qualquer tecla p/ finalizar.");
                Console.ReadKey();
              }
           }
        }
    }
