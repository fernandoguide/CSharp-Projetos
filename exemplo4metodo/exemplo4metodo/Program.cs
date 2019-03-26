using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo4metodo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Entre com numero: "); num = int.Parse(Console.ReadLine());

            if (RestoPorDois(num) == 0)
                Console.WriteLine("\n\nO numero é par.\n");
            else
                Console.WriteLine("\n\nO numero é impar.\n");
            Console.ReadKey();
        }
        static int RestoPorDois(int a)
        {
            return a % 2;
        }
    }
}
