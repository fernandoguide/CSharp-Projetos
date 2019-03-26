using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = 0, n;
            do
            {
                Console.WriteLine("\n Se deseja encerrar o programa digite 0.");
                Console.Write("\nDigite um numero: ");
                
                n = int.Parse(Console.ReadLine());  
               if (n != 0)
                    q++;
                
            } while (n!=0);
                Console.WriteLine("\nForam digitados {0} numeros inteiros", q);
                Console.WriteLine("\n\n Pressione qualquer tecla para contunar");
                Console.ReadKey();
        }
    }
}
