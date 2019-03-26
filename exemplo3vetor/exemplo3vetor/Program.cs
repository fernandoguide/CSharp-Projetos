using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo3vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra;
            int i;
            Console.Write("Digite uma palavra: "); palavra = Console.ReadLine();

            char[] vetor = palavra.ToCharArray();

            int tamanho = vetor.Length;

            for (i=0;i<tamanho; i++)
                if (vetor[i]=='a'||vetor[i]=='e'|| vetor[i]== 'i'|| vetor[i]=='o'||vetor[i]=='u'|| vetor[i] == 'A' || vetor[i] == 'E' || vetor[i] == 'I' || vetor[i] == 'O' || vetor[i] == 'U')
                {
                    Console.Write(" {0}", vetor[i]);
                }
            Console.ReadKey();
        }
    }
}
