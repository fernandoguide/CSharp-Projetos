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
    public partial class frmRelatorioProdutosVenda : Form
    {
        public frmRelatorioProdutosVenda()
        {
            InitializeComponent();
        }

        private void frmRelatorioProdutosVenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'simplebaseDataSet.Venda' table. You can move, or remove it, as needed.
            this.VendaTableAdapter.Fill(this.simplebaseDataSet.Venda);
            // TODO: This line of code loads data into the 'simplebaseDataSet.ProdutoVenda' table. You can move, or remove it, as needed.
            this.ProdutoVendaTableAdapter.Fill(this.simplebaseDataSet.ProdutoVenda);

            
            this.reportViewer1.RefreshReport();
        }

        private void fillByFiltrarporidvendaToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.ProdutoVendaTableAdapter.FillByFiltrarporidvenda(this.simplebaseDataSet.ProdutoVenda, new System.Nullable<int>(((int)(System.Convert.ChangeType(txtFiltrar.Text, typeof(int))))));
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
