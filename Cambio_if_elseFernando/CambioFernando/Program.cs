using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cambio

{
    class Program
    {
        static void Main(string[] args)
        {
            double dolar, euro, valor, quest;
            int num_menu;
            do
            {
                Console.WriteLine("\n\n\t\tConverte  Reais p/ Dolar ou Euro");
                Console.WriteLine("\n\n\nEscolha para qual moeda deseja converter?");
                Console.Write("\nReal P/ Dólar digite [1]");
                Console.Write("\nReal P/ Euro digite  [2]");
                Console.WriteLine(); num_menu = int.Parse(Console.ReadLine());

                if (num_menu == 1) ;
                {
                    Console.WriteLine("Você escolheu Real P/ Dólar");
                    Console.Write("\nInsira um valor: ");
                    valor = double.Parse(Console.ReadLine());
                    dolar = (valor / 3.115);
                    Console.WriteLine("Os R$ {1:N2} Corresponde a US$ {0:N2}", dolar, valor);
                }
                else (num_menu == 2);
                {
                    Console.WriteLine("Você escolheu Real P/ Euro");
                    Console.Write("\nInsira um valor: ");
                    valor = double.Parse(Console.ReadLine());
                    euro = (valor / 3.36);
                    Console.WriteLine("Os R$ {1:N2} Corresponde a Euro$ {0:N2}", euro, valor);
                }

                Console.WriteLine("\nDeseja Converter Reias em Dolars ou Euros novamente?");
                Console.Write("\n[1] - SIM");
                Console.Write("\n[0]- NÂO");
                Console.Write("\n Sua Escolha: ");
                quest = float.Parse(Console.ReadLine());
            }
            while (quest != 0);
            Console.WriteLine("\n\n************* Feito por Fernando Oliveira ***************\n\n");
            Console.ReadKey();
        }
    }
}
