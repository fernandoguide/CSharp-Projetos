using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetoAgendaDeContatos.utilitario;
using System.Data.SqlClient;
using projetoAgendaDeContatos.dominio;
using System.Windows.Forms;
using System.Data;

namespace projetoAgendaDeContatos.repositorio
{
    class RepositorioContato
    {
        public const String NOME_TABELA = "contatos";
        private const String COMANDO_BASE = "SELECT * from" + NOME_TABELA;
        private const String CONDICIONAL_WHERE = "WHERE";
        private const String COLUNA_ID = "id";

        //Instancia de conexao com o banco de dados 
        Conexao conexao = new Conexao();
        SqlCommand comando = new SqlCommand();

        //metodo de salvamento do contato no banco de dados 
        public bool Incluir(Contato contato)
        {
            comando.CommandText = "INSERT INTO " + NOME_TABELA + " values (' " + contato._nome + "','" 
                + contato._telefone + "','" + contato._endereco + "','" + contato._email + "');";
            //Desconectar para garantir e depois conectar novamente
            comando.Connection = conexao.DesconectarBD();
            comando.Connection = conexao.ConectarBD();

            // Controle de Exceção
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Contato Salvo com Sucesso!!!");
                return true;    
            }
            catch (Exception e)
            {
                return false;
                MessageBox.Show("Falha ao salvar no banco de dados.\nDetalhes do erro: " + e);
            }
            //fim controle de exceção
            //desconectar pela ultima vez 
            conexao.DesconectarBD();
        }
        public DataSet ConsultarTodos()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("select * from contatos;", conexao.ConectarBD());
            da.Fill(ds);
            conexao.DesconectarBD();
            return ds; 
        }
        public DataSet ConsultarporNomeouID(string coluna, string valor)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            da = new SqlDataAdapter("select * from contatos  where  " + coluna + " like '%" + valor + "%'",conexao.ConectarBD());
            da.Fill(ds);
            conexao.DesconectarBD();
            return ds; 
        }
        public void Update(Contato contato)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update contatos set nome = @nome, telefone = @telefone, endereco = @endereco, email = @email where codigo = @codigo", conexao.ConectarBD());
                //usar parâmetro para preenchar os @ do comando
                cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = contato._nome;
                cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = contato._telefone;
                cmd.Parameters.Add("endereco", SqlDbType.VarChar).Value = contato._endereco;
                cmd.Parameters.Add("@eMail", SqlDbType.VarChar).Value = contato._email;
                cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = contato._codigo;
               
                //executar a query sem retornar valor
                cmd.ExecuteNonQuery();
                MessageBox.Show("Contato alterado com sucesso!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.DesconectarBD();
                Application.Restart();            }
        }
       /* public bool Excluir (Contato contato)
        {
            comando.CommandText = "DELETE  " + COMANDO_BASE+" " + CONDICIONAL_WHERE +" "+ COLUNA_ID;
            //Desconectar para garantir e depois conectar novamente
            comando.Connection = conexao.DesconectarBD();
            comando.Connection = conexao.ConectarBD();

            // Controle de Exceção
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Contato Excluido com Sucesso!!!");
                return true;
            }
            catch (Exception e)
            {
                return false;
                MessageBox.Show("Falha ao excluir no banco de dados.\nDetalhes do erro: " + e);
            }
            //fim controle de exceção
            //desconectar pela ultima vez 
            conexao.DesconectarBD();
        }
        */
    }
}
