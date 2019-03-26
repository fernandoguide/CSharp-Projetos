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
    public partial class frmRelatorioFornecedores : Form
    {
        public frmRelatorioFornecedores()
        {
            InitializeComponent();
        }

        private void frmRelatorioFornecedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'simplebaseDataSet.Fornecedores' table. You can move, or remove it, as needed.
            this.FornecedoresTableAdapter.Fill(this.simplebaseDataSet.Fornecedores);

            this.reportViewer1.RefreshReport();
        }
    }
}
