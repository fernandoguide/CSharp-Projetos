using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            
                Console.WriteLine("Programa números inteiros.");
                Console.WriteLine("-------------------------\n\n");

                Console.Write("\nDigite um número: ");
                num = int.Parse(Console.ReadLine());

                    
                for (int n = num+1; n <= num+15; n++)
                {

                    Console.WriteLine("\nOs números inteiros são:{0} ", n);
                }

                Console.WriteLine("\nO maior numero digitado foi {0} ", num+15);
         
            Console.WriteLine("\nPressione qualquer tecla para finalizar.");
            Console.ReadKey();
        }
    }
}
