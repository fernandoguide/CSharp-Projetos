
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SistemaNumerosIntermediario
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao, aux, num;
            const int tam = 10000;
            int[] vetor = new int[tam];
            bool aleatorio = false;

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
                Console.WriteLine("\t\t\t\t\t|7. Gera Palpites p/ Mega Sena  |");
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
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.WriteLine("Sistema Números\n\n *** TESTA SE O NÚMERO É PRIMO ***\n");                      
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
                    case 7:
                        MegaSena();
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
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            int i=1, qtd, num;
            Console.Clear();
            Console.WriteLine("Sistema Números\n\n *** Geração de números pares *** \n");
            Console.Write("Quanto números pares listar? ");
            while (!(int.TryParse(Console.ReadLine(), out qtd)))
                Console.Write("Quantidade inválida! Digite quantidade desejada: ");        
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
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            int i=0, qtd, num;
            Console.Clear();
            Console.WriteLine("Sistema Números\n\n *** Geração de números impares ***\n");
            Console.Write("Quanto números impares listar? ");
            while (!(int.TryParse(Console.ReadLine(), out qtd)))
                Console.Write("Quantidade inválida! Digite quantidade desejada: ");
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
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            int aux, num, i, qtd;
            Console.Clear();
            Console.WriteLine("Sistema Números\n\n *** Geração de números multiplos ***\n");
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
        public static bool Lista(int x, int pos, bool paradinha)
        {
            char tecla;
            if (pos == 1) { Console.Write("Linha {0:0000}:\t", pos); paradinha = true; }
            if (pos % 10 == 0)
            {
                Console.Write("{0}\n", x);
                if (pos % 100 == 0)
                {
                    if (paradinha)
                    {
                        Console.Write("\nDeseja dar uma paradinha a cada 10 linhas listadas?(Digite [N] p/ Não ou qualquer tecla para continuar");
                        while (!(char.TryParse(Console.ReadLine(), out tecla)))
                            if (tecla == 'n' || tecla == 'N') paradinha = false; else paradinha = true;
                        Console.Write("\nLinha{0:0000}\t", (pos / 10 + 1));
                    }
                    else
                        Console.Write("Linha {0:0000}:\t", (pos / 10 + 1));
                }
                else
                    Console.Write("Linha {0:0000}:\t", (pos / 10 + 1));
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Sistema Números\n\nListagem:\n");
            }
            return paradinha;
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
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Magenta;
            int i,num=1,qtd;
            Console.Clear();
            Console.WriteLine("Sistema Números\n\n *** GERA NUMEROS PRIMOS ***\n");
            Console.Write("Quanto números Primos deseja listar? ");
                while (!(int.TryParse(Console.ReadLine(), out qtd)))
                Console.Write("\nNão é um número inteiro! Digite número inteiro do qual deseja gerar Primos: ");
                for (i = 1; i <= qtd; i++)
                {                   
                    while (TestaPrimo(num) > 0)                   
                        num++;                  
                        Listar(num, i);
                        num++;
                }                                        
        }
        static void MegaSena()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Random dezenas = new Random();
            int num,i;
            Console.Clear();
            Console.WriteLine("Sistema Números\n\n *** Sorteio da MEGA SENA ***\n");
            Console.WriteLine("Os numeros Gerados da Mega Sena são:");
            for (i = 1; i <=6; i++)
            {
                num = dezenas.Next(60);
                Thread.Sleep(1000);              
                Listar(num, i);
             
            }
        }         