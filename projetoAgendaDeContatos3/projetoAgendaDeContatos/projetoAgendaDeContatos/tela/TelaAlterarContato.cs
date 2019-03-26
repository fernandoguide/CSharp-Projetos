using projetoAgendaDeContatos.dominio;
using projetoAgendaDeContatos.repositorio;
using System;
using System.Windows.Forms;

namespace projetoAngendaDeContatos.tela
{
    public partial class TelaAlterarContato : Form
    {

        RepositorioContato repositoriocontato = new RepositorioContato();
        Contato contato = new Contato();
        public TelaAlterarContato()
        {
            InitializeComponent();
        }
       
        private void btnSalvarContato_Click(object sender, EventArgs e)
        {
            contato._nome = txtNome.Text;
            contato._telefone = mskTelefone.Text;
            contato._endereco = txtEndereco.Text;
            contato._email = txtEmail.Text;
            contato._codigo = int.Parse(txtCodigo.Text);
            repositoriocontato.Update(contato);
     
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mskTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TelaAlterarContato_Load(object sender, EventArgs e)
        {
           
        }
    }
}
