using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rodizio
{
    class Program
    {
        static void Main(string[] args)
        {
            int placa;
            string aux;
            bool erro;
            Console.WriteLine("Apresenta o dia de rodízio no Centro Expandido de São Paulo");
            do
            {
                Console.Write("\nInforme o dígito final da placa do veículo (ou digite 99 para encerrar este programa): ");
                aux = Console.ReadLine();
                do
                {
                    if (int.TryParse(aux, out placa))
                        if ((placa < 0) || ((placa > 9) && (placa != 99)))
                            erro = true;
                        else
                            erro = false;
                    else
                        erro = true;
                    if (erro)
                    {
                        Console.Write("Placa inválida! Digite o número final da placa do veículo: ");
                        aux = Console.ReadLine();
                    }
                } while (erro);
                switch (placa)
                {
                    case 1:
                    case 2:
                        Console.WriteLine("Veículos de final 1 e 2 não circulam às segundas-feira.");
                        break;
                    case 3:
                    case 4:
                        Console.WriteLine("Veículos de final 3 e 4 não circulam às terças-feira.");
                        break;
                    case 5:
                    case 6:
                        Console.WriteLine("Veículos de final 5 e 6 não circulam às quartas-feira.");
                        break;
                    case 7:
                    case 8:
                        Console.WriteLine("Veículos de final 7 e 8 não circulam às quintas-feira.");
                        break;
                    case 9:
                    case 0:
                        Console.WriteLine("Veículos de final 9 e 0 não circulam às sextas-feira.");
                        break;

                }
            } while (placa != 99);
            Console.Write("Obrigado por utilizar o programa Rodízio! - pressione qualquer tecla para encerrar: ");
            Console.ReadKey();
        }
    }
}
