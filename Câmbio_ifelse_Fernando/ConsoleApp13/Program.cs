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
            double dolar, euro, valor;
            int num_menu; 
           
            
            Console.WriteLine("\nCalcula o cambio de Reais para Dolar ou Euro");
            Console.WriteLine("**********************************************\n\n");
       
            Console.WriteLine("Para qual moeda deseja converter? Aperte ENTER e escolha um número e confirme com ENTER novamente.");
            Console.ReadLine();
            Console.Write("\nReal P/ Dólar digite [1]");
            Console.Write("\nReal P/ Euro digite  [2] ");
            Console.WriteLine(); num_menu = int.Parse(Console.ReadLine());


            if (num_menu == 1)
            {
                Console.WriteLine("Você escolheu Real P/ Dólar");
                Console.Write("\nInsira um valor: ");
                valor = double.Parse(Console.ReadLine());
                dolar = (valor / 3.115);
                Console.WriteLine("Os R$ {1:N2} Corresponde a US$ {0:N2}", dolar,valor);

            }
            else if (num_menu == 2)
            {
                Console.WriteLine("Você escolheu Real P/ Euro");
                Console.Write("\nInsira um valor: ");
                valor = double.Parse(Console.ReadLine());
                euro = (valor / 3.36);
                Console.WriteLine("Os R$ {1:N2} Corresponde a Euro$ {0:N2}", euro,valor);
                
            }
            Console.WriteLine("Pressione qualquer tecla para finalizar");

            Console.ReadKey();
         
        }


    }

}
