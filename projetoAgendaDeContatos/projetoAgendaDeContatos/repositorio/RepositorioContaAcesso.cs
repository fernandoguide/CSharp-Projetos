using projetoAgendaDeContatos.dominio;
using projetoAgendaDeContatos.utilitario;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoAgendaDeContatos.repositorio
{
    class RepositorioContaAcesso
    {
        Conexao conexao = new Conexao();
        //construtor vazio
        public RepositorioContaAcesso()
        {

        }

        public bool AutenticarUsuario(ContaAcesso contaAcesso)
        {
            bool resultado = false;
            String sql = "SELECT * FROM CONTAACESSO WHERE USUARIO = '"
                + contaAcesso._Usuario + "' AND " + "SENHA = '" + contaAcesso._Senha + "';";
            SqlCommand cmd = new SqlCommand(sql, conexao.ConectarBD());
            if(contaAcesso.ValidarUsuario())
            {
                try
                {
                    SqlDataReader dados = cmd.ExecuteReader();
                    resultado = dados.HasRows;

                }
                catch(SqlException e)
                {
                    throw new Exception(e.Message);

                }
            }
            conexao.DesconectarBD();
            return resultado;

         }
        /*public bool incluir (ContaAcesso contaAcesso)
        {
            ContaAcesso conta = new ContaAcesso();

            bool resultado = false;
            String sql = "INSERT INTO CONTAACESSO  VALUES(" + contaAcesso._Usuario + ", " + contaAcesso._Senha + ");";
            
            SqlCommand cmd = new SqlCommand(sql, conexao.ConectarBD());

            if (contaAcesso.ValidarUsuario())
            {
                try
                {
                    SqlDataReader dados = cmd.ExecuteReader();
                    resultado = dados.HasRows;

                }
                catch (SqlException e)
                {
                    throw new Exception(e.Message);

                }
            }
            conexao.DesconectarBD();
            return resultado;
        }
        */
    }
}
