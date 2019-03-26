using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace simplestock
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private void btnlogin_Click(object sender, EventArgs e)
        {
            if ((txtlogin.Text != "") & (txtsenha.Text != ""))
            {
                int result = funcionariosTableAdapter.FillByLoginFuncionario(simplebaseDataSet.Funcionarios, txtlogin.Text, txtsenha.Text);

                if (result == 1)
                {
                    frmPrincipal frep = new frmPrincipal();
                    frep.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha Inválidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos.");
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void funcionariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.simplebaseDataSet);

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'simplebaseDataSet.Venda' table. You can move, or remove it, as needed.
            this.vendaTableAdapter.Fill(this.simplebaseDataSet.Venda);
            // TODO: This line of code loads data into the 'simplebaseDataSet.Funcionarios' table. You can move, or remove it, as needed.
            this.funcionariosTableAdapter.Fill(this.simplebaseDataSet.Funcionarios);

            acessoComboBox.Text = null;
           
        }

        private void txtsenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                 btnlogin_Click( sender, e);
            }
        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillByacessoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.funcionariosTableAdapter.FillByacesso(this.simplebaseDataSet.Funcionarios, loginToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void txtlogin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.funcionariosTableAdapter.FillByacesso(this.simplebaseDataSet.Funcionarios, txtlogin.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
