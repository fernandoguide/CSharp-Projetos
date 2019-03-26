using System;

namespace media2notas
{
    class Program
    {
        static void Main(string[] args)
        {

            float nota1,nota2,media;

                Console.Write("Calcula  a média de duas notas\n\n");
                Console.Write("Digite a Primeira Nota: ");
                nota1 = float.Parse(Console.ReadLine());
                Console.Write("Digite a Segunda Nota ");
                nota2 = float.Parse(Console.ReadLine());
                media = (nota1 + nota2) / 2;
                Console.WriteLine(media >= 6.0 ?  ("Aprovado Média: " + media) : ("Reprovado Média: " + media)) ;
                Console.WriteLine("\n\nPressione Qualquer tecla p/ finalizar\n\n");
                Console.ReadKey();
       
        }
    }
}