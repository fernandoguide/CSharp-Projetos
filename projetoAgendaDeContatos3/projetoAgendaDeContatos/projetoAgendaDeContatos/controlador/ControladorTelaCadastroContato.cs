using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoAgendaDeContatos.controlador
{
    class ControladorTelaCadastroContato
    {
        private TextBox txtNome;
        private TextBox txtEndereco;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        public ControladorTelaCadastroContato(TextBox txtNome, TextBox Telefone, TextBox txtEndereco, TextBox txtEmail)
        {
            this.txtNome = txtNome;
            this.txtTelefone = Telefone;
            this.txtEndereco = txtEndereco;
            this.txtEmail = txtEmail;
        }

    }
}
