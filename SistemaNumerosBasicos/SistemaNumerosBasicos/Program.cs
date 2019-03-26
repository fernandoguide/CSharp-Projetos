using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNumerosIntermediario
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao, aux, num;
            do
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("\n\n");
                Console.WriteLine("\t\t\t\t\t _______________________________");
                Console.WriteLine("\t\t\t\t\t|                               |");
                Console.WriteLine("\t\t\t\t\t|       SISTEMA NÚMEROS         |");
                Console.WriteLine("\t\t\t\t\t|                               |");
                Console.WriteLine("\t\t\t\t\t|   Menu de Opçoes:             |");
                Console.WriteLine("\t\t\t\t\t|                               |");
                Console.WriteLine("\t\t\t\t\t|1. Gera números Pares          |");
                Console.WriteLine("\t\t\t\t\t|2. Gera números Impares        |");
                Console.WriteLine("\t\t\t\t\t|3. Gera números Multiplos      |");
                Console.WriteLine("\t\t\t\t\t|4. Lista numeros Gerados       |");
                Console.WriteLine("\t\t\t\t\t|5. Testa numeros Primo         |");
                Console.WriteLine("\t\t\t\t\t|6. Gera Números Primos         |");
                Console.WriteLine("\t\t\t\t\t|0. Para encerrar o Sistema     |");
                Console.WriteLine("\t\t\t\t\t|_______________________________|");
                Console.Write("\n\n\nDigite a opção desejada: ");
                while (!(int.TryParse(Console.ReadLine(), out opcao)))
                    Console.Write("\nOpção não numérica. Digite opção desejada: ");
                Console.WriteLine("\n");
                switch (opcao)
                {
                    case 1:
                        GeraPares();
                        break;
                    case 2:
                        GeraImpares();
                        break;
                    case 3:
                        aux = GeraMultiplos();
                        //Console.WriteLine("\nRetornou que será multiplo de " + aux);
                        break;
                    case 4:
                        Lista();
                        break;
                    case 5:
                        Console.Write("Qual número deseja testar se é primo? ");
                        while (!(int.TryParse(Console.ReadLine(), out num)))
                            Console.Write("Número inválido! Digite um número inteiro para testar: ");
                        aux = TestaPrimo(num);
                        if (aux == 0)
                            Console.WriteLine("O número {0} é primo, pois só é divisível por 1 e por ele mesmo.", num);
                        else
                            Console.WriteLine("O número {0} não é primo, pois é divisível por {1}, além de outros.", num, aux);
                        break;
                    case 6:
                        GeraPrimos();
                        break;
                    case 0:
                        Console.WriteLine("\nSistema será encerrado");
                        break;
                    default:
                        Console.WriteLine("\nOpção inexistente!");
                        break;
                }//fim do switch
                Console.Write("\nPressione qualquer tecla para prosseguir");
                Console.ReadKey();
                Console.Clear();
            } while (opcao != 0);
        }
        static void GeraPares()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            int i, qtd, num;
            Console.Clear();
            Console.WriteLine("Sistema Números\n\nGeração de números pares:\n");
            Console.Write("Quanto números pares listar? ");
            while (!(int.TryParse(Console.ReadLine(), out qtd)))
                Console.Write("Quantidade inválida! Digite quantidade desejada: ");
            i = 1;
            while (i <= qtd)
            {
                num = i * 2;
                Listar(num, i);
                i++; // i = i + 1;
            }
            Console.WriteLine("\n");
        }
        static void GeraImpares()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int i, qtd, num;
            Console.Clear();
            Console.WriteLine("Sistema Números\n\nGeração de números impares:\n");
            Console.Write("Quanto números impares listar? ");
            while (!(int.TryParse(Console.ReadLine(), out qtd)))
                Console.Write("Quantidade inválida! Digite quantidade desejada: ");
            i = 0;
            do
            {
                num = i * 2 + 1;
                i++;
                Listar(num, i);
            } while (i < qtd);
            Console.WriteLine("\n");
        }
        static int GeraMultiplos()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int aux, num, i, qtd;
            Console.Clear();
            Console.WriteLine("Sistema Números\n\nGeração de números multiplos:\n");
            Console.Write("Multiplo de qual número inteiro? ");
            while (!(int.TryParse(Console.ReadLine(), out aux)))
                Console.Write("Não é um número inteiro! Digite número inteiro do qual deseja gerar multiplos: ");
            Console.Write("Quanto números multiplos listar? ");
            while (!(int.TryParse(Console.ReadLine(), out qtd)))
                Console.Write("Quantidade inválida! Digite quantidade desejada: ");
            for (i = 1; i <= qtd; i++)
            {
                num = i * aux;
                Listar(num, i);
            }
            return aux;
        }
        static void Lista()
        {
            Console.Clear();
            Console.WriteLine("Sistema Números\n\nListagem:\n");
        }
        static void Listar(int x, int pos)
        {
            if (pos % 10 == 0)
                Console.WriteLine("{0}", x);
            else
                Console.Write("{0}\t", x);
        }
        static int TestaPrimo(int num)
        {
            Console.ForegroundColor = ConsoleColor.White;
            int i, div = 0;
            for (i = 2; i <= num / 2; i++)
                if (num % i == 0)
                {
                    div = i;
                    i = num;
                }
            return div;
        }
        static void GeraPrimos()
        {

        }
    }
}
