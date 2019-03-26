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
    public partial class frmRelatorioClientes : Form
    {
        public frmRelatorioClientes()
        {
            InitializeComponent();
        }

        private void frmRelatorioClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'simplebaseDataSet.Clientes' table. You can move, or remove it, as needed.
            this.ClientesTableAdapter.Fill(this.simplebaseDataSet.Clientes);

            this.reportViewer1.RefreshReport();
        }
    }
}
