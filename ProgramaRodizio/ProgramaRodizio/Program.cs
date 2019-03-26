using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaRodizio
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.WriteLine("Rodizio de veiculos em São Paulo\n");
                Console.WriteLine("O número 99 Encerra o programa");
                Console.Write("Digite o final da sua placa: ");                              
                while (!(int.TryParse(Console.ReadLine(), out opcao)))
                    Console.Write("Final de placa incorreto! Digite novamente: ");
                switch (opcao)
                {
                    case 1:
                    case 2:
                        Console.WriteLine("Seu Rodizio é Segunda-Feira");
                        break;
                    case 3:
                    case 4:
                        Console.WriteLine("Seu rodizio é Terça-Feira");
                        break;
                    case 5:
                    case 6:
                        Console.WriteLine("Seu rodizio é Quarta-Feita");
                        break;
                    case 7:
                    case 8:
                        Console.WriteLine("Seu rodizio é Quinta-Feira");
                        break;
                    case 9:
                    case 0:
                        Console.WriteLine("Seu rodizio é Sexta-Feira");
                        break;
                    case 99:
                        Console.WriteLine("Sistema será encerrado");
                        break;
                    default:
                        Console.WriteLine("O número final da placa é inválido");
                        break;
                }//fim do switch
                Console.Write("Pressione qualquer tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            } while (opcao != 99);         
        }
    }
}
