using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            int opcao;

            Console.WriteLine("\t\t\t\tConverte Reais para Dolar ou Euro\n\n");
            Console.Write("Qual montante de Reais deseja Converter: ");
            valor = double.Parse(Console.ReadLine());
            Console.Write("\nDigite [1] p/ Dolar");
            Console.Write("\nDigite [0] p/ Euro ");
            Console.Write("\nSua Escolha  ");
            opcao = int.Parse(Console.ReadLine());
            Console.WriteLine(opcao == 1 ? ("Os R$: " + valor + " corresponde a US$: " + (valor / 3.115)) : ("Os R$: " + valor + " corresponde a Euros$: ") + (valor / 3.36));
            Console.WriteLine("\nPressione qualquer tecla para finalizar.");
            Console.ReadKey();
        }
    }
}
