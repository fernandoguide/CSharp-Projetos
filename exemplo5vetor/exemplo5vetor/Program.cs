using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo5vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            const int tam = 10;
            string[] times = new string[tam];

            Console.WriteLine("*** Times de Futebol ***\n");

            //Atribuição do calculo no vetor salarios
            for (i = 0; i < tam; i++)
            {
                Console.Write("Nome do {0}º Time:  ", i + 1);
                times[i] = Console.ReadLine();
            }
            Console.WriteLine("\n ** Times Cadastrados no Vetor *** \n");
            exibirdados(times);
            Console.ReadKey();
        }
        static void exibirdados(string[] t)
        {
            //Exibição dos dados do Vetor
            for (int x = 0; x < t.Length; x++)
                Console.WriteLine("{0}º Time: {1}", x + 1, t[x]);
        }   
    }
}
