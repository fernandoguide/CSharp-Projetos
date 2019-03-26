using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoAgendaDeContatos.dominio
{
    class Contato
    {
        // Atributos da classe
        private int codigo;
        private string nome;
        private string endereco;
        private string telefone;
        private string email;


        //Getters e Setters 
        public int _codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string _nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string _endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }       
        public string _telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string _email
        {
            get { return email; }
            set { email = value; }
        }

    }
}
