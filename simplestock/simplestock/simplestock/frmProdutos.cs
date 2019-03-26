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
    public partial class frmProdutos : Form
    {
        private frmVenda frmConProd;

        public frmProdutos()
        {
            InitializeComponent();
        }

        public frmProdutos(frmVenda frm)
        {
            frmConProd = frm;
            InitializeComponent();
        }


        private void frmProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'simplebaseDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.simplebaseDataSet.Items);

            itemsDataGridView.Columns["DGVTValorVenda"].DefaultCellStyle.Format = "C";

            for (int i = 0; i < itemsDataGridView.RowCount - 1; i++)
            {
                if (Convert.ToString(itemsDataGridView.Rows[i].Cells[3].Value) == "0")
                {
                    itemsDataGridView.Rows[i].Visible = false;
                }
            }
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
            frmConProd.setCodigoAndNomeProduto(Convert.ToInt32(itemsDataGridView.CurrentRow.Cells[5].Value.ToString()));

            this.Dispose();
        }

        

        private void itemsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            additems();
        }

        private void itemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void itemsDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }


    }
}
