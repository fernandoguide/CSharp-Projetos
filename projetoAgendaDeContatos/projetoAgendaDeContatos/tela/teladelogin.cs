using projetoAgendaDeContatos.dominio;
using projetoAgendaDeContatos.repositorio;
using projetoAgendaDeContatos.tela;
using projetoAgendaDeContatos.utilitario;
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
    public partial class teladelogin : Form
    {
        //instacias necessarias
        Conexao conexao = new Conexao();
        ContaAcesso contaAcesso = new ContaAcesso();
        RepositorioContaAcesso repositoriocontaacesso = new RepositorioContaAcesso();
        AgendaDeContatos agendadecontatos = new AgendaDeContatos();



        public teladelogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            contaAcesso._Usuario = txtLogin.Text;
            contaAcesso._Senha = txtSenha.Text;
            if(repositoriocontaacesso.AutenticarUsuario(contaAcesso))
            {
                MessageBox.Show("Logado com Sucesso!");
                TelaSplash tela = new TelaSplash();
                tela.Show();
                this.Visible = false;             
                
            }
            else
            {
                MessageBox.Show("Usuário ou Senha inválidos", "Ocorreu um Erro ao Autenticar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        
        /*if ((txtLogin.Text == "admin") && (txtSenha.Text == "123"))
        {
            TelaSplash tela = new TelaSplash();
            tela.Show();
            this.Visible = false;

        }
        else
        {
            MessageBox.Show("Usuário ou Senha inválidos", "Ocorreu um Erro ao Autenticar", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }*/
    }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cboNivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaDeCadastroUsuario tela = new TelaDeCadastroUsuario();
            tela.ShowDialog();
            this.Hide();
            


        }
    }
}
