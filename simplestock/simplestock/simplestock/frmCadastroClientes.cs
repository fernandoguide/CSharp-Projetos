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
    public partial class frmCadastroClientes : Form
    {
        public frmCadastroClientes()
        {
            InitializeComponent();
        }

        private void bloqueartxtbox()
        {
            txtcod.Enabled = false;
            txtnome.Enabled = false;
            txtrua.Enabled = false;
            txtnum.Enabled = false;
            txtbairro.Enabled = false;
            txtcep.Enabled = false;
            txttel.Enabled = false;
            txtcpf.Enabled = false;
            txtrg.Enabled = false;
            txtemail.Enabled = false;
            txtcidade.Enabled = false;
            txtuf.Enabled = false;
        }

        private void desbloqueartxtbox()
        {
            txtcod.Enabled = true;
            txtnome.Enabled = true;
            txtrua.Enabled = true;
            txtnum.Enabled = true;
            txtbairro.Enabled = true;
            txtcep.Enabled = true;
            txttel.Enabled = true;
            txtcpf.Enabled = true;
            txtrg.Enabled = true;
            txtemail.Enabled = true;
            txtcidade.Enabled = true;
            txtuf.Enabled = true;
        }


        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.clientesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.simplebaseDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }

        }

        private void frmCadastroClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'simplebaseDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.simplebaseDataSet.Clientes);
            bloqueartxtbox();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            clientesBindingNavigator.Enabled = false;
            try
            {
            desbloqueartxtbox();
            this.clientesBindingSource.AddNew();
            }
            catch (Exception)
            {
                MessageBox.Show("Termine o cadastramento para fazer um novo cadastro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if (txtnome.Text != "")
            {
                clientesBindingNavigator.Enabled = true;
                try
                {
                    clientesBindingNavigatorSaveItem_Click(sender, e);
                    MessageBox.Show("Cliente Salvo com Sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Insira os dados para poder salvar.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            desbloqueartxtbox();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem_Click(sender, e);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void tsbtnexcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja Excluir?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    this.clientesBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.simplebaseDataSet);
                    MessageBox.Show("Registro Excluido com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.clientesTableAdapter.Fill(this.simplebaseDataSet.Clientes);
                }
                catch (Exception)
                {
                    MessageBox.Show("O registro está sendo usado e não pode ser deletado.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Exclusão Cancelada com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clientesTableAdapter.Fill(this.simplebaseDataSet.Clientes);
            }
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientesTableAdapter.FillByConsultaClientes(this.simplebaseDataSet.Clientes, txtpesquisar.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void cPFLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
