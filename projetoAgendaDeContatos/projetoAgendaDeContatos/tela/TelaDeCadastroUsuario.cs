using projetoAgendaDeContatos.dominio;
using projetoAgendaDeContatos.repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoAgendaDeContatos.tela
{
    public partial class TelaDeCadastroUsuario : Form
    {
        RepositorioContaAcesso repositorio = new RepositorioContaAcesso();


        public TelaDeCadastroUsuario()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarContato_Click(object sender, EventArgs e)
        {
            
            //repositorio.incluir(conta);
        }
    }
}
