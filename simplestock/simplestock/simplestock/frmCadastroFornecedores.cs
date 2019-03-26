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
    public partial class frmCadastroFornecedores : Form
    {
        public frmCadastroFornecedores()
        {
            InitializeComponent();
        }

        private void bloqueartxtbox()
        {
            txtcnpj.Enabled = false;
            txtrazaosocial.Enabled = false;
            txtnomefantasia.Enabled = false;
            txtendereco.Enabled = false;
            txtcidade.Enabled = false;
            txtuf.Enabled = false;
            txttelefone.Enabled = false;
            txtrg.Enabled = false;
            txtemail.Enabled = false;
            txtbairro.Enabled = false;
            txtnum.Enabled = false;
            txtsite.Enabled = false;
        }

        private void desbloqueartxtbox()
        {
            txtcnpj.Enabled = true;
            txtrazaosocial.Enabled = true;
            txtnomefantasia.Enabled = true;
            txtendereco.Enabled = true;
            txtcidade.Enabled = true;
            txtuf.Enabled = true;
            txttelefone.Enabled = true;
            txtrg.Enabled = true;
            txtemail.Enabled = true;
            txtbairro.Enabled = true;
            txtnum.Enabled = true;
            txtsite.Enabled = true;
        }

        private void fornecedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornecedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.simplebaseDataSet);
        }

        private void frmCadastroFornecedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'simplebaseDataSet.Fornecedores' table. You can move, or remove it, as needed.
            this.fornecedoresTableAdapter.Fill(this.simplebaseDataSet.Fornecedores);
            this.fornecedoresBindingSource.MoveLast();
            bloqueartxtbox();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void cNPJTextBox_TextChanged(object sender, EventArgs e)
        {
            txtcnpj.SelectionStart = txtcnpj.Text.Length + 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fornecedoresBindingNavigator.Enabled = false;
            try
            {
                desbloqueartxtbox();
                this.fornecedoresBindingSource.AddNew();
            }
            catch (Exception)
            {
                MessageBox.Show("Termine o cadastramento para fazer um novo cadastro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (txtrazaosocial.Enabled != false)
            {
                fornecedoresBindingNavigator.Enabled = true;
                try
                {
                    fornecedoresBindingNavigatorSaveItem_Click(sender, e);
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
                MessageBox.Show("Você precisa alterar algo para salvar!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            desbloqueartxtbox();
        }

        private void txttelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void telefoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void cidadeLabel_Click(object sender, EventArgs e)
        {

        }

        private void tsbtndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja Excluir?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    this.fornecedoresBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.simplebaseDataSet);
                    MessageBox.Show("Registro Excluido com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.fornecedoresTableAdapter.Fill(this.simplebaseDataSet.Fornecedores);
                }
                catch (Exception)
                {
                    MessageBox.Show("O registro está sendo usado por algum produto e não pode ser deletado, altere o fornecedor do produto para poder excluir.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Exclusão Cancelada com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.fornecedoresTableAdapter.Fill(this.simplebaseDataSet.Fornecedores);
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {

        }

        private void txtpesquisar2_Click(object sender, EventArgs e)
        {
            try
            {
                this.fornecedoresTableAdapter.FillByConsultaFornecedores(this.simplebaseDataSet.Fornecedores, txtpesquisar.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void razaoSocialLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
