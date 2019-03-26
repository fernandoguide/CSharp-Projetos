using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Runtime.InteropServices;

namespace simplestock
{
    public partial class frmEntradadeProdutos : Form
    {
        public frmEntradadeProdutos()
        {
            InitializeComponent();
        }

        static int kokenome;


        private void frmEntradadeProdutos_Load(object sender, EventArgs e)
        {
            this.entradaProdBindingSource.AddNew();

        //    entradaProdBindingNavigatorSaveItem_Click_1(sender, e);
            IniFile teste = new IniFile(@"./ini.ini");
            string codigo = teste.IniReadValue("comanda", "numero");
            kokenome = int.Parse(codigo);
            txtcodentrada.Text = codigo;

            alterardata();
            bloquearitems();

            // TODO: This line of code loads data into the 'simplebaseDataSet.Entrada' table. You can move, or remove it, as needed.
            this.entradaTableAdapter.Fill(this.simplebaseDataSet.Entrada);
            // TODO: This line of code loads data into the 'simplebaseDataSet.EntradaProd' table. You can move, or remove it, as needed.
         //   this.entradaProdTableAdapter.Fill(this.simplebaseDataSet.EntradaProd);
            // TODO: This line of code loads data into the 'simplebaseDataSet.Fornecedores' table. You can move, or remove it, as needed.
            this.fornecedoresTableAdapter.Fill(this.simplebaseDataSet.Fornecedores);
            // TODO: This line of code loads data into the 'simplebaseDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.simplebaseDataSet.Items);
            // TODO: This line of code loads data into the 'simplebaseDataSet.Entrada' table. You can move, or remove it, as needed.
            this.entradaTableAdapter.Fill(this.simplebaseDataSet.Entrada);
           
            this.entradaBindingSource.MoveLast();
            this.entradaProdBindingSource.MoveLast();


         
            limpacampos();
            alterardata();
            
        }
        private void alterardata()
        {
            dataDateTimePicker.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        public void setCodigoAndNomeProduto(int codigo, String nome, String marca, Double valcust)
        {
            txtcodprod.Text = codigo.ToString();
            cbnomeproduto.Text = nome;
            txtmarca.Text = marca;
            ValorProdutoComboBox.Text = valcust.ToString();
          //  ValorProdutoComboBox.Text = valor.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProdutosPedido frep = new frmProdutosPedido(this);
            frep.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.simplebaseDataSet.EntradaProd

            String codProdd;
            codProdd = txtcodprod.Text;

            //OLHA SE HÁ VALORES REPETIDOS.
            for (int t = 0; t < entradaProdDataGridView.Rows.Count; t++)
            {
                if (Convert.ToString(entradaProdDataGridView.Rows[t].Cells["CodProd"].Value) == codProdd)
                {
                    MessageBox.Show("Produto já foi inserido.");
                    return;
                }
            }

            //VÊ SE CAMPOS ESTÃO PREENCHIDOS E ADICIONE A LINHA NO DGV
            if ((EmEstoqueComboBox.Text != "") & (ValorProdutoComboBox.Text != ""))
            {
                try
                {
                    entradaProdDataGridView.Rows.Add(Convert.ToInt32(txtcodprod.Text), Convert.ToString(cbnomeproduto.Text), Convert.ToString(txtmarca.Text), Convert.ToInt32(EmEstoqueComboBox.Text), Convert.ToDecimal(ValorProdutoComboBox.Text));

                    decimal total = 0;

                    for (int i = 0; i < entradaProdDataGridView.RowCount - 0; i++)
                    {

                        // faz a conta do subtotal e do valor total
                        DataGridViewRow row = entradaProdDataGridView.Rows[i];
                        string valueA = row.Cells["ValorCusto"].Value.ToString();
                        string valueB = row.Cells["Qnt"].Value.ToString();
                        decimal valorA, valorB;
                        if (decimal.TryParse(valueA, out valorA) && decimal.TryParse(valueB, out valorB))
                        {
                            row.Cells["Subtotal"].Value = (valorA * valorB).ToString("N2");
                            total += valorA * valorB;
                            ValortotalTextBox.Text = total.ToString("C");
                        }
                    }
                }
                catch (Exception)
                {
                  //  MessageBox.Show("Erro:" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Insira Quantidade e Valor de Custo");
            }


            //limparcampos
            limpacampos();


        }

        private void limpacampos()
        {
            EmEstoqueComboBox.Text = "";
            ValorProdutoComboBox.Text = "";
            txtcodprod.Text = "";
            cbnomeproduto.Text = "";
            txtmarca.Text = "";
            txtcodprop.Text = "";
        }


        private void codigoLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnnovaentrada_Click(object sender, EventArgs e)
        {
            
        }




        private void insertentradaprod()
        {
            for (int i = 0; i <= entradaProdDataGridView.Rows.Count - 1; i++)
                    {
                        if (Convert.ToString(entradaProdDataGridView.Rows[i].Cells[0].Value) != "")
                        {
                            int idvenda = Convert.ToInt32(entradaProdDataGridView.Rows[i].Cells[0].Value); //idvenda
                            string produto = Convert.ToString(entradaProdDataGridView.Rows[i].Cells[1].Value); //produto
                            string marca = Convert.ToString(entradaProdDataGridView.Rows[i].Cells[2].Value); //marca
                            int qnt = Convert.ToInt32(entradaProdDataGridView.Rows[i].Cells[3].Value); //qnt
                            Double valorcusto = Convert.ToDouble(entradaProdDataGridView.Rows[i].Cells[4].Value); //valorcusto
                            Double subtotal = Convert.ToDouble(entradaProdDataGridView.Rows[i].Cells[5].Value); //subtotal


                            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=simplebase.mdb");

                            string strSQL = "INSERT INTO EntradaProd(IdProd,Produto,Marca,QntAdq,ValorCusto,Subtotal,CodigoEntrada) values(@idvenda,@produto,@marca,@qnt,@valorcusto,@subtotal,'" + txtcodentrada.Text + "')";

                            OleDbCommand commandd = new OleDbCommand(strSQL);

                            conn.Open();

                            commandd.Parameters.AddWithValue("@idvenda", idvenda);
                            commandd.Parameters.AddWithValue("@produto", produto);
                            commandd.Parameters.AddWithValue("@marca", marca);
                            commandd.Parameters.AddWithValue("@qnt", qnt);
                            commandd.Parameters.Add("@valorcusto", OleDbType.Double).Value = (double)valorcusto;
                            commandd.Parameters.Add("@subtotal", OleDbType.Double).Value = (double)subtotal;


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
                        else
                        {
                        }

                    }

                }

        private void insertentrada()
        {
                    OleDbConnection conent = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=simplebase.mdb");

                    string strEnt = "INSERT INTO Entrada(Fornecedor,NotaFiscal,Data,CodigEntrada) " + " VALUES('" + razaoSocialComboBox.Text + "','" + notaFiscalTextBox.Text + "','" + dataDateTimePicker.Text + "','" + txtcodentrada.Text + "')";

                    OleDbCommand commandent = new OleDbCommand(strEnt);

                    conent.Open();
          

                    try
                    {

                        commandent.Connection = conent;
                        commandent.ExecuteNonQuery();
                    }

                    catch (OleDbException ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }

                    finally
                    {
                        conent.Close();
                    }
                
        }

        private void atualizarquantidade()
        {
            OleDbConnection con2 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=simplebase.mdb");
            OleDbCommand command2 = new OleDbCommand();
            string query2 = @"UPDATE Items SET Quantidade = Quantidade + {0} WHERE Codigo = {1};";

            try
            {


                for (int i = 0; i < entradaProdDataGridView.RowCount - 1; i++)
                {
                    int iQuantidade, iCodigo;
                    int.TryParse(entradaProdDataGridView.Rows[i].Cells["Qnt"].Value.ToString(), out iQuantidade);
                    int.TryParse(entradaProdDataGridView.Rows[i].Cells["CodProd"].Value.ToString(), out iCodigo);
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
                MessageBox.Show("Erro" + ex.Message);
            }
        }


        private void entradaProdBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.entradaProdBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.simplebaseDataSet);

        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Você está finalizando a entrada se fizer isso não poderá mais alterar, tem certeza?", "", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {


                atualizarquantidade();
                insertentradaprod();
                insertentrada();
                MessageBox.Show("Entrada realizada com Sucesso!", "");

                IniFile teste = new IniFile(@"./ini.ini");
                int cod = kokenome + 1;
                teste.IniWriteValue("comanda", "numero", cod.ToString());

                this.Close();
            }
            else
            {
                return;
            }
            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bloquearitems()
        {
            EmEstoqueComboBox.Enabled = false;
            ValorProdutoComboBox.Enabled = false;
            btnaddprod.Enabled = false;
            btninserirprod.Enabled = false;
            btnfinalizar.Enabled = false;
            razaoSocialComboBox.Enabled = false;
            dataDateTimePicker.Enabled = false;
            notaFiscalTextBox.Enabled = false;
            entradaProdDataGridView.Enabled = false;
            txtcodprop.Enabled = false;
        }

        private void desbloquearitems()
        {
            EmEstoqueComboBox.Enabled = true;
            ValorProdutoComboBox.Enabled = true;
            btnaddprod.Enabled = true;
            btninserirprod.Enabled = true;
            btnfinalizar.Enabled = true;
            razaoSocialComboBox.Enabled = true;
            dataDateTimePicker.Enabled = true;
            notaFiscalTextBox.Enabled = true;
            entradaProdDataGridView.Enabled = true;
            txtcodprop.Enabled = true;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            desbloquearitems();
            alterardata();
            txtcodprop.Focus();
        }

        private void entradaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.entradaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.simplebaseDataSet);
        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            this.entradaBindingSource.AddNew();
        }


        private void ValorProdutoComboBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValorProdutoComboBox_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void ValorProdutoComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == ',') && !(e.KeyChar == Convert.ToChar(8)))
            {
                e.Handled = true;
            }
        }

        private void codigoTextBox_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (e.KeyChar == (char)13)
                {
                            try
                            {
                                this.itemsTableAdapter.FillBycodprop(this.simplebaseDataSet.Items, new System.Nullable<int>(((int)(System.Convert.ChangeType(txtcodprop.Text, typeof(int))))));
                                EmEstoqueComboBox.Focus();
                            }
                            catch (System.Exception ex)
                            {
                                System.Windows.Forms.MessageBox.Show(ex.Message);
                            }

                            if (txtcodprod.Text == null)
                            {
                                MessageBox.Show("Produto Inexistente!");
                                txtcodprod.Focus();
                                return;
                            }
                }
            
        }

        private void EmEstoqueComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btninserirprod.Focus();
            }
        }
        }

    }

