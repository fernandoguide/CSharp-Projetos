using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo4vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double sal_minimosp = 1076.20;
            double[] salarios = new double[10];

            //Atribuição do calculo no vetor salarios
            for (i = 0; i < salarios.Length; i++)
                salarios[i] = (i + 1) * sal_minimosp;

            //Exibição dos dados Calculados
            for (i = 0; i < salarios.Length; i++)
                Console.WriteLine("\n{0} Salario(s) Minimo(s) = {1}", (i + 1), salarios[i].ToString("#00.00"));
            Console.ReadKey();
        }
    }
}
