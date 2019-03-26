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
    public partial class frmConsultaProdutos : Form
    {
        public frmConsultaProdutos()
        {
            InitializeComponent();
        }

        private void itemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.simplebaseDataSet);

        }


        private void frmConsultaProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'simplebaseDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.simplebaseDataSet.Items);

            itemsDataGridView.Columns["DGVTValorVenda"].DefaultCellStyle.Format = "N2";

            // faz o form abrir em fullscreen
            WindowState = FormWindowState.Maximized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.itemsTableAdapter.FillByConsultaProdutos(simplebaseDataSet.Items, txtconsultaprodutos.Text);
        }



        private void itemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
