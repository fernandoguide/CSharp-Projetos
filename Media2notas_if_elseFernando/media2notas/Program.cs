using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media2notas
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1,nota2,media,quest;
            
            do
            {
                Console.Write("Calcula  a média de duas notas\n\n");
                Console.Write("Digite a Primeira Nota: ");
                nota1 = float.Parse(Console.ReadLine());
                Console.Write("Digite a Segunda Nota ");
                nota2 = float.Parse(Console.ReadLine());
                media = (nota1 + nota2) / 2;
                if (media >= 6.0)
                {
                    Console.WriteLine("Aprovado-Média: " + media);

                }
                else
                    Console.WriteLine("\nReprovado -Média: " + media);

                    Console.WriteLine("\nDeseja Calcular a média de duas notas novamente?");
                    Console.Write("\n[1] - SIM");                  
                    Console.Write("\n[0]- NÂO");  
                    Console.Write("\n Sua Escolha: ");
                    quest = float.Parse(Console.ReadLine());

            }
            while (quest != 0);
            Console.WriteLine("\n\n************* Feito por Fernando Oliveira ***************\n\n");


            Console.ReadKey();
         
        }
    }
}