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
    public partial class frmClientes : Form
    {
        private frmVenda frmConCli;

        public frmClientes()
        {
            InitializeComponent();
        }

        public frmClientes(frmVenda frm)
        {
            frmConCli = frm;
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'simplebaseDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.simplebaseDataSet.Clientes);

        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.simplebaseDataSet);

        }

        private void txtnomeproduto_TextChanged(object sender, EventArgs e)
        {
            this.clientesTableAdapter.FillByConsultaClientes(simplebaseDataSet.Clientes, txtnomecliente.Text);
        }

        private void clientesDataGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                frmConCli.setNomeCliente(Convert.ToInt32(clientesDataGridView.CurrentRow.Cells[0].Value.ToString()),
    clientesDataGridView.CurrentRow.Cells[1].Value.ToString());


                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadastroClientes frep = new frmCadastroClientes();
            frep.Show();
        }
    }
}
