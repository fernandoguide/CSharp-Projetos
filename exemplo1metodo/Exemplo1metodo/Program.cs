using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1metodo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            digite();
            a = int.Parse(Console.ReadLine());
            dobro(a);
            Console.WriteLine("\n\nPressinoe alguma tecla.");
            Console.ReadKey();
        }
        static void digite()
        {
            Console.Write("Digite um numero: ");
        }
        static void dobro(int n)
        {
            int d = n * 2;
            Console.WriteLine("Dobro de {0} = {1}", n, d);
        }
    }
}
