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
    public partial class frmReimpressãoVenda : Form
    {
        public frmReimpressãoVenda()
        {
            InitializeComponent();
        }

        frmAbrirVenda frmab = Application.OpenForms["frmAbrirVenda"] as frmAbrirVenda;

        private void frmReimpressãoVenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'simplebaseDataSet.ProdutoVenda' table. You can move, or remove it, as needed.
            this.ProdutoVendaTableAdapter.Fill(this.simplebaseDataSet.ProdutoVenda);

            this.reportViewer1.RefreshReport();

            try
            {
                this.ProdutoVendaTableAdapter.FillByFiltrarporidvenda(this.simplebaseDataSet.ProdutoVenda, new System.Nullable<int>(((int)(System.Convert.ChangeType(frmab.txtcodvend.Text, typeof(int))))));
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
