using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace simplestock
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //vai pegar os componentes da frmopcoes
        frmConfiguracoes frmop = Application.OpenForms["frmOpcoes"] as frmConfiguracoes;
        //pega o do login para nome de usuario
        frmLogin frmloginn = Application.OpenForms["frmLogin"] as frmLogin;

        private void relatórioDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioProdutos frep = new frmRelatorioProdutos();
            frep.Show();
        }

        private void relatórioDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioFuncionario frep = new frmRelatorioFuncionario();
            frep.Show();
        }

        private void relatórioDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioClientes frep = new frmRelatorioClientes();
            frep.Show();
        }

        private void relatórioDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioFornecedores frep = new frmRelatorioFornecedores();
            frep.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbtnfornecedor_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedores frep = new frmCadastroFornecedores();
            frep.Show();
        }

        private void tsbtnfuncionarios_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionarios frep = new frmCadastroFuncionarios();
            frep.Show();
        }

        private void tsbtnprodutos_Click(object sender, EventArgs e)
        {
            frmCadastroProdutos frep = new frmCadastroProdutos();
            frep.Show();
        }

        private void tsbtnclientes_Click(object sender, EventArgs e)
        {
            frmCadastroClientes frep = new frmCadastroClientes();
            frep.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor frep = new frmConsultaFornecedor();
            frep.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmConsultaFuncionario frep = new frmConsultaFuncionario();
            frep.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmConsultaProdutos frep = new frmConsultaProdutos();
            frep.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmConsultaClientes frep = new frmConsultaClientes();
            frep.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            frmVenda frep = new frmVenda();
            frep.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Você está saindo do Sistema, deseja efetuar Backup antes?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                backupToolStripMenuItem_Click(sender, e);
                Application.Exit();
            }
            if (dlr == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                Application.Exit();
            }
        }

        private void tsbtnconsfornecedor(object sender, EventArgs e)
        {
            frmConsultaFornecedor frep = new frmConsultaFornecedor();
            frep.Show();
        }

        private void tsbtnconsfuncionario(object sender, EventArgs e)
        {
            frmConsultaFuncionario frep = new frmConsultaFuncionario();
            frep.Show();
        }

        private void tsbtnconsproduto(object sender, EventArgs e)
        {
            frmConsultaProdutos frep = new frmConsultaProdutos();
            frep.Show();
        }

        private void tsbtnconscliente(object sender, EventArgs e)
        {
            frmConsultaClientes frep = new frmConsultaClientes();
            frep.Show();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (System.IO.File.Exists(saveFileDialog1.FileName))
                    {
                        System.IO.File.Delete(saveFileDialog1.FileName);
                    }

                    System.IO.File.Copy(Application.StartupPath.ToString() + "\\simplebase.mdb", saveFileDialog1.FileName);
                    MessageBox.Show("Backup efetuado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro:" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Operação cancelada com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void restaurarBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if(System.IO.File.Exists(Application.StartupPath.ToString() + "\\simplebase.mdb"))
                {
                    System.IO.File.Delete(Application.StartupPath.ToString() + "\\simplebase.mdb");
                }
                System.IO.File.Copy(openFileDialog1.FileName, Application.StartupPath.ToString() + "\\simplebase.mdb");
                MessageBox.Show("Backup restaurado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operação cancelada com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSobre frep = new frmSobre();
            frep.Show();
        }

        private void valoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioProdutosVenda frep = new frmRelatorioProdutosVenda();
            frep.Show();
        }

        private void tsbtnConsVendas_Click(object sender, EventArgs e)
        {

            frmConsultaVendas frep = new frmConsultaVendas();
            frep.Show();
        }

        private void controleacesso()
        {
            if (txtbackup.Text == "Sim")
            {
                arquivoToolStripMenuItem.Enabled = true;
            }
            else
            {
                arquivoToolStripMenuItem.Enabled = false;
            }
            if (txtcadastro.Text == "Sim")
            {
                cadastroToolStripMenuItem.Enabled = true;
                tsbtnclientes.Enabled = true;
                tsbtnfornecedor.Enabled = true;
                tsbtnfuncionarios.Enabled = true;
                tsbtnprodutos.Enabled = true;
            }
            else
            {
                cadastroToolStripMenuItem.Enabled = false;
                tsbtnclientes.Enabled = false;
                tsbtnfornecedor.Enabled = false;
                tsbtnfuncionarios.Enabled = false;
                tsbtnprodutos.Enabled = false;
            }
                
            if (txtconfiguracoes.Text == "Sim")
                {
                    opçõesToolStripMenuItem.Enabled = true;
                }
            
            else
            {
                opçõesToolStripMenuItem.Enabled = false;
            }
           
            if (txtconsulta.Text == "Sim")
                    {
                        consultaToolStripMenuItem.Enabled = true;
                        tsbtnConsultaFornecedor.Enabled = true;
                        tsbtnconsultafuncionarios.Enabled = true;
                        tsbtnconsultaprodutos.Enabled = true;
                        tsbtnconsultaclientes.Enabled = true;
                        tsbtnConsVendas.Enabled = true;
                    }
            
            else
            {
                consultaToolStripMenuItem.Enabled = false;
                tsbtnConsultaFornecedor.Enabled = false;
                tsbtnconsultafuncionarios.Enabled = false;
                tsbtnconsultaprodutos.Enabled = false;
                tsbtnconsultaclientes.Enabled = false;
                tsbtnConsVendas.Enabled = false;
            }
            
            if (txtentrada.Text == "Sim")
                        {
                            toolStripButton1.Enabled = true;
                        }
             
            else
            {
                toolStripButton1.Enabled = false;
            }
            
            if (txtrelatorio.Text == "Sim")
                            {
                                relatóriosToolStripMenuItem.Enabled = true;
                            }
            
            else
            {
                relatóriosToolStripMenuItem.Enabled = false;
            }
            
            if (txtvenda.Text == "Sim")
                                {
                                    tsbtnVendas.Enabled = true;
                                }
            
            else
            {
                tsbtnVendas.Enabled = false;
            }
        }
        
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'simplebaseDataSet.AcessoOp' table. You can move, or remove it, as needed.
            this.acessoOpTableAdapter.Fill(this.simplebaseDataSet.AcessoOp);
            tslnome.Text = frmloginn.txtlogin.Text;
            tslnivel.Text = frmloginn.acessoComboBox.Text;


                // TODO: This line of code loads data into the 'simplebaseDataSet.Imagens' table. You can move, or remove it, as needed.
                this.imagensTableAdapter.Fill(this.simplebaseDataSet.Imagens);


            // faz o form abrir em fullscreen
            WindowState = FormWindowState.Maximized;

            if (imgprincTextBox.Text != null)
            {
                picboxlogoempresa.ImageLocation = imgprincTextBox.Text;
            }
            controleacesso();
        }

        private void relogio_Tick(object sender, EventArgs e)
        {
            relogiodig.Text = DateTime.Now.ToLongTimeString();
        }

        private void relogiodig_Click(object sender, EventArgs e)
        {

        }

        private void opçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void picboxlogoempresa_Click(object sender, EventArgs e)
        {

                picboxlogoempresa.ImageLocation = imgprincTextBox.Text;

        }

        private void imagensBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.imagensBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.simplebaseDataSet);

        }

        private void alterarLogomarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracoes frep = new frmConfiguracoes();
            frep.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void reimpressãoVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbrirVenda frep = new frmAbrirVenda();
            frep.Show();
        }

        private void relatóriosDeVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioVendas frep = new frmRelatorioVendas();
            frep.Show();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            frmEntradadeProdutos frep = new frmEntradadeProdutos();
            frep.Show();
        }

        private void fillByacessocodToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.acessoOpTableAdapter.FillByacessocod(this.simplebaseDataSet.AcessoOp, new System.Nullable<int>(((int)(System.Convert.ChangeType(codAcessoToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tslnivel_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.acessoOpTableAdapter.FillByacessocod(this.simplebaseDataSet.AcessoOp, new System.Nullable<int>(((int)(System.Convert.ChangeType(tslnivel.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void tslnivel_VisibleChanged(object sender, EventArgs e)
        {

        }


    }
}
