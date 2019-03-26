namespace simplestock
{
    partial class frmEntradadeProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label produtoLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label valorCustoLabel;
            System.Windows.Forms.Label notaFiscalLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntradadeProdutos));
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simplebaseDataSet = new simplestock.simplebaseDataSet();
            this.itemsTableAdapter = new simplestock.simplebaseDataSetTableAdapters.ItemsTableAdapter();
            this.btnaddprod = new System.Windows.Forms.Button();
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedoresTableAdapter = new simplestock.simplebaseDataSetTableAdapters.FornecedoresTableAdapter();
            this.tableAdapterManager = new simplestock.simplebaseDataSetTableAdapters.TableAdapterManager();
            this.razaoSocialComboBox = new System.Windows.Forms.ComboBox();
            this.fornecedoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmEstoqueComboBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodprop = new System.Windows.Forms.TextBox();
            this.ValorProdutoComboBox = new System.Windows.Forms.MaskedTextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.cbnomeproduto = new System.Windows.Forms.TextBox();
            this.txtcodprod = new System.Windows.Forms.TextBox();
            this.btninserirprod = new System.Windows.Forms.Button();
            this.entradaProdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entradaProdTableAdapter = new simplestock.simplebaseDataSetTableAdapters.EntradaProdTableAdapter();
            this.entradaProdDataGridView = new System.Windows.Forms.DataGridView();
            this.CodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entradaTableAdapter = new simplestock.simplebaseDataSetTableAdapters.EntradaTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtcodentrada = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.notaFiscalTextBox = new System.Windows.Forms.TextBox();
            this.ValortotalTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.entradaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.entradaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillBycodpropToolStrip = new System.Windows.Forms.ToolStrip();
            this.codPropToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.codPropToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBycodpropToolStripButton = new System.Windows.Forms.ToolStripButton();
            codigoLabel = new System.Windows.Forms.Label();
            produtoLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valorCustoLabel = new System.Windows.Forms.Label();
            notaFiscalLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simplebaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entradaProdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaProdDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingNavigator)).BeginInit();
            this.entradaBindingNavigator.SuspendLayout();
            this.fillBycodpropToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoLabel.Location = new System.Drawing.Point(12, 23);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(63, 20);
            codigoLabel.TabIndex = 55;
            codigoLabel.Text = "Codigo:";
            // 
            // produtoLabel
            // 
            produtoLabel.AutoSize = true;
            produtoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            produtoLabel.Location = new System.Drawing.Point(12, 75);
            produtoLabel.Name = "produtoLabel";
            produtoLabel.Size = new System.Drawing.Size(69, 20);
            produtoLabel.TabIndex = 55;
            produtoLabel.Text = "Produto:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            marcaLabel.Location = new System.Drawing.Point(13, 127);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(57, 20);
            marcaLabel.TabIndex = 10;
            marcaLabel.Text = "Marca:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantidadeLabel.Location = new System.Drawing.Point(328, 23);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(113, 20);
            quantidadeLabel.TabIndex = 14;
            quantidadeLabel.Text = "Qnt Adiquirida:";
            // 
            // valorCustoLabel
            // 
            valorCustoLabel.AutoSize = true;
            valorCustoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorCustoLabel.Location = new System.Drawing.Point(328, 75);
            valorCustoLabel.Name = "valorCustoLabel";
            valorCustoLabel.Size = new System.Drawing.Size(96, 20);
            valorCustoLabel.TabIndex = 16;
            valorCustoLabel.Text = "Valor Custo:";
            // 
            // notaFiscalLabel
            // 
            notaFiscalLabel.AutoSize = true;
            notaFiscalLabel.Location = new System.Drawing.Point(8, 12);
            notaFiscalLabel.Name = "notaFiscalLabel";
            notaFiscalLabel.Size = new System.Drawing.Size(126, 20);
            notaFiscalLabel.TabIndex = 55;
            notaFiscalLabel.Text = "Nº Pedido ou NF";
            // 
            // totalLabel
            // 
            totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            totalLabel.AutoSize = true;
            totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalLabel.Location = new System.Drawing.Point(704, 505);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(54, 20);
            totalLabel.TabIndex = 44;
            totalLabel.Text = "Total:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(150, 12);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(48, 20);
            dataLabel.TabIndex = 55;
            dataLabel.Text = "Data:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(8, 79);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(146, 20);
            label4.TabIndex = 58;
            label4.Text = "Código da Entrada:";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.simplebaseDataSet;
            // 
            // simplebaseDataSet
            // 
            this.simplebaseDataSet.DataSetName = "simplebaseDataSet";
            this.simplebaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // btnaddprod
            // 
            this.btnaddprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddprod.Location = new System.Drawing.Point(155, 149);
            this.btnaddprod.Name = "btnaddprod";
            this.btnaddprod.Size = new System.Drawing.Size(150, 30);
            this.btnaddprod.TabIndex = 4;
            this.btnaddprod.Text = "Adicionar Produto";
            this.btnaddprod.UseVisualStyleBackColor = true;
            this.btnaddprod.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinalizar.Location = new System.Drawing.Point(611, 568);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(147, 30);
            this.btnfinalizar.TabIndex = 5;
            this.btnfinalizar.Text = "Finalizar";
            this.btnfinalizar.UseVisualStyleBackColor = true;
            this.btnfinalizar.Click += new System.EventHandler(this.btnfinalizar_Click);
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "Fornecedores";
            this.fornecedoresBindingSource.DataSource = this.simplebaseDataSet;
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AcessoOpTableAdapter = null;
            this.tableAdapterManager.AcessoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CadEmpresaTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.EntradaProdTableAdapter = null;
            this.tableAdapterManager.EntradaTableAdapter = null;
            this.tableAdapterManager.FornecedoresTableAdapter = this.fornecedoresTableAdapter;
            this.tableAdapterManager.FuncionariosTableAdapter = null;
            this.tableAdapterManager.ImagensTableAdapter = null;
            this.tableAdapterManager.ItemsTableAdapter = this.itemsTableAdapter;
            this.tableAdapterManager.ProdutoVendaTableAdapter = null;
            this.tableAdapterManager.SenhamestreTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = simplestock.simplebaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendasExcluidasTableAdapter = null;
            this.tableAdapterManager.VendaTableAdapter = null;
            // 
            // razaoSocialComboBox
            // 
            this.razaoSocialComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "RazaoSocial", true));
            this.razaoSocialComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fornecedoresBindingSource, "RazaoSocial", true));
            this.razaoSocialComboBox.DataSource = this.fornecedoresBindingSource1;
            this.razaoSocialComboBox.DisplayMember = "RazaoSocial";
            this.razaoSocialComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.razaoSocialComboBox.FormattingEnabled = true;
            this.razaoSocialComboBox.Location = new System.Drawing.Point(6, 23);
            this.razaoSocialComboBox.Name = "razaoSocialComboBox";
            this.razaoSocialComboBox.Size = new System.Drawing.Size(277, 28);
            this.razaoSocialComboBox.TabIndex = 1;
            this.razaoSocialComboBox.ValueMember = "RazaoSocial";
            // 
            // fornecedoresBindingSource1
            // 
            this.fornecedoresBindingSource1.DataMember = "Fornecedores";
            this.fornecedoresBindingSource1.DataSource = this.simplebaseDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.razaoSocialComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(462, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 64);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fornecedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Se o fornecedor não estiver na lista, cadastre-o antes";
            // 
            // EmEstoqueComboBox
            // 
            this.EmEstoqueComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmEstoqueComboBox.Location = new System.Drawing.Point(332, 46);
            this.EmEstoqueComboBox.Name = "EmEstoqueComboBox";
            this.EmEstoqueComboBox.Size = new System.Drawing.Size(106, 26);
            this.EmEstoqueComboBox.TabIndex = 2;
            this.EmEstoqueComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmEstoqueComboBox_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtcodprop);
            this.groupBox2.Controls.Add(this.ValorProdutoComboBox);
            this.groupBox2.Controls.Add(this.txtmarca);
            this.groupBox2.Controls.Add(this.cbnomeproduto);
            this.groupBox2.Controls.Add(this.txtcodprod);
            this.groupBox2.Controls.Add(this.btninserirprod);
            this.groupBox2.Controls.Add(this.EmEstoqueComboBox);
            this.groupBox2.Controls.Add(valorCustoLabel);
            this.groupBox2.Controls.Add(this.btnaddprod);
            this.groupBox2.Controls.Add(quantidadeLabel);
            this.groupBox2.Controls.Add(marcaLabel);
            this.groupBox2.Controls.Add(produtoLabel);
            this.groupBox2.Controls.Add(codigoLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 187);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalhes do Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "Localizar por Cod Fabrica";
            // 
            // txtcodprop
            // 
            this.txtcodprop.Location = new System.Drawing.Point(126, 46);
            this.txtcodprop.Name = "txtcodprop";
            this.txtcodprop.Size = new System.Drawing.Size(179, 26);
            this.txtcodprop.TabIndex = 1;
            this.txtcodprop.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtcodprop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // ValorProdutoComboBox
            // 
            this.ValorProdutoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "ValorCusto", true));
            this.ValorProdutoComboBox.Location = new System.Drawing.Point(332, 98);
            this.ValorProdutoComboBox.Name = "ValorProdutoComboBox";
            this.ValorProdutoComboBox.Size = new System.Drawing.Size(106, 26);
            this.ValorProdutoComboBox.TabIndex = 3;
            // 
            // txtmarca
            // 
            this.txtmarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Marca", true));
            this.txtmarca.Location = new System.Drawing.Point(17, 151);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.ReadOnly = true;
            this.txtmarca.Size = new System.Drawing.Size(133, 26);
            this.txtmarca.TabIndex = 58;
            // 
            // cbnomeproduto
            // 
            this.cbnomeproduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Produto", true));
            this.cbnomeproduto.Location = new System.Drawing.Point(17, 98);
            this.cbnomeproduto.Name = "cbnomeproduto";
            this.cbnomeproduto.ReadOnly = true;
            this.cbnomeproduto.Size = new System.Drawing.Size(288, 26);
            this.cbnomeproduto.TabIndex = 57;
            // 
            // txtcodprod
            // 
            this.txtcodprod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Codigo", true));
            this.txtcodprod.Enabled = false;
            this.txtcodprod.Location = new System.Drawing.Point(17, 46);
            this.txtcodprod.Name = "txtcodprod";
            this.txtcodprod.ReadOnly = true;
            this.txtcodprod.Size = new System.Drawing.Size(100, 26);
            this.txtcodprod.TabIndex = 56;
            // 
            // btninserirprod
            // 
            this.btninserirprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninserirprod.Location = new System.Drawing.Point(311, 149);
            this.btninserirprod.Name = "btninserirprod";
            this.btninserirprod.Size = new System.Drawing.Size(127, 30);
            this.btninserirprod.TabIndex = 5;
            this.btninserirprod.Text = "Inserir Produto";
            this.btninserirprod.UseVisualStyleBackColor = true;
            this.btninserirprod.Click += new System.EventHandler(this.button3_Click);
            // 
            // entradaProdBindingSource
            // 
            this.entradaProdBindingSource.DataMember = "EntradaProd";
            this.entradaProdBindingSource.DataSource = this.simplebaseDataSet;
            // 
            // entradaProdTableAdapter
            // 
            this.entradaProdTableAdapter.ClearBeforeFill = true;
            // 
            // entradaProdDataGridView
            // 
            this.entradaProdDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.entradaProdDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.entradaProdDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.entradaProdDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProd,
            this.Produto,
            this.Marca,
            this.Qnt,
            this.ValorCusto,
            this.Subtotal});
            this.entradaProdDataGridView.Location = new System.Drawing.Point(12, 205);
            this.entradaProdDataGridView.Name = "entradaProdDataGridView";
            this.entradaProdDataGridView.ReadOnly = true;
            this.entradaProdDataGridView.Size = new System.Drawing.Size(746, 294);
            this.entradaProdDataGridView.TabIndex = 3;
            // 
            // CodProd
            // 
            this.CodProd.HeaderText = "Codigo";
            this.CodProd.Name = "CodProd";
            this.CodProd.ReadOnly = true;
            this.CodProd.Width = 50;
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Width = 250;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 145;
            // 
            // Qnt
            // 
            this.Qnt.HeaderText = "Qnt";
            this.Qnt.Name = "Qnt";
            this.Qnt.ReadOnly = true;
            this.Qnt.Width = 50;
            // 
            // ValorCusto
            // 
            this.ValorCusto.HeaderText = "Valor Custo";
            this.ValorCusto.Name = "ValorCusto";
            this.ValorCusto.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // entradaBindingSource
            // 
            this.entradaBindingSource.DataMember = "Entrada";
            this.entradaBindingSource.DataSource = this.simplebaseDataSet;
            // 
            // entradaTableAdapter
            // 
            this.entradaTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtcodentrada);
            this.groupBox3.Controls.Add(label4);
            this.groupBox3.Controls.Add(dataLabel);
            this.groupBox3.Controls.Add(this.dataDateTimePicker);
            this.groupBox3.Controls.Add(notaFiscalLabel);
            this.groupBox3.Controls.Add(this.notaFiscalTextBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(462, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 121);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // txtcodentrada
            // 
            this.txtcodentrada.Enabled = false;
            this.txtcodentrada.Location = new System.Drawing.Point(154, 76);
            this.txtcodentrada.Name = "txtcodentrada";
            this.txtcodentrada.Size = new System.Drawing.Size(129, 26);
            this.txtcodentrada.TabIndex = 59;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataDateTimePicker.Location = new System.Drawing.Point(154, 35);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(129, 26);
            this.dataDateTimePicker.TabIndex = 2;
            this.dataDateTimePicker.Value = new System.DateTime(2014, 6, 25, 0, 0, 0, 0);
            // 
            // notaFiscalTextBox
            // 
            this.notaFiscalTextBox.Location = new System.Drawing.Point(12, 35);
            this.notaFiscalTextBox.Name = "notaFiscalTextBox";
            this.notaFiscalTextBox.Size = new System.Drawing.Size(138, 26);
            this.notaFiscalTextBox.TabIndex = 1;
            // 
            // ValortotalTextBox
            // 
            this.ValortotalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ValortotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entradaBindingSource, "Total", true));
            this.ValortotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValortotalTextBox.Location = new System.Drawing.Point(611, 528);
            this.ValortotalTextBox.Name = "ValortotalTextBox";
            this.ValortotalTextBox.ReadOnly = true;
            this.ValortotalTextBox.Size = new System.Drawing.Size(147, 26);
            this.ValortotalTextBox.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(454, 568);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Nova Entrada";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // entradaBindingNavigator
            // 
            this.entradaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.entradaBindingNavigator.BindingSource = this.entradaBindingSource;
            this.entradaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.entradaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.entradaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.entradaBindingNavigatorSaveItem});
            this.entradaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.entradaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.entradaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.entradaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.entradaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.entradaBindingNavigator.Name = "entradaBindingNavigator";
            this.entradaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.entradaBindingNavigator.Size = new System.Drawing.Size(843, 25);
            this.entradaBindingNavigator.TabIndex = 12;
            this.entradaBindingNavigator.Text = "bindingNavigator1";
            this.entradaBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click_1);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // entradaBindingNavigatorSaveItem
            // 
            this.entradaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.entradaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("entradaBindingNavigatorSaveItem.Image")));
            this.entradaBindingNavigatorSaveItem.Name = "entradaBindingNavigatorSaveItem";
            this.entradaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.entradaBindingNavigatorSaveItem.Text = "Save Data";
            this.entradaBindingNavigatorSaveItem.Click += new System.EventHandler(this.entradaBindingNavigatorSaveItem_Click_1);
            // 
            // fillBycodpropToolStrip
            // 
            this.fillBycodpropToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codPropToolStripLabel,
            this.codPropToolStripTextBox,
            this.fillBycodpropToolStripButton});
            this.fillBycodpropToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBycodpropToolStrip.Name = "fillBycodpropToolStrip";
            this.fillBycodpropToolStrip.Size = new System.Drawing.Size(771, 25);
            this.fillBycodpropToolStrip.TabIndex = 56;
            this.fillBycodpropToolStrip.Text = "fillBycodpropToolStrip";
            this.fillBycodpropToolStrip.Visible = false;
            // 
            // codPropToolStripLabel
            // 
            this.codPropToolStripLabel.Name = "codPropToolStripLabel";
            this.codPropToolStripLabel.Size = new System.Drawing.Size(57, 22);
            this.codPropToolStripLabel.Text = "CodProp:";
            // 
            // codPropToolStripTextBox
            // 
            this.codPropToolStripTextBox.Name = "codPropToolStripTextBox";
            this.codPropToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillBycodpropToolStripButton
            // 
            this.fillBycodpropToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBycodpropToolStripButton.Name = "fillBycodpropToolStripButton";
            this.fillBycodpropToolStripButton.Size = new System.Drawing.Size(84, 22);
            this.fillBycodpropToolStripButton.Text = "FillBycodprop";
            this.fillBycodpropToolStripButton.Click += new System.EventHandler(this.fillBycodpropToolStripButton_Click);
            // 
            // frmEntradadeProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 618);
            this.Controls.Add(this.entradaBindingNavigator);
            this.Controls.Add(this.fillBycodpropToolStrip);
            this.Controls.Add(this.button2);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.ValortotalTextBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.entradaProdDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnfinalizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEntradadeProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada de Produtos";
            this.Load += new System.EventHandler(this.frmEntradadeProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simplebaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entradaProdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaProdDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingNavigator)).EndInit();
            this.entradaBindingNavigator.ResumeLayout(false);
            this.entradaBindingNavigator.PerformLayout();
            this.fillBycodpropToolStrip.ResumeLayout(false);
            this.fillBycodpropToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private simplebaseDataSet simplebaseDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private simplebaseDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.Button btnaddprod;
        private System.Windows.Forms.Button btnfinalizar;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private simplebaseDataSetTableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter;
        private simplebaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox razaoSocialComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox EmEstoqueComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btninserirprod;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource1;
        private System.Windows.Forms.BindingSource entradaProdBindingSource;
        private simplebaseDataSetTableAdapters.EntradaProdTableAdapter entradaProdTableAdapter;
        private System.Windows.Forms.DataGridView entradaProdDataGridView;
        private System.Windows.Forms.BindingSource entradaBindingSource;
        private simplebaseDataSetTableAdapters.EntradaTableAdapter entradaTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox notaFiscalTextBox;
        private System.Windows.Forms.TextBox ValortotalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingNavigator entradaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton entradaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtcodprod;
        private System.Windows.Forms.TextBox cbnomeproduto;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.MaskedTextBox ValorProdutoComboBox;
        private System.Windows.Forms.ToolStrip fillBycodpropToolStrip;
        private System.Windows.Forms.ToolStripLabel codPropToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox codPropToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBycodpropToolStripButton;
        private System.Windows.Forms.TextBox txtcodprop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodentrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
    }
}