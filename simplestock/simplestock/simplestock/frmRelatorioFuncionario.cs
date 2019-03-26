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
    public partial class frmRelatorioFuncionario : Form
    {
        public frmRelatorioFuncionario()
        {
            InitializeComponent();
        }

        private void frmRelatorioFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'simplebaseDataSet.Funcionarios' table. You can move, or remove it, as needed.
            this.FuncionariosTableAdapter.Fill(this.simplebaseDataSet.Funcionarios);

            this.reportViewer1.RefreshReport();
        }

        private void fillByFiltroFuncionarioToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void fillByFiltroFuncionarioToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

       
    }
}
