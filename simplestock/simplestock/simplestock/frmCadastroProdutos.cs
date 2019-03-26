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
    public partial class frmCadastroProdutos : Form
    {
        public frmCadastroProdutos()
        {
            InitializeComponent();
        }

        private void desbloqueartxtbox()
        {
            txtcod.Enabled = true;
            txtproduto.Enabled = true;
            txtmarca.Enabled = true;
            cbfornecedor.Enabled = true;
            txtvalorcusto.Enabled = true;
            txtvalorvenda.Enabled = true;
            CodProp.Enabled = true;
        }

        private void bloqueartxtbox()
        {
            txtcod.Enabled = false;
            txtproduto.Enabled = false;
            txtmarca.Enabled = false;
            cbfornecedor.Enabled = false;
            txtvalorcusto.Enabled = false;
            txtvalorvenda.Enabled = false;
            CodProp.Enabled = false;
        }



        private void itemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.simplebaseDataSet);

        }

        private void frmCadastroProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'simplebaseDataSet.Fornecedores' table. You can move, or remove it, as needed.
            this.fornecedoresTableAdapter.Fill(this.simplebaseDataSet.Fornecedores);
            // TODO: This line of code loads data into the 'simplebaseDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.simplebaseDataSet.Items);
            bloqueartxtbox();

        }

        private void moeda(ref TextBox txt)
        {
           
        }

        private void produtoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void produtoLabel_Click(object sender, EventArgs e)
        {

        }

        private void fornecedorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            itemsBindingNavigator.Enabled = false;
            txtpesquisar.Visible = false;
            panel2.Visible = false;
            btnpesq.Visible = false;
            panel1.Visible = false;
            try
            {
                this.itemsBindingSource.AddNew();
                desbloqueartxtbox();
                txtquantidade.Text = "0";
            }
            catch (Exception)
            {
                MessageBox.Show("Termine o cadastramento para fazer um novo cadastro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

                if ((txtcod.Text != "") & (txtmarca.Text != "") & (txtproduto.Text != "") & (txtvalorcusto.Text != "") & (txtvalorvenda.Text != ""))
                {
                    itemsBindingNavigator.Enabled = true;
                    try
                    {
                        itemsBindingNavigatorSaveItem_Click(sender, e);
                        MessageBox.Show("Produto Salvo Com Sucesso, Se o produto foi adicionado através da janela entrada feche a consulta e abra novamente!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
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
                    MessageBox.Show("Preencha todos os campos para finalizar o cadastro!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            desbloqueartxtbox();
            itemsBindingNavigator.Enabled = false;
            txtpesquisar.Visible = false;
            btnpesq.Visible = false;
            panel1.Visible = false;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja Excluir?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    this.itemsBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.simplebaseDataSet);
                    MessageBox.Show("Registro Excluido com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.itemsTableAdapter.Fill(this.simplebaseDataSet.Items);
                }
                catch (Exception)
                {
                    MessageBox.Show("O registro está sendo usado e não pode ser deletado.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Exclusão Cancelada com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.itemsTableAdapter.Fill(this.simplebaseDataSet.Items);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem_Click(sender, e);
        }

        private void itemsBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void txtvalorcusto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtvalorcusto_Click(object sender, EventArgs e)
        {

        }



        private void txtvalorcusto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.itemsTableAdapter.FillByConsultaProdutos(this.simplebaseDataSet.Items, txtpesquisar.Text);
                return;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        Double valorvenda;

        private void txtvalorvenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtvalorcusto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        Double totalcusto;

        private void txtvalorcusto_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtvalorcusto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
                if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == ',') && !(e.KeyChar == Convert.ToChar(8)))
                {
                    e.Handled = true;
                }
        }

        private void txtvalorvenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == ',') && !(e.KeyChar == Convert.ToChar(8)))
            {
                e.Handled = true;
            }
        }

        private void txtvalorcusto_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.itemsTableAdapter.FillBycodprop(this.simplebaseDataSet.Items, new System.Nullable<int>(((int)(System.Convert.ChangeType(txtcodprop.Text, typeof(int))))));
                return;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillBycodpropToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.itemsTableAdapter.FillBycodprop(this.simplebaseDataSet.Items, new System.Nullable<int>(((int)(System.Convert.ChangeType(codPropToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
