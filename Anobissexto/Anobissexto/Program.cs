using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anobissexto
{
    class Anobissexto
    {
        static void Main(string[] args)
        {
            int resto, ano, bix;

            Console.WriteLine("\nVerifica se um Ano é Bissexto");
            Console.Write("Digite o Ano que Deseja Verificar: ");
            ano = int.Parse(Console.ReadLine());
            resto = ano % 4;
            bix = ano - resto;

            Console.WriteLine(resto == 0 ? ("Este ano de   ") + ano + ("  é bissexto") : ("Este ano de  ") + ano + (" não é bissexto , Mas o ano ") + bix + (" é o bissexto anterior e o ") + (bix + 4 ) + (" é o bissexto proximo."));
            Console.WriteLine("Pressione Qualquer tecla para finalizar");

            Console.ReadKey();
        }
    }
}
