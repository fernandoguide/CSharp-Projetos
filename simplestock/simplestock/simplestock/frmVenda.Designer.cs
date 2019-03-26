namespace simplestock
{
    partial class frmVenda
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
            System.Windows.Forms.Label clienteLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label nomeProdutoLabel;
            System.Windows.Forms.Label valorProdutoLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label quantidadeEmEstoqueLabel;
            System.Windows.Forms.Label vendedorLabel;
            System.Windows.Forms.Label codProdutoLabel;
            System.Windows.Forms.Label codPropLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenda));
            this.vendaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simplebaseDataSet = new simplestock.simplebaseDataSet();
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
            this.vendaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtcodigovenda = new System.Windows.Forms.TextBox();
            this.cbdata = new System.Windows.Forms.DateTimePicker();
            this.cbnomeproduto = new System.Windows.Forms.ComboBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.cbvendedor = new System.Windows.Forms.ComboBox();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btninserirproduto = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.produtoVendaDataGridView = new System.Windows.Forms.DataGridView();
            this.codigProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvsubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmEstoqueComboBox = new System.Windows.Forms.ComboBox();
            this.btnremoverprod = new System.Windows.Forms.Button();
            this.valorTotalTextBox = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btnaddproduto = new System.Windows.Forms.Button();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.btnlocalizarcliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcodprod = new System.Windows.Forms.TextBox();
            this.txtcodprop = new System.Windows.Forms.TextBox();
            this.ValorProdutoComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vendaTableAdapter = new simplestock.simplebaseDataSetTableAdapters.VendaTableAdapter();
            this.tableAdapterManager = new simplestock.simplebaseDataSetTableAdapters.TableAdapterManager();
            this.clientesTableAdapter = new simplestock.simplebaseDataSetTableAdapters.ClientesTableAdapter();
            this.funcionariosTableAdapter = new simplestock.simplebaseDataSetTableAdapters.FuncionariosTableAdapter();
            this.itemsTableAdapter = new simplestock.simplebaseDataSetTableAdapters.ItemsTableAdapter();
            this.produtoVendaTableAdapter = new simplestock.simplebaseDataSetTableAdapters.ProdutoVendaTableAdapter();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.itemsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.itemsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.fillBycodpropToolStrip = new System.Windows.Forms.ToolStrip();
            this.codPropToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.codPropToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBycodpropToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbldesc = new System.Windows.Forms.Label();
            this.imagensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.txtdescporc = new System.Windows.Forms.TextBox();
            this.imagensTableAdapter = new simplestock.simplebaseDataSetTableAdapters.ImagensTableAdapter();
            codigoLabel = new System.Windows.Forms.Label();
            clienteLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            nomeProdutoLabel = new System.Windows.Forms.Label();
            valorProdutoLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            quantidadeEmEstoqueLabel = new System.Windows.Forms.Label();
            vendedorLabel = new System.Windows.Forms.Label();
            codProdutoLabel = new System.Windows.Forms.Label();
            codPropLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingNavigator)).BeginInit();
            this.vendaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simplebaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoVendaDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource3)).BeginInit();
            this.fillBycodpropToolStrip.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagensBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(304, 465);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(92, 13);
            codigoLabel.TabIndex = 3;
            codigoLabel.Text = "Código da Venda:";
            // 
            // clienteLabel
            // 
            clienteLabel.AutoSize = true;
            clienteLabel.Location = new System.Drawing.Point(6, 20);
            clienteLabel.Name = "clienteLabel";
            clienteLabel.Size = new System.Drawing.Size(42, 13);
            clienteLabel.TabIndex = 5;
            clienteLabel.Text = "Cliente:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(6, 60);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 7;
            dataLabel.Text = "Data:";
            // 
            // nomeProdutoLabel
            // 
            nomeProdutoLabel.AutoSize = true;
            nomeProdutoLabel.Location = new System.Drawing.Point(301, 13);
            nomeProdutoLabel.Name = "nomeProdutoLabel";
            nomeProdutoLabel.Size = new System.Drawing.Size(35, 13);
            nomeProdutoLabel.TabIndex = 9;
            nomeProdutoLabel.Text = "Nome";
            // 
            // valorProdutoLabel
            // 
            valorProdutoLabel.AutoSize = true;
            valorProdutoLabel.Location = new System.Drawing.Point(10, 63);
            valorProdutoLabel.Name = "valorProdutoLabel";
            valorProdutoLabel.Size = new System.Drawing.Size(31, 13);
            valorProdutoLabel.TabIndex = 11;
            valorProdutoLabel.Text = "Valor";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(85, 112);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(24, 13);
            quantidadeLabel.TabIndex = 13;
            quantidadeLabel.Text = "Qnt";
            // 
            // quantidadeEmEstoqueLabel
            // 
            quantidadeEmEstoqueLabel.AutoSize = true;
            quantidadeEmEstoqueLabel.Location = new System.Drawing.Point(6, 112);
            quantidadeEmEstoqueLabel.Name = "quantidadeEmEstoqueLabel";
            quantidadeEmEstoqueLabel.Size = new System.Drawing.Size(64, 13);
            quantidadeEmEstoqueLabel.TabIndex = 15;
            quantidadeEmEstoqueLabel.Text = "Em Estoque";
            // 
            // vendedorLabel
            // 
            vendedorLabel.AutoSize = true;
            vendedorLabel.Location = new System.Drawing.Point(6, 102);
            vendedorLabel.Name = "vendedorLabel";
            vendedorLabel.Size = new System.Drawing.Size(56, 13);
            vendedorLabel.TabIndex = 17;
            vendedorLabel.Text = "Vendedor:";
            vendedorLabel.Click += new System.EventHandler(this.vendedorLabel_Click);
            // 
            // codProdutoLabel
            // 
            codProdutoLabel.AutoSize = true;
            codProdutoLabel.Location = new System.Drawing.Point(10, 18);
            codProdutoLabel.Name = "codProdutoLabel";
            codProdutoLabel.Size = new System.Drawing.Size(40, 13);
            codProdutoLabel.TabIndex = 22;
            codProdutoLabel.Text = "Codigo";
            // 
            // codPropLabel
            // 
            codPropLabel.AutoSize = true;
            codPropLabel.Location = new System.Drawing.Point(102, 16);
            codPropLabel.Name = "codPropLabel";
            codPropLabel.Size = new System.Drawing.Size(136, 13);
            codPropLabel.TabIndex = 22;
            codPropLabel.Text = "Buscar por Cod Fabricante:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(33, 16);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(89, 13);
            label3.TabIndex = 5;
            label3.Text = "Por Porcentagem";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(31, 55);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(152, 13);
            label1.TabIndex = 29;
            label1.Text = "Desconto Máximo Cadastrado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(208, 56);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(15, 13);
            label4.TabIndex = 31;
            label4.Text = "%";
            // 
            // vendaBindingNavigator
            // 
            this.vendaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vendaBindingNavigator.BindingSource = this.vendaBindingSource;
            this.vendaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vendaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vendaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vendaBindingNavigatorSaveItem});
            this.vendaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vendaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vendaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vendaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vendaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vendaBindingNavigator.Name = "vendaBindingNavigator";
            this.vendaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vendaBindingNavigator.Size = new System.Drawing.Size(878, 25);
            this.vendaBindingNavigator.TabIndex = 0;
            this.vendaBindingNavigator.Text = "bindingNavigator1";
            this.vendaBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "Venda";
            this.vendaBindingSource.DataSource = this.simplebaseDataSet;
            // 
            // simplebaseDataSet
            // 
            this.simplebaseDataSet.DataSetName = "simplebaseDataSet";
            this.simplebaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // vendaBindingNavigatorSaveItem
            // 
            this.vendaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vendaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vendaBindingNavigatorSaveItem.Image")));
            this.vendaBindingNavigatorSaveItem.Name = "vendaBindingNavigatorSaveItem";
            this.vendaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vendaBindingNavigatorSaveItem.Text = "Save Data";
            this.vendaBindingNavigatorSaveItem.Click += new System.EventHandler(this.vendaBindingNavigatorSaveItem_Click_1);
            // 
            // txtcodigovenda
            // 
            this.txtcodigovenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Codigo", true));
            this.txtcodigovenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigovenda.Location = new System.Drawing.Point(307, 481);
            this.txtcodigovenda.Name = "txtcodigovenda";
            this.txtcodigovenda.ReadOnly = true;
            this.txtcodigovenda.Size = new System.Drawing.Size(113, 35);
            this.txtcodigovenda.TabIndex = 1;
            // 
            // cbdata
            // 
            this.cbdata.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vendaBindingSource, "Data", true));
            this.cbdata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cbdata.Location = new System.Drawing.Point(6, 76);
            this.cbdata.Name = "cbdata";
            this.cbdata.Size = new System.Drawing.Size(243, 20);
            this.cbdata.TabIndex = 3;
            this.cbdata.Value = new System.DateTime(2014, 6, 24, 0, 0, 0, 0);
            this.cbdata.ValueChanged += new System.EventHandler(this.cbdata_ValueChanged);
            // 
            // cbnomeproduto
            // 
            this.cbnomeproduto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "NomeProduto", true));
            this.cbnomeproduto.DataSource = this.itemsBindingSource;
            this.cbnomeproduto.DisplayMember = "Produto";
            this.cbnomeproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbnomeproduto.FormattingEnabled = true;
            this.cbnomeproduto.Location = new System.Drawing.Point(303, 28);
            this.cbnomeproduto.Name = "cbnomeproduto";
            this.cbnomeproduto.Size = new System.Drawing.Size(535, 32);
            this.cbnomeproduto.TabIndex = 2;
            this.cbnomeproduto.ValueMember = "Codigo";
            this.cbnomeproduto.SelectedIndexChanged += new System.EventHandler(this.nomeProdutoComboBox_SelectedIndexChanged);
            this.cbnomeproduto.SelectionChangeCommitted += new System.EventHandler(this.nomeProdutoComboBox_SelectionChangeCommitted);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.simplebaseDataSet;
            // 
            // txtquantidade
            // 
            this.txtquantidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Quantidade", true));
            this.txtquantidade.Location = new System.Drawing.Point(88, 128);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(58, 20);
            this.txtquantidade.TabIndex = 5;
            this.txtquantidade.Tag = "";
            this.txtquantidade.TextChanged += new System.EventHandler(this.txtquantidade_TextChanged);
            this.txtquantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquantidade_KeyPress);
            // 
            // cbvendedor
            // 
            this.cbvendedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Vendedor", true));
            this.cbvendedor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "Vendedor", true));
            this.cbvendedor.DataSource = this.funcionariosBindingSource;
            this.cbvendedor.DisplayMember = "Login";
            this.cbvendedor.Enabled = false;
            this.cbvendedor.FormattingEnabled = true;
            this.cbvendedor.Location = new System.Drawing.Point(6, 118);
            this.cbvendedor.Name = "cbvendedor";
            this.cbvendedor.Size = new System.Drawing.Size(243, 21);
            this.cbvendedor.TabIndex = 4;
            this.cbvendedor.ValueMember = "Nome";
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "Funcionarios";
            this.funcionariosBindingSource.DataSource = this.simplebaseDataSet;
            // 
            // produtoVendaBindingSource
            // 
            this.produtoVendaBindingSource.DataMember = "VendaProdutoVenda";
            this.produtoVendaBindingSource.DataSource = this.vendaBindingSource;
            // 
            // btninserirproduto
            // 
            this.btninserirproduto.Location = new System.Drawing.Point(133, 154);
            this.btninserirproduto.Name = "btninserirproduto";
            this.btninserirproduto.Size = new System.Drawing.Size(116, 50);
            this.btninserirproduto.TabIndex = 7;
            this.btninserirproduto.Text = "Adicionar ao Carrinho";
            this.btninserirproduto.UseVisualStyleBackColor = true;
            this.btninserirproduto.Click += new System.EventHandler(this.btninserirproduto_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(711, 485);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(126, 38);
            this.btnsalvar.TabIndex = 4;
            this.btnsalvar.Text = "Salvar Venda";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // produtoVendaDataGridView
            // 
            this.produtoVendaDataGridView.AutoGenerateColumns = false;
            this.produtoVendaDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.produtoVendaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtoVendaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigProduto,
            this.dataGridViewTextBoxColumn5,
            this.Valor,
            this.Quantidade,
            this.Desconto,
            this.dgvsubtotal});
            this.produtoVendaDataGridView.DataSource = this.produtoVendaBindingSource;
            this.produtoVendaDataGridView.Location = new System.Drawing.Point(304, 66);
            this.produtoVendaDataGridView.Name = "produtoVendaDataGridView";
            this.produtoVendaDataGridView.ReadOnly = true;
            this.produtoVendaDataGridView.Size = new System.Drawing.Size(534, 362);
            this.produtoVendaDataGridView.TabIndex = 22;
            this.produtoVendaDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.produtoVendaDataGridView_RowsAdded);
            // 
            // codigProduto
            // 
            this.codigProduto.DataPropertyName = "IdProduto";
            this.codigProduto.HeaderText = "IdProduto";
            this.codigProduto.Name = "codigProduto";
            this.codigProduto.ReadOnly = true;
            this.codigProduto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codigProduto.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 50;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 50;
            // 
            // Desconto
            // 
            this.Desconto.DataPropertyName = "Desconto";
            this.Desconto.HeaderText = "Desconto";
            this.Desconto.Name = "Desconto";
            this.Desconto.ReadOnly = true;
            this.Desconto.Width = 40;
            // 
            // dgvsubtotal
            // 
            this.dgvsubtotal.HeaderText = "Subtotal";
            this.dgvsubtotal.Name = "dgvsubtotal";
            this.dgvsubtotal.ReadOnly = true;
            this.dgvsubtotal.Width = 50;
            // 
            // EmEstoqueComboBox
            // 
            this.EmEstoqueComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "QuantidadeEmEstoque", true));
            this.EmEstoqueComboBox.DataSource = this.itemsBindingSource;
            this.EmEstoqueComboBox.DisplayMember = "Quantidade";
            this.EmEstoqueComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.EmEstoqueComboBox.FormattingEnabled = true;
            this.EmEstoqueComboBox.Location = new System.Drawing.Point(9, 128);
            this.EmEstoqueComboBox.Name = "EmEstoqueComboBox";
            this.EmEstoqueComboBox.Size = new System.Drawing.Size(61, 21);
            this.EmEstoqueComboBox.TabIndex = 4;
            this.EmEstoqueComboBox.ValueMember = "Produto";
            this.EmEstoqueComboBox.SelectedIndexChanged += new System.EventHandler(this.EmEstoqueComboBox_SelectedIndexChanged);
            // 
            // btnremoverprod
            // 
            this.btnremoverprod.Location = new System.Drawing.Point(575, 485);
            this.btnremoverprod.Name = "btnremoverprod";
            this.btnremoverprod.Size = new System.Drawing.Size(126, 38);
            this.btnremoverprod.TabIndex = 3;
            this.btnremoverprod.Text = "Remover Produto";
            this.btnremoverprod.UseVisualStyleBackColor = true;
            this.btnremoverprod.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // valorTotalTextBox
            // 
            this.valorTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTotalTextBox.Location = new System.Drawing.Point(737, 441);
            this.valorTotalTextBox.Name = "valorTotalTextBox";
            this.valorTotalTextBox.ReadOnly = true;
            this.valorTotalTextBox.Size = new System.Drawing.Size(100, 35);
            this.valorTotalTextBox.TabIndex = 2;
            this.valorTotalTextBox.TextChanged += new System.EventHandler(this.valorTotalTextBox_TextChanged);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(682, 451);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(49, 20);
            this.lbltotal.TabIndex = 31;
            this.lbltotal.Text = "Total";
            // 
            // btnaddproduto
            // 
            this.btnaddproduto.Location = new System.Drawing.Point(9, 154);
            this.btnaddproduto.Name = "btnaddproduto";
            this.btnaddproduto.Size = new System.Drawing.Size(116, 50);
            this.btnaddproduto.TabIndex = 6;
            this.btnaddproduto.Text = "Consultar Código - Ou inserir pelo Nome";
            this.btnaddproduto.UseVisualStyleBackColor = true;
            this.btnaddproduto.Click += new System.EventHandler(this.btnaddproduto_Click);
            // 
            // txtcliente
            // 
            this.txtcliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Cliente", true));
            this.txtcliente.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.vendaBindingSource, "Cliente", true));
            this.txtcliente.Location = new System.Drawing.Point(6, 37);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.ReadOnly = true;
            this.txtcliente.Size = new System.Drawing.Size(220, 20);
            this.txtcliente.TabIndex = 1;
            this.txtcliente.TextChanged += new System.EventHandler(this.txtcliente_TextChanged);
            // 
            // btnlocalizarcliente
            // 
            this.btnlocalizarcliente.Location = new System.Drawing.Point(223, 37);
            this.btnlocalizarcliente.Name = "btnlocalizarcliente";
            this.btnlocalizarcliente.Size = new System.Drawing.Size(26, 20);
            this.btnlocalizarcliente.TabIndex = 2;
            this.btnlocalizarcliente.Text = "...";
            this.btnlocalizarcliente.UseVisualStyleBackColor = true;
            this.btnlocalizarcliente.Click += new System.EventHandler(this.btnlocalizarcliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcodprod);
            this.groupBox1.Controls.Add(this.txtcodprop);
            this.groupBox1.Controls.Add(codPropLabel);
            this.groupBox1.Controls.Add(quantidadeEmEstoqueLabel);
            this.groupBox1.Controls.Add(this.btnaddproduto);
            this.groupBox1.Controls.Add(this.txtquantidade);
            this.groupBox1.Controls.Add(quantidadeLabel);
            this.groupBox1.Controls.Add(valorProdutoLabel);
            this.groupBox1.Controls.Add(this.btninserirproduto);
            this.groupBox1.Controls.Add(this.EmEstoqueComboBox);
            this.groupBox1.Controls.Add(codProdutoLabel);
            this.groupBox1.Controls.Add(this.ValorProdutoComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 210);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto";
            // 
            // txtcodprod
            // 
            this.txtcodprod.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.itemsBindingSource, "Codigo", true));
            this.txtcodprod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Codigo", true));
            this.txtcodprod.Location = new System.Drawing.Point(9, 33);
            this.txtcodprod.Name = "txtcodprod";
            this.txtcodprod.ReadOnly = true;
            this.txtcodprod.Size = new System.Drawing.Size(83, 20);
            this.txtcodprod.TabIndex = 24;
            // 
            // txtcodprop
            // 
            this.txtcodprop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodprop.Location = new System.Drawing.Point(105, 33);
            this.txtcodprop.Name = "txtcodprop";
            this.txtcodprop.Size = new System.Drawing.Size(144, 26);
            this.txtcodprop.TabIndex = 1;
            this.txtcodprop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodprop_KeyPress);
            // 
            // ValorProdutoComboBox
            // 
            this.ValorProdutoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "ValorProduto", true));
            this.ValorProdutoComboBox.DataSource = this.itemsBindingSource;
            this.ValorProdutoComboBox.DisplayMember = "ValorVenda";
            this.ValorProdutoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.ValorProdutoComboBox.FormattingEnabled = true;
            this.ValorProdutoComboBox.Location = new System.Drawing.Point(9, 79);
            this.ValorProdutoComboBox.Name = "ValorProdutoComboBox";
            this.ValorProdutoComboBox.Size = new System.Drawing.Size(87, 21);
            this.ValorProdutoComboBox.TabIndex = 3;
            this.ValorProdutoComboBox.ValueMember = "Produto";
            this.ValorProdutoComboBox.SelectedIndexChanged += new System.EventHandler(this.ValorProdutoComboBox_SelectedIndexChanged);
            this.ValorProdutoComboBox.SelectedValueChanged += new System.EventHandler(this.ValorProdutoComboBox_SelectedValueChanged);
            this.ValorProdutoComboBox.TextChanged += new System.EventHandler(this.ValorProdutoComboBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbdata);
            this.groupBox2.Controls.Add(this.cbvendedor);
            this.groupBox2.Controls.Add(this.btnlocalizarcliente);
            this.groupBox2.Controls.Add(vendedorLabel);
            this.groupBox2.Controls.Add(this.txtcliente);
            this.groupBox2.Controls.Add(dataLabel);
            this.groupBox2.Controls.Add(clienteLabel);
            this.groupBox2.Location = new System.Drawing.Point(11, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 139);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Venda";
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AcessoOpTableAdapter = null;
            this.tableAdapterManager.AcessoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CadEmpresaTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.EntradaProdTableAdapter = null;
            this.tableAdapterManager.EntradaTableAdapter = null;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.FuncionariosTableAdapter = this.funcionariosTableAdapter;
            this.tableAdapterManager.ImagensTableAdapter = null;
            this.tableAdapterManager.ItemsTableAdapter = this.itemsTableAdapter;
            this.tableAdapterManager.ProdutoVendaTableAdapter = this.produtoVendaTableAdapter;
            this.tableAdapterManager.SenhamestreTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = simplestock.simplebaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendasExcluidasTableAdapter = null;
            this.tableAdapterManager.VendaTableAdapter = this.vendaTableAdapter;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // produtoVendaTableAdapter
            // 
            this.produtoVendaTableAdapter.ClearBeforeFill = true;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.simplebaseDataSet;
            // 
            // itemsBindingSource1
            // 
            this.itemsBindingSource1.DataMember = "Items";
            this.itemsBindingSource1.DataSource = this.simplebaseDataSet;
            // 
            // itemsBindingSource2
            // 
            this.itemsBindingSource2.DataMember = "Items";
            this.itemsBindingSource2.DataSource = this.simplebaseDataSet;
            // 
            // itemsBindingSource3
            // 
            this.itemsBindingSource3.DataMember = "Items";
            this.itemsBindingSource3.DataSource = this.simplebaseDataSet;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // fillBycodpropToolStrip
            // 
            this.fillBycodpropToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codPropToolStripLabel,
            this.codPropToolStripTextBox,
            this.fillBycodpropToolStripButton});
            this.fillBycodpropToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBycodpropToolStrip.Name = "fillBycodpropToolStrip";
            this.fillBycodpropToolStrip.Size = new System.Drawing.Size(803, 25);
            this.fillBycodpropToolStrip.TabIndex = 37;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(label4);
            this.groupBox3.Controls.Add(this.lbldesc);
            this.groupBox3.Controls.Add(label1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtdescporc);
            this.groupBox3.Controls.Add(label3);
            this.groupBox3.Location = new System.Drawing.Point(11, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 76);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Descontos";
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imagensBindingSource, "Desconto", true));
            this.lbldesc.Location = new System.Drawing.Point(180, 55);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(32, 13);
            this.lbldesc.TabIndex = 30;
            this.lbldesc.Text = "Desc";
            // 
            // imagensBindingSource
            // 
            this.imagensBindingSource.DataMember = "Imagens";
            this.imagensBindingSource.DataSource = this.simplebaseDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Aplicar desconto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_4);
            // 
            // txtdescporc
            // 
            this.txtdescporc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Quantidade", true));
            this.txtdescporc.Location = new System.Drawing.Point(37, 32);
            this.txtdescporc.Name = "txtdescporc";
            this.txtdescporc.Size = new System.Drawing.Size(83, 20);
            this.txtdescporc.TabIndex = 25;
            this.txtdescporc.Tag = "";
            this.txtdescporc.TextChanged += new System.EventHandler(this.txtdescporc_TextChanged);
            this.txtdescporc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescporc_KeyPress);
            // 
            // imagensTableAdapter
            // 
            this.imagensTableAdapter.ClearBeforeFill = true;
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 530);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.fillBycodpropToolStrip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.valorTotalTextBox);
            this.Controls.Add(this.btnremoverprod);
            this.Controls.Add(this.produtoVendaDataGridView);
            this.Controls.Add(this.cbnomeproduto);
            this.Controls.Add(this.txtcodigovenda);
            this.Controls.Add(nomeProdutoLabel);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.vendaBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.frmVenda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVenda_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmVenda_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingNavigator)).EndInit();
            this.vendaBindingNavigator.ResumeLayout(false);
            this.vendaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simplebaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoVendaDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource3)).EndInit();
            this.fillBycodpropToolStrip.ResumeLayout(false);
            this.fillBycodpropToolStrip.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagensBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private simplebaseDataSet simplebaseDataSet;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private simplebaseDataSetTableAdapters.VendaTableAdapter vendaTableAdapter;
        private simplebaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vendaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vendaBindingNavigatorSaveItem;
        private simplebaseDataSetTableAdapters.ProdutoVendaTableAdapter produtoVendaTableAdapter;
        private System.Windows.Forms.DateTimePicker cbdata;
        private System.Windows.Forms.ComboBox cbnomeproduto;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.ComboBox cbvendedor;
        private System.Windows.Forms.BindingSource produtoVendaBindingSource;
        private simplebaseDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private simplebaseDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private simplebaseDataSetTableAdapters.FuncionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private System.Windows.Forms.Button btninserirproduto;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.DataGridView produtoVendaDataGridView;
        private System.Windows.Forms.BindingSource itemsBindingSource1;
        private System.Windows.Forms.ComboBox EmEstoqueComboBox;
        private System.Windows.Forms.BindingSource itemsBindingSource2;
        private System.Windows.Forms.BindingSource itemsBindingSource3;
        private System.Windows.Forms.Button btnremoverprod;
        private System.Windows.Forms.TextBox valorTotalTextBox;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btnaddproduto;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Button btnlocalizarcliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        public System.Windows.Forms.TextBox txtcodigovenda;
        private System.Windows.Forms.ComboBox ValorProdutoComboBox;
        private System.Windows.Forms.TextBox txtcodprop;
        private System.Windows.Forms.ToolStrip fillBycodpropToolStrip;
        private System.Windows.Forms.ToolStripLabel codPropToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox codPropToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBycodpropToolStripButton;
        private System.Windows.Forms.TextBox txtcodprod;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtdescporc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsubtotal;
        private System.Windows.Forms.BindingSource imagensBindingSource;
        private simplebaseDataSetTableAdapters.ImagensTableAdapter imagensTableAdapter;
        private System.Windows.Forms.Label lbldesc;

    }
}