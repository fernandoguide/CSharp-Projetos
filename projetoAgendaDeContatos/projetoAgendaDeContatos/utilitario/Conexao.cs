using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoAgendaDeContatos.utilitario
{
    public class Conexao
    {
        // String de conexao
        SqlConnection con = new SqlConnection("User ID=sa;Initial Catalog=bdAgendaDeContatos1;Data Source=(local);Password=1234567");
        public SqlConnection ConectarBD()
        {
            try
            {
                con.Open();                                                                                                                                                 
            }
            catch (Exception e)
            {
                MessageBox.Show("Falha  ao conectar .\nDetalhes do erro: " + e);
            }
            return con;
        }
        // checando a conexao com o bd
        public void checarconexao()
        {
            if (con != null && con.State != ConnectionState.Closed)
            {
                MessageBox.Show("Conectado com Sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao conectar ao Banco de Dados.");
            }
        }
        public SqlConnection DesconectarBD()
        {
            try
            {
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao Desconectar. \nDetalhes do erro: " + e);
            }
            return con;
        }        
    }
}
  

