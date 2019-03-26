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
    public partial class frmConsultaVendas : Form
    {
        public frmConsultaVendas()
        {
            InitializeComponent();
        }

        private void vendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.simplebaseDataSet);

        }

        private void SalvarVendaExcluida()
        {
                if (vendaDataGridView.Rows.Count > 1)
                {
                    for (int i = 0; i <= vendaDataGridView.Rows.Count - 1; i++)
                    {
                        if (Convert.ToString(vendaDataGridView.Rows[i].Cells[0].Value) != "")
                        {
                            int codvenda = Convert.ToInt32(vendaDataGridView.Rows[i].Cells[0].Value); //idvenda
                            string cliente = Convert.ToString(vendaDataGridView.Rows[i].Cells[1].Value); //cliente
                            DateTime data = Convert.ToDateTime(vendaDataGridView.Rows[i].Cells[2].Value); //datavenda
                            string vendedor = Convert.ToString(vendaDataGridView.Rows[i].Cells[3].Value); //vendedor
                            Decimal totalvenda = Convert.ToDecimal(vendaDataGridView.Rows[i].Cells[4].Value); //totalvenda

                            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=simplebase.mdb");

                            string strSQL = "INSERT INTO VendasExcluidas(Codigo,Cliente,Data,Vendedor,TotalVenda) values(@codvendaa,@clientee,@dataa,@vendedorr,@totalvendaa)";

                            OleDbCommand commandd = new OleDbCommand(strSQL);

                            conn.Open();

                            commandd.Parameters.AddWithValue("@codvendaa", codvenda);
                            commandd.Parameters.AddWithValue("@clientee", cliente);
                            commandd.Parameters.AddWithValue("@dataa", data);
                            commandd.Parameters.AddWithValue("@vendedorr", vendedor);
                            commandd.Parameters.AddWithValue("@totalvendaa", totalvenda);

                            try
                            {

                                commandd.Connection = conn;
                                commandd.ExecuteNonQuery();
                            }

                            catch (OleDbException ex)
                            {
                                MessageBox.Show("Erro: " + ex.Message);
                            }

                            finally
                            {
                                conn.Close();
                            }


                        }
                    }
                }
            
            }



        private void frmConsultaVendas_Load(object sender, EventArgs e)
        {

            
            // TODO: This line of code loads data into the 'simplebaseDataSet.VendasExcluidas' table. You can move, or remove it, as needed.
          //  this.vendasExcluidasTableAdapter.Fill(this.simplebaseDataSet.VendasExcluidas);
            // TODO: This line of code loads data into the 'simplebaseDataSet.Senhamestre' table. You can move, or remove it, as needed.
            this.senhamestreTableAdapter.Fill(this.simplebaseDataSet.Senhamestre);
            // TODO: This line of code loads data into the 'simplebaseDataSet.Senhamestre' table. You can move, or remove it, as needed.
            this.senhamestreTableAdapter.Fill(this.simplebaseDataSet.Senhamestre);
            // TODO: This line of code loads data into the 'simplebaseDataSet.Funcionarios' table. You can move, or remove it, as needed.
            this.funcionariosTableAdapter.Fill(this.simplebaseDataSet.Funcionarios);
            // TODO: This line of code loads data into the 'simplebaseDataSet.ProdutoVenda' table. You can move, or remove it, as needed.
            this.produtoVendaTableAdapter.Fill(this.simplebaseDataSet.ProdutoVenda);
            // TODO: This line of code loads data into the 'simplebaseDataSet.Venda' table. You can move, or remove it, as needed.
            this.vendaTableAdapter.Fill(this.simplebaseDataSet.Venda);
            codigoToolStripTextBox.Focus();
            tbpprod.Visible = false;



        }





        private void codigoToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void tsbtnprodvend_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.simplebaseDataSet);
            this.produtoVendaTableAdapter.Fill(this.simplebaseDataSet.ProdutoVenda);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void frmConsultaVendas_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillByConsultaVendaPorCodigoToolStripButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.vendaTableAdapter.FillByConsultaVendaPorCodigo(this.simplebaseDataSet.Venda, ((int)(System.Convert.ChangeType(codigoToolStripTextBox.Text, typeof(int)))));
                this.produtoVendaTableAdapter.FillByFiltrarporidvenda(this.simplebaseDataSet.ProdutoVenda, ((int)(System.Convert.ChangeType(codigoToolStripTextBox.Text, typeof(int)))));

                if ((vendaDataGridView.RowCount > 1) && (produtoVendaDataGridView.RowCount > 1))
                {
                    this.Size = new Size(this.Size.Width, this.Size.Height + 150);
                    button1.Enabled = true;
                    tbpprod.Visible = true;
                }
                else
                {
                    MessageBox.Show("Venda Inexistente ou Deletada.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
            
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnconscodvenda_Click(object sender, EventArgs e)
        {

        }

        
        private void btnexcluir_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja Excluir?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    this.vendaBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.simplebaseDataSet);
                    MessageBox.Show("Venda Excluida com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.vendaTableAdapter.Fill(this.simplebaseDataSet.Venda);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Exclusão Cancelada com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.vendaTableAdapter.Fill(this.simplebaseDataSet.Venda);
            }
        }

        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja Excluir?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    this.produtoVendaBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.simplebaseDataSet);
                    MessageBox.Show("Venda Excluida com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.produtoVendaTableAdapter.Fill(this.simplebaseDataSet.ProdutoVenda);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Exclusão Cancelada com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.produtoVendaTableAdapter.Fill(this.simplebaseDataSet.ProdutoVenda);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnsenha.Visible = true;
            button1.Enabled = false;
            tbpprod.Enabled = false;
            codigoToolStripTextBox.ReadOnly = true;
            fillByConsultaVendaPorCodigoToolStripButton.Enabled = false;
            txtsenhadel.Focus();
        }

        private void deletavenda()
        {
            OleDbConnection con3 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=simplebase.mdb");
            string query = @"DELETE * FROM Venda WHERE Codigo = " + codigoToolStripTextBox.Text;
            OleDbCommand cmdIncluir = new OleDbCommand(query);
            try
            {
                con3.Open();
                cmdIncluir.Connection = con3;
                cmdIncluir.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con3.Close();
            }
        }

        private void atualizaqntitens()
        {
            OleDbConnection con2 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=simplebase.mdb");
            OleDbCommand command2 = new OleDbCommand();
            string query2 = @"UPDATE Items SET Quantidade = Quantidade + {0} WHERE Codigo = {1};";

            try
            {


                for (int i = 0; i < produtoVendaDataGridView.RowCount - 1; i++)
                {
                    int iQuantidade, iCodigo;
                    int.TryParse(produtoVendaDataGridView.Rows[i].Cells["DGVQuant"].Value.ToString(), out iQuantidade);
                    int.TryParse(produtoVendaDataGridView.Rows[i].Cells["IdProdutotab"].Value.ToString(), out iCodigo);
                    string update = string.Format(query2, iQuantidade, iCodigo);
                    try
                    {
                        con2.Open();
                        command2.Connection = con2;
                        command2.CommandText = update;
                        command2.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro" + ex.Message);
                    }
                    finally
                    {
                        con2.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void deletaprodutovenda()
        {
            try
            {
                OleDbConnection con4 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=simplebase.mdb");
                string deletepvenda = @"DELETE * FROM ProdutoVenda WHERE IdVenda = " + codigoToolStripTextBox.Text;
                OleDbCommand cmdExcluir = new OleDbCommand(deletepvenda);
                try
                {
                    con4.Open();
                    cmdExcluir.Connection = con4;
                    cmdExcluir.ExecuteNonQuery();
                }
                catch (Exception subaco)
                {
                    MessageBox.Show("Error: " + subaco.Message);
                }
                finally
                {
                    con4.Close();
                }
            }
            catch (Exception ssss)
            {
                MessageBox.Show("Error: " + ssss.Message);
            }
            finally
            {
                MessageBox.Show("Venda Excluida Com Sucesso");
                this.Dispose();
            }
        }

        private void txtsenhadel_KeyPress(object sender, KeyPressEventArgs e)
        {
         if (e.KeyChar == (char)13)
           {
                try
                    {
                    int result = funcionariosTableAdapter.FillBysenhagerente(simplebaseDataSet.Funcionarios, txtsenhadel.Text);

                    if (result == 1)
                    {
                        DialogResult dlr = MessageBox.Show("Tem certeza que quer excluir essa venda?", "Confirma", MessageBoxButtons.YesNo);
                        if (dlr == DialogResult.Yes)
                        {
                            // se no vendadgv tiver em branco pula e só deleta a venda . n salva venda n atualiza e nem deleta produtovenda
                            if (Convert.ToString(vendaDataGridView.Rows[0].Cells[2].Value) != "")
                            {
                                SalvarVendaExcluida();
                                deletavenda();
                                atualizaqntitens();
                                deletaprodutovenda();
                            }
                            else
                            {
                                deletavenda();
                                MessageBox.Show("Venda deletada com Sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                        }
                        else
                        {
                            pnsenha.Visible = false;
                            button1.Enabled = true;
                            tbpprod.Enabled = true;
                            codigoToolStripTextBox.ReadOnly = false;
                            fillByConsultaVendaPorCodigoToolStripButton.Enabled = true;
                            codigoToolStripTextBox.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Senha Inválida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtsenhadel.Clear();
                    }
                }
           catch (OleDbException)
            {
            }
           finally
            {                             
            }
         }
        }


    //    private Boolean ValidarSenha()
    //    {
            


      //      if (txtsenhadel.Text == "5784640")
      //          return true;
      //      return false;
    //    }



        private void txtsenhadel_TextChanged(object sender, EventArgs e)
        {

        }

        private void codigoToolStripTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void codigoToolStripTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                fillByConsultaVendaPorCodigoToolStripButton_Click(sender, e);
            }
        }

        private void codigoToolStripTextBox_Click_1(object sender, EventArgs e)
        {

        }

        private void btnvendasexcluidas_Click(object sender, EventArgs e)
        {
            frmVendasExcluidas frep = new frmVendasExcluidas();
            frep.Show();
        }



    }
}
