using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int op, n;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Par/impar");
                Console.WriteLine("2 - Decrescente ate 0 (Zero)");
                Console.WriteLine("3 - Sair");
                Console.Write("\nInforme a opçao desejada: "); op =int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Write("Digite um numero: "); n = int.Parse(Console.ReadLine());
                        Console.WriteLine(n + "é" + (n % 2 == 0 ? " par." : " impar."));
                        break;    
                    case 2:
                        Console.Write("Digite um numero: "); n = int.Parse(Console.ReadLine());
                        while (n >= 0)
                            Console.Write("{0} ", n--);
                        break;
                    case 3:
                        Console.WriteLine("Fim da execuçao do programa");
                        break;
                    default:
                        Console.WriteLine("Opçao invalida - tente novamente");
                        break;
                }
                Console.WriteLine("\n Pressione qualquer tecla p/ continuar");
                Console.ReadKey();
            } while (op != 3);
        }
    }
}
