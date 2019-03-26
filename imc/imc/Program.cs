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
                char sexo, resp;
                float peso, altura, imc, ideal1, ideal2;               
                do
                {
                    Console.WriteLine("Calcula o indice de massa corporal e diz peso ideal.");                  
                    Console.Write("\nDigite [F] para feminino\nDigite [M] para masculino: "); sexo = char.Parse(Console.ReadLine());
                    while ((sexo != 'F') && (sexo != 'f') && (sexo != 'M') && (sexo != 'm'))
                    {
                        Console.Write("Sexo inválido! Digite M para masculino ou F para feminino: "); sexo = char.Parse(Console.ReadLine());
                    }

                    Console.Write("\nDigite a altura em metros: "); 
                    while (!(float.TryParse(Console.ReadLine(), out altura)))
                        Console.Write("Altura não é numerica  Digite a Altura corretamente: "); 
                    Console.Write("\nDigite o peso em quilos:  ");
                    while (!(float.TryParse(Console.ReadLine(), out peso)))                   
                        Console.Write("Peso  não é numérico! Digite o Peso corretamente: "); 
                    imc = peso / (float)Math.Pow(altura, 2);
                    Console.WriteLine("\nSeu IMC é: {0}", imc);

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
                        ideal1 = (float)19.1 * (altura * altura);
                        ideal2 = (float)25.8 * (altura * altura);
                        Console.WriteLine("\nSeu Peso ideal seria de: {0:N3} até {1:N3}", ideal1, ideal2);
                    }
                    else
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
                        ideal1 =  (float)20.7 * altura * altura;
                        ideal2 = (float)26.4 * altura * altura;
                        Console.WriteLine("\nSeu Peso ideal seria de: {0:N2} até {1:N2}", ideal1, ideal2);
                    }
                    Console.WriteLine("\nDeseja Calcular o IMC Novamente ?\nDigite [s] p/ SIM\nDigite [n] p/ NAO. ");
                    resp = char.Parse(Console.ReadLine());
                } while (resp == 's' || resp == 's' || resp == 'S');
                Console.WriteLine("\n\tPressione qualquer tecla p/ finalizar.");
                Console.ReadKey();
            }
        }
    }
}

