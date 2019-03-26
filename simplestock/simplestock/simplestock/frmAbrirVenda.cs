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
    public partial class frmAbrirVenda : Form
    {
        public frmAbrirVenda()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

             int result = this.produtoVendaTableAdapter.FillByfiltro(this.simplebaseDataSet.ProdutoVenda, new System.Nullable<int>(((int)(System.Convert.ChangeType(txtcodvend.Text, typeof(int))))));
             
            if (result == 1)
            {
                            frmReimpressãoVenda frep = new frmReimpressãoVenda();
                            frep.Show();
                            this.Close();
            }
            else
            {
               MessageBox.Show("Venda Inexistente");
               return;
            }
             
          }
        }
        

        private void produtoVendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoVendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.simplebaseDataSet);

        }

        public static String condicao = "";

        private void frmAbrirVenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'simplebaseDataSet.ProdutoVenda' table. You can move, or remove it, as needed.
            this.produtoVendaTableAdapter.Fill(this.simplebaseDataSet.ProdutoVenda);

        }

        private void fillByfiltroToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.produtoVendaTableAdapter.FillByfiltro(this.simplebaseDataSet.ProdutoVenda, new System.Nullable<int>(((int)(System.Convert.ChangeType(idVendaToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void txtcodvend_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
