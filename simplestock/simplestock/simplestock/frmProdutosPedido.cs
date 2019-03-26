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
    public partial class frmProdutosPedido : Form
    {
        private frmEntradadeProdutos frmConProd;

        public frmProdutosPedido()
        {
            InitializeComponent();
        }

        public frmProdutosPedido(frmEntradadeProdutos frm)
        {
            frmConProd = frm;
            InitializeComponent();
        }


        private void frmProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'simplebaseDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.simplebaseDataSet.Items);

            itemsDataGridView.Columns["DGVTValorVenda"].DefaultCellStyle.Format = "C";
            itemsDataGridView.Columns[6].DefaultCellStyle.Format = "C";
        }

        private void itemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.simplebaseDataSet);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.itemsTableAdapter.FillByConsultaProdutos(simplebaseDataSet.Items, txtnomeproduto.Text);
        }

        private void additems()
        {
            frmConProd.setCodigoAndNomeProduto(Convert.ToInt32(itemsDataGridView.CurrentRow.Cells[0].Value.ToString()),
                itemsDataGridView.CurrentRow.Cells[2].Value.ToString(),
                itemsDataGridView.CurrentRow.Cells[3].Value.ToString(),
                (Convert.ToDouble(itemsDataGridView.CurrentRow.Cells[6].Value.ToString()))); 
          //      (Convert.ToInt32(itemsDataGridView.CurrentRow.Cells[4].Value.ToString())));

            this.Dispose();
        }

        

        private void itemsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            additems();
        }

        private void itemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadastroProdutos frep = new frmCadastroProdutos();
            frep.Show();
        }

        private void txtcodprop_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.itemsTableAdapter.FillBycodprop(this.simplebaseDataSet.Items, new System.Nullable<int>(((int)(System.Convert.ChangeType(txtcodprop.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

    


    }
}
