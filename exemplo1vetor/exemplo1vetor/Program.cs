using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo1vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            int i;

            for (i = 0; i<10; i++)
            {
                Console.Write("Digite o {0}º nome: ", i + 1);
                nomes[i] = Console.ReadLine();
            }
            Console.WriteLine();

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(" {0}º nome: {1} ", i + 1, nomes[i]);
            }
            Console.ReadKey();
               
        }
    }
}
