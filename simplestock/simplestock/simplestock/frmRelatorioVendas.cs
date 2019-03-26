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
    public partial class frmRelatorioVendas : Form
    {
        public frmRelatorioVendas()
        {
            InitializeComponent();
        }

        private void frmRelatorioVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'simplebaseDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.simplebaseDataSet.Clientes);
            // TODO: This line of code loads data into the 'simplebaseDataSet.Venda' table. You can move, or remove it, as needed.
            this.VendaTableAdapter.Fill(this.simplebaseDataSet.Venda);

            dtpinicial.Text = DateTime.Now.ToShortDateString();

            try
            {
                this.VendaTableAdapter.FillByFiltrarData(this.simplebaseDataSet.Venda, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dtpinicial.Text, typeof(System.DateTime))))));
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                this.VendaTableAdapter.FillByFiltrarData(this.simplebaseDataSet.Venda, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dtpinicial.Text, typeof(System.DateTime))))));
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void fillByFiltroClienteToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.VendaTableAdapter.FillByFiltroCliente(this.simplebaseDataSet.Venda, txtfiltrarcliente.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillByFiltrarVendedoToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.VendaTableAdapter.FillByFiltrarVendedo(this.simplebaseDataSet.Venda, txtfiltrarvendedor.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillByFiltroClienteToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.VendaTableAdapter.FillByFiltroCliente(this.simplebaseDataSet.Venda, clienteToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByDatafinalxInicialToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.VendaTableAdapter.FillByDatafinalxInicial(this.simplebaseDataSet.Venda, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dataToolStripTextBox1.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(data1ToolStripTextBox.Text, typeof(System.DateTime))))));
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBydataevendedorToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.VendaTableAdapter.FillBydataevendedor(this.simplebaseDataSet.Venda, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dataToolStripTextBox2.Text, typeof(System.DateTime))))), vendedorToolStripTextBox1.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBydataevendedorToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }








       
    }
}
