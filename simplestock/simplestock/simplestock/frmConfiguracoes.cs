using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace simplestock
{
    public partial class frmConfiguracoes : Form
    {

        frmPrincipal frmprinc = Application.OpenForms["frmPrincipal"] as frmPrincipal;

        public frmConfiguracoes()
        {
            InitializeComponent();
        }

        private void frmOpcoes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'simplebaseDataSet.AcessoOp' table. You can move, or remove it, as needed.
            this.acessoOpTableAdapter.Fill(this.simplebaseDataSet.AcessoOp);
            // TODO: This line of code loads data into the 'simplebaseDataSet.Acesso' table. You can move, or remove it, as needed.
            this.acessoTableAdapter.Fill(this.simplebaseDataSet.Acesso);
            // TODO: This line of code loads data into the 'simplebaseDataSet.Senhamestre' table. You can move, or remove it, as needed.
            this.senhamestreTableAdapter.Fill(this.simplebaseDataSet.Senhamestre);
            // TODO: This line of code loads data into the 'simplebaseDataSet.Imagens' table. You can move, or remove it, as needed.
            this.imagensTableAdapter.Fill(this.simplebaseDataSet.Imagens);
            txtnovasenha.Enabled = false;
            acessoOpDataGridView.Visible = false;
            psenhamest.Visible = false;
            txtdesc.Enabled = false;
        }



        private void imagensBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.imagensBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.simplebaseDataSet);
            
        }

        

        private void btnalterar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
            try
            {
                this.imagensBindingSource.AddNew();
                if (frmprinc != null)
                {
                    frmprinc.picboxlogoempresa.Image = null;
                }

           //     openFileDialog1.ShowDialog();

                // cria img a partir de url
                Bitmap bmp = new Bitmap(openFileDialog1.FileName);
                // padronizar tamanho da imagem.
                Bitmap bmp2 = new Bitmap(bmp, frmprinc.picboxlogoempresa.Size);



                // inseri imagem no picbox
                frmprinc.picboxlogoempresa.Image = bmp2;

                // salva a imagem na pasta informada (imguser) + inseri no nome da imagem (imgindex) + extensão da imagem
                frmprinc.picboxlogoempresa.Image.Save(Application.StartupPath.ToString() + "\\imguser\\" + "imgindex" + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);

                // joga url dentro do textobox
                txturlimg.Text = Application.StartupPath.ToString() + "\\imguser\\" + "imgindex" + ".jpeg";

                // comandos para salvar o registro
                imagensBindingNavigatorSaveItem_Click(sender, e);
            }
            catch (Exception)
            {
                
            }
            }
                        else
                        {
                            MessageBox.Show("Operação cancelada com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imagensBindingNavigatorSaveItem_Click(sender, e);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnliberar_Click(object sender, EventArgs e)
        {
            int result = senhamestreTableAdapter.FillBysenhamestre(simplebaseDataSet.Senhamestre, txtlibera.Text);
            if (result == 1)
            {
                txtnovasenha.Enabled = true;
                txtnovasenha.Focus();
                txtnovasenha.Clear();
            }
            else
            {
                txtnovasenha.Enabled = false;
                MessageBox.Show("Senha incorreta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            //conexao banco de dados, comando update
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=simplebase.mdb");
            string strSQL = @"UPDATE Senhamestre SET Senha=@novasenha";
            OleDbCommand cmdIncluir = new OleDbCommand(strSQL, con);

            // cria parametro novasenha que pega o valor do txtnovasenha.Text
            cmdIncluir.Parameters.AddWithValue("@novasenha", txtnovasenha.Text);

            try
            {
                con.Open();
                cmdIncluir.Connection = con;
                cmdIncluir.ExecuteNonQuery();
                MessageBox.Show("Senha alterada com sucesso.");
            }

            catch (OleDbException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            finally
            {
                con.Close();
            }



            txtnovasenha.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void salvarimg()
        {
            //conexao banco de dados, comando update
            OleDbConnection conIMG = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=simplebase.mdb");
            string strIMG = @"UPDATE Imagens SET imgprinc='" + txturlimg.Text + "'WHERE Cod=" + label4.Text;
            OleDbCommand cmdIMG = new OleDbCommand(strIMG, conIMG);

            // cria parametro pra pegar valor dos textboxs
            //    cmdIMG.Parameters.AddWithValue("@imgprinc", txturlimg.Text);

            try
            {
                conIMG.Open();
                cmdIMG.Connection = conIMG;
                cmdIMG.ExecuteNonQuery();
                MessageBox.Show("Alterações Salvas com Sucesso.");
            }

            catch (OleDbException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            finally
            {
                conIMG.Close();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            salvarimg();
        }

        private void codAcessoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByAcessoToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void txtcod_SelectedIndexChanged(object sender, EventArgs e)
        {
            acessoOpDataGridView.Visible = true;
            int nome = Convert.ToInt32(txtcod.Text);

            this.acessoOpTableAdapter.FillByacessocod(simplebaseDataSet.AcessoOp, nome);
        }

        private void acessoOpDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= acessoOpDataGridView.Rows.Count - 1; i++)
            {
                String cadastro = Convert.ToString(acessoOpDataGridView.Rows[i].Cells[1].Value);
                String consulta = Convert.ToString(acessoOpDataGridView.Rows[i].Cells[2].Value);
                String relatorio = Convert.ToString(acessoOpDataGridView.Rows[i].Cells[3].Value);
                String configuracoes = Convert.ToString(acessoOpDataGridView.Rows[i].Cells[4].Value);
                String backup = Convert.ToString(acessoOpDataGridView.Rows[i].Cells[5].Value);
                String venda = Convert.ToString(acessoOpDataGridView.Rows[i].Cells[6].Value);
                String entrada = Convert.ToString(acessoOpDataGridView.Rows[i].Cells[7].Value);
            

                //conexao banco de dados, comando update
                OleDbConnection conAc = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=simplebase.mdb");
                string strAc = @"UPDATE AcessoOp SET Cadastro=@cadastro2,Consulta=@consulta2,Relatorio=@relatorio2,Configuracoes=@configuracoes2,Backup=@backup2,Venda=@venda2,Entrada=@entrada2 WHERE CodAcesso=" + txtcod.Text;
                OleDbCommand cmdAc = new OleDbCommand(strAc, conAc);


                cmdAc.Parameters.AddWithValue("@cadastro2", cadastro);
                cmdAc.Parameters.AddWithValue("@consulta2", consulta);
                cmdAc.Parameters.AddWithValue("@relatorio2", relatorio);
                cmdAc.Parameters.AddWithValue("@configuracoes2", configuracoes);
                cmdAc.Parameters.AddWithValue("@backup2", backup);
                cmdAc.Parameters.AddWithValue("@venda2", venda);
                cmdAc.Parameters.AddWithValue("@entrada2", entrada);

            
                try
                {
                    conAc.Open();
                    cmdAc.Connection = conAc;
                    cmdAc.ExecuteNonQuery();
                    MessageBox.Show("Alterações Salvas com Sucesso.");
                }

                catch (OleDbException ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }

                finally
                {
                    conAc.Close();
                }
            }
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                int result = senhamestreTableAdapter.FillBysenhamestre(simplebaseDataSet.Senhamestre, txtsenha.Text);
                if (result == 1)
                {
                    txtdesc.Enabled = true;
                    txtdesc.Focus();
                    txtdesc.Clear();
                }
                else
                {
                    txtdesc.Enabled = false;
                    MessageBox.Show("Senha incorreta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            psenhamest.Visible = true;
            txtsenha.Focus();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //conexao banco de dados, comando update
            OleDbConnection conDesc = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=simplebase.mdb");
            string strDesc = @"UPDATE Imagens SET Desconto='" + txtdesc.Text + "'WHERE Cod=" + label4.Text;
            OleDbCommand cmdDesc = new OleDbCommand(strDesc, conDesc);

            try
            {
                conDesc.Open();
                cmdDesc.Connection = conDesc;
                cmdDesc.ExecuteNonQuery();
                txtdesc.Enabled = false;
                MessageBox.Show("Desconto Máximo Alterado Com Sucesso!");
            }

            catch (OleDbException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            finally
            {
                conDesc.Close();
                
            }
        }
    }
}
