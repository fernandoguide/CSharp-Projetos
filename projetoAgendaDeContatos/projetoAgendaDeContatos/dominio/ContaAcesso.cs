using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoAgendaDeContatos.dominio
{
    class ContaAcesso
    {
        private String usuario;
        private String senha;
        private Boolean validado;



        public String _Usuario { get; set; }
        public  String _Senha { get; set; }


        public ContaAcesso()
        {

        }

        public ContaAcesso(String usuario, String senha)
        {
            this.usuario = usuario;
            this.senha = senha;
            this.validado = false;
        }
        public Boolean ValidarUsuario()
        {
            if(this._Usuario != "" && this._Senha != "")
            {
                if(this._Usuario != null && this._Senha != null)
                {
                    this.validado = true;
                    
                }
            }
            return validado;
        }
    }

        
}
