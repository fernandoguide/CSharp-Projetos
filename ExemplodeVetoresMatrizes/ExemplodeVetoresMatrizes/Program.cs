using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetoreseMatrizes_ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd, ialuno, inota;
            string[] NomeAluno = new string[40];
            float[,] Notas = new float[40, 3];
            Console.Write("Quantos alunos tem na classe? (máximo: 40): ");
            qtd = int.Parse(Console.ReadLine());
            for (ialuno = 0; ialuno < qtd; ialuno++)
            {
                Console.Write("Digite o nome do {0}º aluno: ", ialuno + 1);
                NomeAluno[ialuno] = Console.ReadLine();
                for (inota = 1; inota <= 2; inota++)
                {
                    Console.Write("Digite a {0}ª nota do aluno {1}: ", inota, NomeAluno[ialuno]);
                    Notas[ialuno, inota] = float.Parse(Console.ReadLine());
                    if (inota == 2) Notas[ialuno, 0] = (Notas[ialuno, 1] + Notas[ialuno, 2]) / 2;
                }

            }
            Lista(NomeAluno, Notas, qtd);
            Console.ReadKey();
        }
        static void Lista(string[] nome, float[,] notas, int qtd)
        {
            int i;
            for (i = 0; i < qtd; i++)
            {
                Console.WriteLine("{0}º Aluno: {1} tem nota1 = {2} e nota2 = {3}, resultando na média {4}", i + 1, nome[i], notas[i, 1], notas[i, 2], notas[i, 0]);
            }
        }
    }
}