using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo2metodo
{
    class Program
    {
        static void Main(string[] args)
        {
            int t;
            string p;
            digite();
            p = Console.ReadLine();
            t = tamanho(p);
            Console.WriteLine("\n{0} possui {1} caracteres", p, t);
            Console.WriteLine("\n\nPressione alguma tecla.");
            Console.ReadKey();
        }
        static void digite()
        {
            Console.Write("Digite uma palavra: ");
        }
        static int tamanho(string x)
        {
            return x.Length;
        }
    }
}
