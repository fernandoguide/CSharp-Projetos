using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.DotNetCore.Models
{
    public class Filme
    {
        public int ID { get; set; }

        public string Titulo { get; set; } 

        public DateTime Lancamento { get; set; }

        public string Genero { get; set; }

        public decimal Preco { get; set; }
    }
}
