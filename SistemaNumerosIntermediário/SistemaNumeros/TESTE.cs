ï»¿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
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
            Console.ForegroundColor = ConsoleColor.Green;
            do
            {
                Console.WriteLine(" _____________________________");
                Console.WriteLine("|                             |");
                Console.WriteLine("|      SISTEMA NÃMEROS        |");
                Console.WriteLine("|                             |");
                Console.WriteLine("| Menu de opÃ§Ãµes:             |");
                Console.WriteLine("|                             |");
                Console.WriteLine("| 1. Gera NÃºmeros Pares       |");
                Console.WriteLine("| 2. Gera NÃºmeros Impares     |");
                Console.WriteLine("| 3. Gera NÃºmeros Multiplos   |");
                Console.WriteLine("| 4. Lista NÃºmeros Gerados    |");
                Console.WriteLine("| 5. Testa NÃºmero Primo       |");
                Console.WriteLine("| 6. Gera NÃºmeros Primos      |");
                Console.WriteLine("| 7. Gera Palpite Megasena    |");
                Console.WriteLine("| 8. Gera NÃºmeros AleatÃ³rios  |");
                Console.WriteLine("| 0. Encerra este Sistema     |");
                Console.WriteLine("|_____________________________|\n");
                Console.Write("  Digite a opÃ§Ã£o desejada: ");
                while (!(int.TryParse(Console.ReadLine(), out opcao)))
                    Console.Write("OpÃ§Ã£o nÃ£o numÃ©rica. Digite opÃ§Ã£o desejada: ");
                Console.WriteLine("\n");
                switch (opcao)
                {
                    case 1:
                        vetor = GeraPares();
                        aleatorio = false;
                        break;
                    case 2:
                        vetor = GeraImpares();
                        aleatorio = false;
                        break;
                    case 3:
                        vetor = GeraMultiplos();
                        aleatorio = false;
                        break;
                    case 4:
                        aux = Lista(vetor, aleatorio);
                        Console.WriteLine("\n\nForam listados " + aux + " nÃºmeros.");
                        break;
                    case 5:
                        aleatorio = false;
                        Console.Write("Qual nÃºmero deseja testar se Ã© primo? ");
                        while (!(int.TryParse(Console.ReadLine(), out num)))
                            Console.Write("NÃºmero invÃ¡lido! Digite um nÃºmero inteiro para testar: ");
                        aux = TestaPrimo(num);
                        if (aux == 0)
                            Console.WriteLine("O nÃºmero {0} Ã© primo, pois sÃ³ Ã© divisÃ­vel por 1 e por ele mesmo.", num);
                        else
                            Console.WriteLine("O nÃºmero {0} nÃ£o Ã© primo, pois Ã© divisÃ­vel por {1}, alÃ©m de outros.", num, aux);
                        break;
                    case 6:
                        vetor = GeraPrimos();
                        aleatorio = false;
                        break;
                    case 7:
                        vetor = GeraSena();
                        aleatorio = true;
                        break;
                    case 8:
                        vetor = GeraAleatorios();
                        aleatorio = true;
                        break;
                    case 0:
                        Console.WriteLine("Sistema serÃ¡ encerrado");
                        break;
                    default:
                        Console.WriteLine("OpÃ§Ã£o inexistente!");
                        break;
                }//fim do switch
                Console.Write("Pressione qualquer tecla para prosseguir");
                Console.ReadKey();
                Console.Clear();
            } while (opcao != 0);
        }
        static int[] GeraPares()
        {
            int i, qtd, num, tam = 10000;
            int[] vetorAux = new int[tam];
            bool paradinha = true;
            Console.Clear();
            Console.WriteLine("Sistema NÃºmeros\n\nGeraÃ§Ã£o de nÃºmeros pares:\n");
            Console.Write("Quanto nÃºmeros pares listar? ");
            while (!(int.TryParse(Console.ReadLine(), out qtd)))
                Console.Write("Quantidade invÃ¡lida! Digite quantidade desejada: ");
            if (qtd > 9999)
            {
                Console.WriteLine("Para que nÃ£o haja estouro do vetor, o limite mÃ¡ximo Ã© 9999! Esse serÃ¡ a quantidade assumida.");
                qtd = 9999;
            }
            for (i = 1; i < tam; i++) // Limpa vetor
                vetorAux[i] = 0;
            i = 1;
            while (i <= qtd)
            {
                num = i * 2;
                paradinha = Listar(num, i, paradinha);
                vetorAux[i] = num;
                i++; // i = i + 1;
            }
            Console.WriteLine("\n");
            return vetorAux;
        }
        static int[] GeraImpares()
        {
            int i, qtd, num, tam = 10000;
            int[] vetorAux = new int[tam];
            bool paradinha = true;
            Console.Clear();
            Console.WriteLine("Sistema NÃºmeros\n\nGeraÃ§Ã£o de nÃºmeros impares:\n");
            Console.Write("Quanto nÃºmeros impares listar? ");
            while (!(int.TryParse(Console.ReadLine(), out qtd)))
                Console.Write("Quantidade invÃ¡lida! Digite quantidade desejada: ");
            if (qtd > 9999)
            {
                Console.WriteLine("Para que nÃ£o haja estouro do vetor, o limite mÃ¡ximo Ã© 9999! Esse serÃ¡ a quantidade assumida.");
                qtd = 9999;
            }
            for (i = 1; i < tam; i++) // Limpa vetor
                vetorAux[i] = 0;
            i = 0;
            do
            {
                num = i * 2 + 1;
                i++;
                paradinha = Listar(num, i, paradinha);
                vetorAux[i] = num;
            } while (i < qtd);
            Console.WriteLine("\n");
            return vetorAux;
        }
        static int[] GeraMultiplos()
        {
            int aux, num, i, qtd, tam = 10000;
            int[] vetorAux = new int[tam];
            bool paradinha = true;
            Console.Clear();
            Console.WriteLine("Sistema NÃºmeros\n\nGeraÃ§Ã£o de nÃºmeros multiplos:\n");
            Console.Write("Multiplo de qual nÃºmero inteiro? ");
            while (!(int.TryParse(Console.ReadLine(), out aux)))
                Console.Write("NÃ£o Ã© um nÃºmero inteiro! Digite nÃºmero inteiro do qual deseja gerar multiplos: ");
            Console.Write("Quanto nÃºmeros multiplos listar? ");
            while (!(int.TryParse(Console.ReadLine(), out qtd)))
                Console.Write("Quantidade invÃ¡lida! Digite quantidade desejada: ");
            if (qtd > 9999)
            {
                Console.WriteLine("Para que nÃ£o haja estouro do vetor, o limite mÃ¡ximo Ã© 9999! Esse serÃ¡ a quantidade assumida.");
                qtd = 9999;
            }
            for (i = 1; i < tam; i++) // Limpa vetor
                vetorAux[i] = 0;
            for (i = 1; i <= qtd; i++)
            {
                num = i * aux;
                paradinha = Listar(num, i, paradinha);
                vetorAux[i] = num;
            }
            Console.WriteLine("\n");
            return vetorAux;
        }
        static int Lista(int[] vetor, bool aleatorio)
        {
            int i, j, aux, tam = 10000;
            Stopwatch gasto = new Stopwatch();
            string decorrido;
            bool paradinha = true;
            Console.Clear();
            Console.WriteLine("Sistema NÃºmeros\n\nListagem:\n");
            if (vetor[1] == 0) // nÃ£o tem nada para ser listado
            {
                Console.WriteLine("NÃ£o tem nada para ser listado! Listagem serÃ¡ encerrada.");
                return 0;
            }
            if (aleatorio)
            { // rotina para ordenar a lista de nÃºmeros - sort
                Console.WriteLine("Como trata-se de uma lista desordenada, neste momento inicia-se a ordenaÃ§Ã£o.\n");
                gasto.Start();
                for (i = 1; i < tam && vetor[i] != 0; i++)
                    for (j = i; j < tam && vetor[j] != 0; j++)
                        if (vetor[i] > vetor[j])
                        {
                            aux = vetor[i];
                            vetor[i] = vetor[j];
                            vetor[j] = aux;
                        }
                gasto.Stop();
                TimeSpan ts = gasto.Elapsed;
                decorrido = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                Console.WriteLine("Tempo gasto no sort: " + decorrido);
            }
            for (i = 1; i < tam && vetor[i] != 0; i++)
                paradinha = Listar(vetor[i], i, paradinha);
            return i - 1;
        }
        static bool Listar(int x, int pos, bool paradinha)
        {
            char tecla;
            if (pos == 1) { Console.Write("Linha {0:0000}:\t", pos); paradinha = true; }
            if (pos % 10 == 0)
            {
                Console.Write("{0}\n", x);
                if (pos % 100 == 0)
                    if (paradinha)
                    {
                        Console.Write("\nDeseja dar uma paradinha a cada 10 linhas listadas?(Digite n para nÃ£o): ");
                        tecla = Console.ReadKey().KeyChar;
                        if (tecla == 'n' || tecla == 'N') paradinha = false; else paradinha = true;
                        Console.Write("\nLinha {0:0000}:\t", (pos / 10 + 1));
                    }
                    else
                        Console.Write("Linha {0:0000}:\t", (pos / 10 + 1));
                else
                    Console.Write("Linha {0:0000}:\t", (pos / 10 + 1));
            }
            else
                Console.Write("{0}\t", x);
            return paradinha;
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
        static int[] GeraPrimos()
        {
            int i, j = 1, qtd, tam = 10000;
            int[] vetorAux = new int[tam];
            bool paradinha = true;
            Console.Clear();
            Console.WriteLine("Sistema NÃºmeros\n\nGeraÃ§Ã£o de nÃºmeros primos:\n");
            Console.Write("Quanto nÃºmeros primos listar? ");
            while (!(int.TryParse(Console.ReadLine(), out qtd)))
                Console.Write("Quantidade invÃ¡lida! Digite quantidade desejada: ");
            if (qtd > 9999)
            {
                Console.WriteLine("Para que nÃ£o haja estouro do vetor, o limite mÃ¡ximo Ã© 9999! Esse serÃ¡ a quantidade assumida.");
                qtd = 9999;
            }
            for (i = 1; i < tam; i++) // Limpa vetor
                vetorAux[i] = 0;
            for (i = 1; i <= qtd; i++)
            {
                while (TestaPrimo(j) > 0)
                {
                    j++;
                }
                paradinha = Listar(j, i, paradinha);
                vetorAux[i] = j;
                j++;
            }
            Console.WriteLine("\n");
            return vetorAux;
        }
        static int[] GeraSena()
        {
            Random numAleatorio = new Random();
            int i, num, qtd, tam = 10000;
            int[] vetorAux = new int[tam];
            bool paradinha = true;
            Console.Clear();
            Console.WriteLine("Sistema NÃºmeros\n\nGeraÃ§Ã£o de dezenas para Megasena:\n");
            Console.Write("Quantas dezenas listar (de 6 a 15)? ");
            while (!(int.TryParse(Console.ReadLine(), out qtd)))
                Console.Write("Quantidade invÃ¡lida! Digite quantidade desejada: ");
            if (qtd > 60)
            {
                Console.WriteLine("Para que nÃ£o haja repetiÃ§Ã£o, o limite mÃ¡ximo Ã© 60! Esse serÃ¡ a quantidade assumida.");
                qtd = 60;
            }
            for (i = 1; i < tam; i++) // Limpa vetor
                vetorAux[i] = 0;
            for (i = 1; i <= qtd; i++)
            {
                num = numAleatorio.Next(1, 61);
                while (repetido(num, vetorAux, i))
                    num = numAleatorio.Next(1, 61);
                paradinha = Listar(num, i, paradinha);
                vetorAux[i] = num;
            }
            Console.WriteLine("\n\nUma aposta com {0} dezenas custa R$ {1}.", qtd, QuantoCustara(qtd));
            Console.WriteLine("\n");
            return vetorAux;
        }
        static bool repetido(int num, int[] vetor, int i)
        {
            int j;
            bool resp = false;
            for (j = 1; j < i; j++)
                if (num == vetor[j])
                {
                    j = i;
                    resp = true;
                }
            return resp;
        }
        static string QuantoCustara(int num)
        {
            string valor;
            switch (num)
            {
                case 6:
                    valor = "3,50";
                    break;
                case 7:
                    valor = "24,50";
                    break;
                case 8:
                    valor = "98,00";
                    break;
                case 9:
                    valor = "294,00";
                    break;
                case 10:
                    valor = "735,00";
                    break;
                case 11:
                    valor = "1.617,00";
                    break;
                case 12:
                    valor = "3.234,00";
                    break;
                case 13:
                    valor = "6.006,00";
                    break;
                case 14:
                    valor = "10.510,50";
                    break;
                case 15:
                    valor = "17.517,50";
                    break;
                default:
                    valor = "? (nÃ£o Ã© possÃ­vel aposta com essa quantidade de dezenas)";
                    break;
            }
            return valor;
        }
        static void Tempo(string[] args)
        {
            Stopwatch gasto = new Stopwatch();
            gasto.Start();
            Thread.Sleep(10000);
            gasto.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = gasto.Elapsed;

            // Format and display the TimeSpan value.
            string decorrido = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("Tempo gasto: " + decorrido);
        }
        static int[] GeraAleatorios()
        {
            Random numAleatorio = new Random();
            int i, num, qtd, tam = 10000, max;
            int[] vetorAux = new int[tam];
            bool paradinha = true;
            Console.Clear();
            Console.WriteLine("Sistema NÃºmeros\n\nGeraÃ§Ã£o de nÃºmeros aleatÃ³rios:\n");
            Console.Write("Quantas nÃºmeros listar (mÃ¡ximo 9.999)? ");
            while (!(int.TryParse(Console.ReadLine(), out qtd)))
                Console.Write("Quantidade invÃ¡lida! Digite quantidade desejada: ");
            if (qtd > 9999)
            {
                Console.WriteLine("Para que nÃ£o haja estouro do vetor, o limite mÃ¡ximo Ã© 9999! Esse serÃ¡ a quantidade assumida.");
                qtd = 9999;
            }
            Console.Write("Gerar nÃºmeros de 1 atÃ© quanto? (mÃ¡ximo 9.999.999): ");
            while (!(int.TryParse(Console.ReadLine(), out max)))
                Console.Write("Quantidade invÃ¡lida! Digite quantidade vÃ¡lida: ");
            if (max > 9999999)
            {
                Console.WriteLine("Para respeitar o limite mÃ¡ximo, este serÃ¡ 9999999!");
                max = 9999999;
            }
            for (i = 1; i < tam; i++) // zerando todas cÃ©lulas do vetor
                vetorAux[i] = 0;
            //Console.Write("Quantas nÃºmeros listar (mÃ¡ximo 9.999)? ");
            for (i = 1; i <= qtd; i++)
            {
                num = numAleatorio.Next(1, max);
                while (repetido(num, vetorAux, i))
                    num = numAleatorio.Next(1, max);
                paradinha = Listar(num, i, paradinha);
                vetorAux[i] = num;
            }
            Console.WriteLine("\n");
            return vetorAux;
        }
    }
}