using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odonto
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((textBox1.Text == "admin") && (textBox2.Text == "123"))
            {
                frmPrincipal frmP = new frmPrincipal();
                frmP.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuário ou Senha inválidos", "Ocorreu um Erro ao Autenticar",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
