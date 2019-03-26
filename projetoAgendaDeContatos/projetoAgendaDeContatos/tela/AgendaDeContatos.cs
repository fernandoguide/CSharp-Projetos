using projetoAgendaDeContatos.dominio;
using projetoAgendaDeContatos.repositorio;
using projetoAgendaDeContatos.utilitario;
using projetoAngendaDeContatos.tela;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoAgendaDeContatos
{
    public partial class AgendaDeContatos : Form
    {
        // Declaracao e instalaçao dos objetos globais.
        Contato contato;
        Conexao conexao = new Conexao();
        RepositorioContato repositoriocontato = new RepositorioContato();
        TelaAlterarContato telaAlterarContato;
        
        //fim
            
        public AgendaDeContatos()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Contato  contato = new Contato();
            contato._nome = txtNome.Text;
            contato._telefone = mskTelefone.Text;
            contato._endereco = txtEndereco.Text;
            contato._email = txtEmail.Text;
            repositoriocontato.Incluir(contato);
            txtNome.Text = "";
            txtEndereco.Text = "";
            mskTelefone.Text = "";
            txtEmail.Text = "";
        }
        private void btnTestar_Click(object sender, EventArgs e)
        {     
            conexao.ConectarBD();
            conexao.checarconexao();
            conexao.DesconectarBD();
        }
        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            conexao.DesconectarBD();
            DataSet ds = new DataSet();
            ds = repositoriocontato.ConsultarTodos();
            dgvConsulta.DataSource = ds.Tables[0];
            dgvConsulta.Refresh();

        }
    
        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          Contato contato = new Contato();

             TelaAlterarContato  telaAlterarContato = new TelaAlterarContato();

            if (e.RowIndex >= 0) 

            {
                telaAlterarContato.txtCodigo.Text = dgvConsulta.Rows[e.RowIndex].Cells[0].Value.ToString();
                telaAlterarContato.txtNome.Text = dgvConsulta.Rows[e.RowIndex].Cells[1].Value.ToString();
                telaAlterarContato.txtEndereco.Text = dgvConsulta.Rows[e.RowIndex].Cells[2].Value.ToString();
                telaAlterarContato.mskTelefone.Text = dgvConsulta.Rows[e.RowIndex].Cells[3].Value.ToString();
                telaAlterarContato.txtEmail.Text = dgvConsulta.Rows[e.RowIndex].Cells[4].Value.ToString();
                telaAlterarContato.ShowDialog();
            }
        
        }
      
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = repositoriocontato.ConsultarporNomeouID(comboBoxBuscar.Text, txtBuscar.Text);
            dgvConsulta.DataSource = ds.Tables[0];
            dgvConsulta.Refresh();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            /*
            Contato contato = new Contato();
            contato._nome = txtNome.Text;
            contato._telefone = mskTelefone.Text;
            contato._endereco = txtEndereco.Text;
            contato._email = txtEmail.Text;
            repositoriocontato.Excluir(contato);
            txtNome.Text = "";
            txtEndereco.Text = "";
            mskTelefone.Text = "";
            txtEmail.Text = "";
            */
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
           /* Contato contato = new Contato();

            TelaAlterarContato telaAlterarContato = new TelaAlterarContato();

            if (e.RowIndex >= 0)

            {
                telaAlterarContato.txtCodigo.Text = dgvConsulta.Rows[e.RowIndex].Cells[0].Value.ToString();
                telaAlterarContato.txtNome.Text = dgvConsulta.Rows[e.RowIndex].Cells[1].Value.ToString();
                telaAlterarContato.txtEndereco.Text = dgvConsulta.Rows[e.RowIndex].Cells[2].Value.ToString();
                telaAlterarContato.mskTelefone.Text = dgvConsulta.Rows[e.RowIndex].Cells[3].Value.ToString();
                telaAlterarContato.txtEmail.Text = dgvConsulta.Rows[e.RowIndex].Cells[4].Value.ToString();
                telaAlterarContato.ShowDialog();
            }
            */
        }

        private void comboBoxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
