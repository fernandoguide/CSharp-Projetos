using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolar, euro, valor;
            int opcao;



            Console.WriteLine("Converte Reais para Dolar ou Euro");

            Console.Write("Qual montante de reais para Converter: ");
            valor = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o numero [0] para Dolar, demais numeros igual a Euros.");
            Console.Write("\nSua Escolha:  ");
            opcao = int.Parse(Console.ReadLine());

            euro = (valor / 3.36);
            dolar = (valor / 3.115);

            Console.WriteLine(opcao == 0 ? ("Os R$ " + valor + " corresponde a US$: {0:N2}") : ("Os R$ " + valor + " corresponde a Euros$: {1:N2}"), dolar, euro);

            Console.WriteLine("Pressione qualquer tecla para finalizar.");

            Console.ReadKey();
        }
    }
}
