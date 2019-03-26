using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Common;

namespace simplestock
{
    public partial class frmVenda : Form
    {



        public frmVenda()
        {
            InitializeComponent();
        }

        frmPrincipal frmprinc = Application.OpenForms["frmPrincipal"] as frmPrincipal;


        private void bloqueartxtbox()
        {
            cbnomeproduto.Enabled = false;
            txtquantidade.Enabled = false;
            txtcliente.Enabled = false;
            cbdata.Enabled = false;
            cbvendedor.Enabled = false;
            produtoVendaDataGridView.Enabled = false;
        }

        private void limpartxtbox()
        {
            cbnomeproduto.Text = "";
            txtquantidade.Text = "1";
            txtcodprod.Text = "";
            ValorProdutoComboBox.Text = "";
            EmEstoqueComboBox.Text = "";
            txtcodprop.Text = "";
        }

        public bool constatus;
        private OleDbConnection con;

        private void vendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.simplebaseDataSet);

        }


        private void salvacliente()
        {
            OleDbConnection concli = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=simplebase.mdb");

            string strcli = @"UPDATE ProdutoVenda SET Cliente='" + txtcliente.Text + "'where IdVenda=" + txtcodigovenda.Text;

            OleDbCommand commancli = new OleDbCommand(strcli);

            concli.Open();

            try
            {
                commancli.Connection = concli;
                commancli.ExecuteNonQuery();
            }

            catch (OleDbException ex)
            {
                //  MessageBox.Show("Erro: " + ex.Message);
            }

            finally
            {
                concli.Close();
            }
        }

        private void salvarvendedor()
        {
            OleDbConnection conven = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=simplebase.mdb");

            string strven = @"UPDATE ProdutoVenda SET Vendedor='" + cbvendedor.Text + "'where IdVenda=" + txtcodigovenda.Text;

            OleDbCommand commanven = new OleDbCommand(strven);

            conven.Open();

            try
            {
                commanven.Connection = conven;
                commanven.ExecuteNonQuery();
            }

            catch (OleDbException ex)
            {
                //  MessageBox.Show("Erro: " + ex.Message);
            }

            finally
            {
                conven.Close();
            }
        }

        private void salvacbdata()
        {

            OleDbConnection condata = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=simplebase.mdb");

            string strdata = @"UPDATE ProdutoVenda SET DataVenda='" + cbdata.Text + "'where IdVenda=" + txtcodigovenda.Text;

            OleDbCommand commandata = new OleDbCommand(strdata);

            condata.Open();

            try
            {
                commandata.Connection = condata;
                commandata.ExecuteNonQuery();
            }

            catch (OleDbException ex)
            {
                //  MessageBox.Show("Erro: " + ex.Message);
            }

            finally
            {
                condata.Close();
            }
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'simplebaseDataSet.Imagens' table. You can move, or remove it, as needed.
            this.imagensTableAdapter.Fill(this.simplebaseDataSet.Imagens);
            this.vendaBindingSource.AddNew();
            vendaBindingNavigatorSaveItem_Click(sender, e);


            // TODO: This line of code loads data into the 'simplebaseDataSet.Funcionarios' table. You can move, or remove it, as needed.
            this.funcionariosTableAdapter.Fill(this.simplebaseDataSet.Funcionarios);
            // TODO: This line of code loads data into the 'simplebaseDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.simplebaseDataSet.Items);
            // TODO: This line of code loads data into the 'simplebaseDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.simplebaseDataSet.Clientes);
            // TODO: This line of code loads data into the 'simplebaseDataSet.ProdutoVenda' table. You can move, or remove it, as needed.
            this.produtoVendaTableAdapter.Fill(this.simplebaseDataSet.ProdutoVenda);
            // TODO: This line of code loads data into the 'simplebaseDataSet.Venda' table. You can move, or remove it, as needed.
            this.vendaTableAdapter.Fill(this.simplebaseDataSet.Venda);
            // TODO: This line of code loads data into the 'simplebaseDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.simplebaseDataSet.Clientes);
            // TODO: This line of code loads data into the 'simplebaseDataSet.Venda' table. You can move, or remove it, as needed.
            this.vendaTableAdapter.Fill(this.simplebaseDataSet.Venda);

            this.vendaBindingSource.MoveLast();
            constatus = false;
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=simplebase.mdb");
            cbnomeproduto.Enabled = false;
            txtquantidade.Text = "1";
            alterardata();
            cbdata.Enabled = false;
            ValorProdutoComboBox.Enabled = false;
            cbvendedor.Text = frmprinc.tslnome.Text;
            txtcodprod.Text = "";
            txtcodprop.Focus();
            txtcliente.Text = "Avulso";
        }


        private void vendaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.vendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.simplebaseDataSet);

        }


        private void produtovendaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoVendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.simplebaseDataSet);

        }

        private void valorespetidos()
        {

        }

        private void erroprodutonadd()
        {
            if ((cbnomeproduto.Text == "") & (txtcodprod.Text == ""))
            {
                MessageBox.Show("Adicione algum produto antes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void errosemqnt()
        {
            if (txtquantidade.Text == "")
            {
                MessageBox.Show("Insira a Quantidade", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quantidadepequena()
        {

        }


        private void contasubtotal()
        {
            decimal total = 0;
            for (int i = 0; i < produtoVendaDataGridView.RowCount - 0; i++)
            {
                DataGridViewRow row = produtoVendaDataGridView.Rows[i];
                string valueA = row.Cells["Valor"].Value.ToString();
                string valueB = row.Cells["Quantidade"].Value.ToString();
                decimal valorA, valorB;
                if (decimal.TryParse(valueA, out valorA) && decimal.TryParse(valueB, out valorB))
                {
                    row.Cells["dgvsubtotal"].Value = (valorA * valorB).ToString("0.00");
                    total += valorA * valorB;
                    valorTotalTextBox.Text = total.ToString("0.00");
                }
            }
        }


        private void btninserirproduto_Click(object sender, EventArgs e)
        {
            if (txtcodprod.Text == "")
            {
                MessageBox.Show("Insira algum produto antes.");
                return;
            }
            else
            {
                errosemqnt();

                string Produto = this.simplebaseDataSet.Items.FindByCodigo(Convert.ToInt32(txtcodprod.Text)).Produto;

                int txtquant;
                txtquant = Convert.ToInt32(txtquantidade.Text);
                txtquant = int.Parse(txtquantidade.Text);

                int emestoq;
                emestoq = Convert.ToInt32(EmEstoqueComboBox.Text);
                emestoq = int.Parse(EmEstoqueComboBox.Text);


                string codProd = Convert.ToString(txtcodprod.Text);



                if ((EmEstoqueComboBox.Text != "0") && (txtquant <= emestoq))
                {
                    for (int t = 0; t < produtoVendaDataGridView.Rows.Count; t++)
                    {
                        if (Convert.ToString(produtoVendaDataGridView.Rows[t].Cells["codigProduto"].Value) == codProd)
                        {
                            MessageBox.Show("Produto já está no carrinho");

                            ValorProdutoComboBox.Text = "";
                            txtcodprod.Clear();
                            cbnomeproduto.Text = "";
                            EmEstoqueComboBox.Text = "";
                            txtquantidade.Text = "1";
                            txtcodprop.Focus();


                        }
                    }
                    try
                    {

                        // inseri oque está nos textbox no datagrid


                        this.simplebaseDataSet.ProdutoVenda.Rows.Add(null, Convert.ToInt32(txtcodigovenda.Text), Convert.ToInt32(txtcodprod.Text, null), null, Convert.ToString(cbnomeproduto.Text), Convert.ToInt32(txtquantidade.Text), Convert.ToDecimal(ValorProdutoComboBox.Text));
                        limpartxtbox();





                        // faz a conta do subtotal e do valor total

                        contasubtotal();

                    }
                    catch (Exception)
                    {

                        return;
                    }
                }



                else
                {
                    MessageBox.Show("Produto sem estoque ou quantidade desejada é maior que o estoque atual.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcodprop.Focus();
                }


                limpartxtbox();
                txtquantidade.Text = "1";
               
            }
            
        }

        // altera a data do cbdata.text para a data atual.
        private void alterardata()
        {
            cbdata.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            alterardata();


            if (cbvendedor.Text != "")
            {
                if (produtoVendaDataGridView.Rows.Count > 1)
                {

                    // vendaBindingNavigatorSaveItem_Click_1(sender, e);
                    produtovendaBindingNavigatorSaveItem_Click_1(sender, e);
                    //insertprodutovendagrid();


                    salvacbdata();
                    salvacliente();
                    salvarvendedor();
                   

                    if (constatus == false)
                    {
                        con.Open();

                        constatus = true;
                    }

                    string mensagem = "Total da venda é de : {0}\nFinalizar venda?";

                    if (MessageBox.Show(string.Format(mensagem, valorTotalTextBox.Text), "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) != DialogResult.OK)
                    {

                        return;

                    }
                    try
                    {
                        string codigovenda = txtcodigovenda.Text;
                        txtcodigovenda.Text = codigovenda;
                        Int32.Parse(codigovenda);

                       // Double totavenda = Convert.ToDouble(valorTotalTextBox.Text);

                        OleDbCommand command = new OleDbCommand();
                        //atualiza quantidade de items(dabaixa)
                        string query = @"UPDATE Items SET Quantidade = Quantidade - {0} WHERE Codigo = {1};";
                        // adiciona dados ao banco de dados
                        string strSQL = @"UPDATE Venda SET Cliente='" + txtcliente.Text + "',Data='" + cbdata.Text + "',Vendedor='" + cbvendedor.Text + "',TotalVenda='" + valorTotalTextBox.Text + "'where Codigo=" + txtcodigovenda.Text;

                        OleDbCommand cmdIncluir = new OleDbCommand(strSQL);

                     //   cmdIncluir.Parameters.Add("@totvenda", OleDbType.Double).Value = (double)totavenda;


                        for (int baixa = 0; baixa < produtoVendaDataGridView.RowCount - 1; baixa++)
                        {
                            int iQuantidade, iCodigo;
                            int.TryParse(produtoVendaDataGridView.Rows[baixa].Cells["Quantidade"].Value.ToString(), out iQuantidade);
                            int.TryParse(produtoVendaDataGridView.Rows[baixa].Cells["codigProduto"].Value.ToString(), out iCodigo);
                            string update = string.Format(query, iQuantidade, iCodigo);
                            cmdIncluir.Connection = con;
                            command.Connection = con;
                            command.CommandText = update;
                            command.ExecuteNonQuery();
                            cmdIncluir.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro:" + ex.Message);
                    }


                    DialogResult pergv = MessageBox.Show("Venda Realizada Com Sucesso! Deseja Imprimir a Venda?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (pergv == DialogResult.Yes)
                    {
                        frmImpressaoVenda frep = new frmImpressaoVenda();
                        frep.Show();
                    }
                    else
                    {

                        this.Close();

                    }

                    this.Close();

                }
                else
                {
                    MessageBox.Show("Insira Algum Produto!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            else
            {
                MessageBox.Show("Insira Todos os Dados para Finalizar a Venda!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }



        private void txtquantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValorProdutoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValorProdutoComboBox.Enabled = false;
        }

        private void EmEstoqueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmEstoqueComboBox.Enabled = false;
        }

        private void nomeProdutoComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtcodprod.Text = cbnomeproduto.SelectedValue.ToString();
        }

        private void codProdutoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeProdutoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.produtoVendaBindingSource.RemoveCurrent();
            }
            catch (Exception)
            {
                MessageBox.Show("Adicione algum produto antes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void btnaddproduto_Click(object sender, EventArgs e)
        {
            txtcodprop.Focus();
            frmProdutos frep = new frmProdutos(this);
            frep.Show();

        }

        public void setNomeCliente(int codigo, String nome)
        {
            txtcliente.Text = nome;

        }

        public void setCodigoAndNomeProduto(int codigo)
        {

            txtcodprop.Text = codigo.ToString();


        }

        private void valorTotalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlocalizarcliente_Click(object sender, EventArgs e)
        {
            frmClientes frep = new frmClientes(this);
            frep.Show();
        }

        private void vendedorLabel_Click(object sender, EventArgs e)
        {

        }

        private void txtcliente_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.simplebaseDataSet);
            this.vendaTableAdapter.Fill(this.simplebaseDataSet.Venda);
        }

        private void cbdata_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
            i = 0;
        }
        //daquiprabaixo impressão
        int i = 0;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
        Double valorprod;

        private void ValorProdutoComboBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                valorprod = Double.Parse(ValorProdutoComboBox.Text);

                ValorProdutoComboBox.Text = valorprod.ToString("0.00");
            }
            catch (Exception)
            {

            }
        }

        private void ValorProdutoComboBox_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void frmVenda_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void frmVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                frmProdutos frep = new frmProdutos(this);
                frep.Show();
            }
        }

        private void txtcodprop_KeyPress(object sender, KeyPressEventArgs e)
        {

                if (e.KeyChar == (char)13)
                {
                    if (txtcodprop.Text != "")
                    {
                    int result = itemsTableAdapter.FillBycodprop(simplebaseDataSet.Items, Convert.ToInt32(txtcodprop.Text));

                    if (result == 1)
                    {
                        try
                        {
                            this.itemsTableAdapter.FillBycodprop(this.simplebaseDataSet.Items, new System.Nullable<int>(((int)(System.Convert.ChangeType(txtcodprop.Text, typeof(int))))));
                        }
                        catch (System.Exception ex)
                        {
                            System.Windows.Forms.MessageBox.Show(ex.Message);
                        }
                        txtcodprop.Text = null;
                        txtquantidade.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Valor nulo ou produto não encontrado.", "Erro!");
                        return;
                    }
                    }
                    else
                    {
                        MessageBox.Show("Produto não cadastrado");
                        txtcodprop.Text = null;
                        txtcodprop.Focus();
                    }
                }

        }

        private void fillBycodpropToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.itemsTableAdapter.FillBycodprop(this.simplebaseDataSet.Items, new System.Nullable<int>(((int)(System.Convert.ChangeType(codPropToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnnovavenda_Click(object sender, EventArgs e)
        {
            this.vendaBindingSource.AddNew();
            vendaBindingNavigatorSaveItem_Click(sender, e);
            this.vendaBindingSource.MoveLast();
        }


        private void txtdescporc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            try
            {
                if (txtdescporc.Text != null)
                {
                    int desconto = Convert.ToInt32(txtdescporc.Text);
                    int descmax = Convert.ToInt32(lbldesc.Text);

                    if (desconto <= descmax)
                    {
                        if (txtdescporc != null)
                        {
                            for (int i = 0; i < produtoVendaDataGridView.RowCount - 1; i++)
                            {
                                double val = Convert.ToDouble(produtoVendaDataGridView.Rows[i].Cells["Valor"].Value);
                                double porc = Convert.ToDouble(txtdescporc.Text) / 100;
                                double totalfim = ((val * Convert.ToDouble(produtoVendaDataGridView.Rows[i].Cells["Quantidade"].Value) - (porc * (val * Convert.ToDouble(produtoVendaDataGridView.Rows[i].Cells["Quantidade"].Value)))));

                                produtoVendaDataGridView.Rows[i].Cells["dgvsubtotal"].Value = Convert.ToString(totalfim.ToString("0.00"));
                                produtoVendaDataGridView.Rows[i].Cells["Desconto"].Value = (val * Convert.ToDouble(produtoVendaDataGridView.Rows[i].Cells["Quantidade"].Value)) - Convert.ToDouble(produtoVendaDataGridView.Rows[i].Cells["dgvsubtotal"].Value);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ops! Coloque algum desconto antes!");
                            return;
                        }


                        // soma a coluna subtotal novamente
                        double soma = 0;
                        foreach (DataGridViewRow dr in produtoVendaDataGridView.Rows)
                            soma += Convert.ToDouble(dr.Cells["dgvsubtotal"].Value);
                        valorTotalTextBox.Text = Convert.ToString(soma.ToString("0.00"));
                        btnsalvar.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Desconto Acima de desconto máximo cadastrado");
                        txtdescporc.Text = null;
                        txtdescporc.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Insira algum desconto antes!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desconto não permitido. Erro:" + ex.Message);
            }
        }

        private void produtoVendaDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            txtcodprop.Focus();
        }

        private void txtdescporc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1.Focus();
            }
        }

        private void txtquantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btninserirproduto.Focus();
            }
        }






    }
}



