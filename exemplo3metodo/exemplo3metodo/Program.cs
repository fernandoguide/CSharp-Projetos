using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo3metodo
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade1, idade2;
            string nome1, nome2;
            Console.Write("Digite o nome da 1° pessoa: "); nome1 = Console.ReadLine();
            Console.Write("Digite a idade da 1° pessoa: "); idade1 =int.Parse(Console.ReadLine());

            Console.Write("Digite o nome da 2° pessoa: "); nome2 = Console.ReadLine();
            Console.Write("Digite a idade da 2° pessoa: "); idade2 = int.Parse(Console.ReadLine());

            string texto = PessoaMaisVelha(nome1, idade1, nome2, idade2);

            Console.WriteLine("\n" + texto);
            Console.WriteLine("\n\nPressione alguma tecla.");
            Console.ReadKey();
        }
        static string PessoaMaisVelha(string n1,int id1, string n2, int id2)
        {
            if (id1 > id2)
                return n1 + " é a pessoa mais velha.";
            else
                if (id2 > id1)
                return n2 + " é a pessoa mais velha.";
            else
                return n1 + " e " + n2 + "  tem a mesma idade.";
        }
    }
}
