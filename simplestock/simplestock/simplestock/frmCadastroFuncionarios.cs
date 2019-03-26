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
    public partial class frmCadastroFuncionarios : Form
    {
        public frmCadastroFuncionarios()
        {
            InitializeComponent();
        }

        private void bloqueartxtbox()
        {
            txtnome.Enabled = false;
            txtlogin.Enabled = false;
            txtsenha.Enabled = false;
            txtendereco.Enabled = false;
            txttelefone.Enabled = false;
            txtcpf.Enabled = false;
            txtemail.Enabled = false;
            txtcidade.Enabled = false;
            txtuf.Enabled = false;
            txtsenhamaster.Enabled = false;
            checkBox1.Enabled = false;
            txtsenhadel.Visible = false;
            panel1.Visible = false;
            acessoComboBox.Enabled = false;
        }

        private void desbloqueartxtbox()
        {
            txtnome.Enabled = true;
            txtlogin.Enabled = true;
            txtsenha.Enabled = true;
            txtendereco.Enabled = true;
            txttelefone.Enabled = true;
            txtcpf.Enabled = true;
            txtemail.Enabled = true;
            txtcidade.Enabled = true;
            txtuf.Enabled = true;
            checkBox1.Enabled = true;
            acessoComboBox.Enabled = true;
        }

        private void funcionariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.simplebaseDataSet);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.senhamestreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.simplebaseDataSet);
        }

        private void frmCadastroFuncionarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'simplebaseDataSet.Senhamestre' table. You can move, or remove it, as needed.
            this.senhamestreTableAdapter.Fill(this.simplebaseDataSet.Senhamestre);
            // TODO: This line of code loads data into the 'simplebaseDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.simplebaseDataSet.Clientes);
            // TODO: This line of code loads data into the 'simplebaseDataSet.Funcionarios' table. You can move, or remove it, as needed.
            this.funcionariosTableAdapter.Fill(this.simplebaseDataSet.Funcionarios);
            bloqueartxtbox();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            funcionariosBindingNavigator.Enabled = false;
            try
            {
            desbloqueartxtbox();
            this.funcionariosBindingSource.AddNew();
            }
            catch (Exception)
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (acessoComboBox.Text != "")
            {
                funcionariosBindingNavigator.Enabled = true;
                try
                {
                    funcionariosBindingNavigatorSaveItem_Click(sender, e);
                    MessageBox.Show("Salvo Com Sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                bloqueartxtbox();
            }
            else
            {
                MessageBox.Show("Preencha o Acesso!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            desbloqueartxtbox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem_Click(sender, e);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja Excluir?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    this.funcionariosBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.simplebaseDataSet);
                    MessageBox.Show("Registro Excluido com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.funcionariosTableAdapter.Fill(this.simplebaseDataSet.Funcionarios);
                }
                catch (Exception)
                {
                    MessageBox.Show("O registro está sendo usado e não pode ser deletado.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Exclusão Cancelada com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.funcionariosTableAdapter.Fill(this.simplebaseDataSet.Funcionarios);
            }
        }

        private void txtpesquisar2_Click(object sender, EventArgs e)
        {
            try
            {
                this.funcionariosTableAdapter.FillByConsultaFuncionarios(this.simplebaseDataSet.Funcionarios, txtpesquisar.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtsenhadel.Visible = true;
                panel1.Visible = true;
                txtsenhadel.Focus();
            }
            else
            {
                txtsenhadel.Visible = false;
                panel1.Visible = false;
            }
        }                   
        

        private void txtsenhamaster_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsenhadel_KeyPress(object sender, KeyPressEventArgs e)
        {  
            if (e.KeyChar == (char)13)
            {
                int result = senhamestreTableAdapter.FillBysenhamestre(simplebaseDataSet.Senhamestre, txtsenhadel.Text);
                if (result == 1)
                {
                    txtsenhamaster.Enabled = true;
                    panel1.Visible = true;
                }

                else
                {
                    MessageBox.Show("Senha Inválida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtsenhadel.Clear();
                }
            }
        }

        private void txtsenhadel_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }



    }
}
