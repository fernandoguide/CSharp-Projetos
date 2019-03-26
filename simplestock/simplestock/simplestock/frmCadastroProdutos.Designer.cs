namespace simplestock
{
    partial class frmCadastroProdutos
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
            System.Windows.Forms.Label fornecedorLabel;
            System.Windows.Forms.Label produtoLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label valorCustoLabel1;
            System.Windows.Forms.Label valorVendaLabel1;
            System.Windows.Forms.Label lblpesq;
            System.Windows.Forms.Label codPropLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label nCMLabel;
            System.Windows.Forms.Label cSTLabel;
            System.Windows.Forms.Label cFOPLabel;
            System.Windows.Forms.Label iCMSLabel;
            System.Windows.Forms.Label iPILabel;
            System.Windows.Forms.Label cSOSNLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProdutos));
            this.simplebaseDataSet = new simplestock.simplebaseDataSet();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new simplestock.simplebaseDataSetTableAdapters.ItemsTableAdapter();
            this.tableAdapterManager = new simplestock.simplebaseDataSetTableAdapters.TableAdapterManager();
            this.itemsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtproduto = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cbfornecedor = new System.Windows.Forms.ComboBox();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedoresTableAdapter = new simplestock.simplebaseDataSetTableAdapters.FornecedoresTableAdapter();
            this.txtvalorvenda = new System.Windows.Forms.TextBox();
            this.txtpesquisar = new System.Windows.Forms.TextBox();
            this.btnpesq = new System.Windows.Forms.Button();
            this.fornecedoresItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtvalorcusto = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CodProp = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtcodprop = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.fillBycodpropToolStrip = new System.Windows.Forms.ToolStrip();
            this.codPropToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.codPropToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBycodpropToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cSOSNComboBox = new System.Windows.Forms.ComboBox();
            this.cSTComboBox = new System.Windows.Forms.ComboBox();
            this.iPITextBox = new System.Windows.Forms.TextBox();
            this.iCMSTextBox = new System.Windows.Forms.TextBox();
            this.nCMTextBox = new System.Windows.Forms.TextBox();
            this.cFOPComboBox = new System.Windows.Forms.ComboBox();
            codigoLabel = new System.Windows.Forms.Label();
            fornecedorLabel = new System.Windows.Forms.Label();
            produtoLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valorCustoLabel1 = new System.Windows.Forms.Label();
            valorVendaLabel1 = new System.Windows.Forms.Label();
            lblpesq = new System.Windows.Forms.Label();
            codPropLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            nCMLabel = new System.Windows.Forms.Label();
            cSTLabel = new System.Windows.Forms.Label();
            cFOPLabel = new System.Windows.Forms.Label();
            iCMSLabel = new System.Windows.Forms.Label();
            iPILabel = new System.Windows.Forms.Label();
            cSOSNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.simplebaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingNavigator)).BeginInit();
            this.itemsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresItemsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.fillBycodpropToolStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(15, 24);
            codigoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(63, 20);
            codigoLabel.TabIndex = 1;
            codigoLabel.Text = "Codigo:";
            // 
            // fornecedorLabel
            // 
            fornecedorLabel.AutoSize = true;
            fornecedorLabel.Location = new System.Drawing.Point(15, 158);
            fornecedorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fornecedorLabel.Name = "fornecedorLabel";
            fornecedorLabel.Size = new System.Drawing.Size(95, 20);
            fornecedorLabel.TabIndex = 3;
            fornecedorLabel.Text = "Fornecedor:";
            // 
            // produtoLabel
            // 
            produtoLabel.AutoSize = true;
            produtoLabel.Location = new System.Drawing.Point(14, 97);
            produtoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            produtoLabel.Name = "produtoLabel";
            produtoLabel.Size = new System.Drawing.Size(69, 20);
            produtoLabel.TabIndex = 5;
            produtoLabel.Text = "Produto:";
            produtoLabel.Click += new System.EventHandler(this.produtoLabel_Click);
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(13, 227);
            marcaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(57, 20);
            marcaLabel.TabIndex = 7;
            marcaLabel.Text = "Marca:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(249, 226);
            quantidadeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(96, 20);
            quantidadeLabel.TabIndex = 9;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // valorCustoLabel1
            // 
            valorCustoLabel1.AutoSize = true;
            valorCustoLabel1.Location = new System.Drawing.Point(437, 227);
            valorCustoLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            valorCustoLabel1.Name = "valorCustoLabel1";
            valorCustoLabel1.Size = new System.Drawing.Size(96, 20);
            valorCustoLabel1.TabIndex = 20;
            valorCustoLabel1.Text = "Valor Custo:";
            // 
            // valorVendaLabel1
            // 
            valorVendaLabel1.AutoSize = true;
            valorVendaLabel1.Location = new System.Drawing.Point(571, 226);
            valorVendaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            valorVendaLabel1.Name = "valorVendaLabel1";
            valorVendaLabel1.Size = new System.Drawing.Size(101, 20);
            valorVendaLabel1.TabIndex = 22;
            valorVendaLabel1.Text = "Valor Venda:";
            // 
            // lblpesq
            // 
            lblpesq.AutoSize = true;
            lblpesq.Location = new System.Drawing.Point(14, 0);
            lblpesq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblpesq.Name = "lblpesq";
            lblpesq.Size = new System.Drawing.Size(246, 20);
            lblpesq.TabIndex = 24;
            lblpesq.Text = "Pesquisar Pelo Nome do Produto:";
            // 
            // codPropLabel
            // 
            codPropLabel.AutoSize = true;
            codPropLabel.Location = new System.Drawing.Point(187, 24);
            codPropLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codPropLabel.Name = "codPropLabel";
            codPropLabel.Size = new System.Drawing.Size(122, 20);
            codPropLabel.TabIndex = 25;
            codPropLabel.Text = "Cod Fabricante:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 0);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(270, 20);
            label1.TabIndex = 24;
            label1.Text = "Pesquisar Pelo Código do Fabricante";
            // 
            // nCMLabel
            // 
            nCMLabel.AutoSize = true;
            nCMLabel.Location = new System.Drawing.Point(28, 20);
            nCMLabel.Name = "nCMLabel";
            nCMLabel.Size = new System.Drawing.Size(48, 20);
            nCMLabel.TabIndex = 0;
            nCMLabel.Text = "NCM:";
            // 
            // cSTLabel
            // 
            cSTLabel.AutoSize = true;
            cSTLabel.Location = new System.Drawing.Point(28, 92);
            cSTLabel.Name = "cSTLabel";
            cSTLabel.Size = new System.Drawing.Size(44, 20);
            cSTLabel.TabIndex = 2;
            cSTLabel.Text = "CST:";
            // 
            // cFOPLabel
            // 
            cFOPLabel.AutoSize = true;
            cFOPLabel.Location = new System.Drawing.Point(28, 156);
            cFOPLabel.Name = "cFOPLabel";
            cFOPLabel.Size = new System.Drawing.Size(56, 20);
            cFOPLabel.TabIndex = 4;
            cFOPLabel.Text = "CFOP:";
            // 
            // iCMSLabel
            // 
            iCMSLabel.AutoSize = true;
            iCMSLabel.Location = new System.Drawing.Point(31, 226);
            iCMSLabel.Name = "iCMSLabel";
            iCMSLabel.Size = new System.Drawing.Size(53, 20);
            iCMSLabel.TabIndex = 6;
            iCMSLabel.Text = "ICMS:";
            // 
            // iPILabel
            // 
            iPILabel.AutoSize = true;
            iPILabel.Location = new System.Drawing.Point(204, 226);
            iPILabel.Name = "iPILabel";
            iPILabel.Size = new System.Drawing.Size(33, 20);
            iPILabel.TabIndex = 8;
            iPILabel.Text = "IPI:";
            // 
            // cSOSNLabel
            // 
            cSOSNLabel.AutoSize = true;
            cSOSNLabel.Location = new System.Drawing.Point(334, 92);
            cSOSNLabel.Name = "cSOSNLabel";
            cSOSNLabel.Size = new System.Drawing.Size(69, 20);
            cSOSNLabel.TabIndex = 10;
            cSOSNLabel.Text = "CSOSN:";
            // 
            // simplebaseDataSet
            // 
            this.simplebaseDataSet.DataSetName = "simplebaseDataSet";
            this.simplebaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.simplebaseDataSet;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.FuncionariosTableAdapter = null;
            this.tableAdapterManager.ImagensTableAdapter = null;
            this.tableAdapterManager.ItemsTableAdapter = this.itemsTableAdapter;
            this.tableAdapterManager.ProdutoVendaTableAdapter = null;
            this.tableAdapterManager.SenhamestreTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = simplestock.simplebaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendasExcluidasTableAdapter = null;
            this.tableAdapterManager.VendaTableAdapter = null;
            // 
            // itemsBindingNavigator
            // 
            this.itemsBindingNavigator.AddNewItem = null;
            this.itemsBindingNavigator.BindingSource = this.itemsBindingSource;
            this.itemsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.itemsBindingNavigator.CountItemFormat = "DE {0}";
            this.itemsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.itemsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem});
            this.itemsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.itemsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.itemsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.itemsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.itemsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.itemsBindingNavigator.Name = "itemsBindingNavigator";
            this.itemsBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.itemsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.itemsBindingNavigator.Size = new System.Drawing.Size(710, 25);
            this.itemsBindingNavigator.TabIndex = 0;
            this.itemsBindingNavigator.Text = "bindingNavigator1";
            this.itemsBindingNavigator.RefreshItems += new System.EventHandler(this.itemsBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 22);
            this.bindingNavigatorCountItem.Text = "DE {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 23);
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
            // txtcod
            // 
            this.txtcod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Codigo", true));
            this.txtcod.Location = new System.Drawing.Point(19, 48);
            this.txtcod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcod.Name = "txtcod";
            this.txtcod.ReadOnly = true;
            this.txtcod.Size = new System.Drawing.Size(148, 26);
            this.txtcod.TabIndex = 1;
            // 
            // txtproduto
            // 
            this.txtproduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Produto", true));
            this.txtproduto.Location = new System.Drawing.Point(18, 122);
            this.txtproduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtproduto.Name = "txtproduto";
            this.txtproduto.Size = new System.Drawing.Size(674, 26);
            this.txtproduto.TabIndex = 2;
            this.txtproduto.TextChanged += new System.EventHandler(this.produtoTextBox_TextChanged);
            // 
            // txtmarca
            // 
            this.txtmarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Marca", true));
            this.txtmarca.Location = new System.Drawing.Point(18, 251);
            this.txtmarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(186, 26);
            this.txtmarca.TabIndex = 4;
            // 
            // txtquantidade
            // 
            this.txtquantidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Quantidade", true));
            this.txtquantidade.Location = new System.Drawing.Point(252, 251);
            this.txtquantidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.ReadOnly = true;
            this.txtquantidade.Size = new System.Drawing.Size(150, 26);
            this.txtquantidade.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 441);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(342, 441);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 63);
            this.button2.TabIndex = 2;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(464, 441);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 63);
            this.button3.TabIndex = 3;
            this.button3.Text = "Alterar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(584, 441);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 63);
            this.button5.TabIndex = 4;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cbfornecedor
            // 
            this.cbfornecedor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemsBindingSource, "Fornecedor", true));
            this.cbfornecedor.DataSource = this.fornecedoresBindingSource;
            this.cbfornecedor.DisplayMember = "NomeFantasia";
            this.cbfornecedor.FormattingEnabled = true;
            this.cbfornecedor.Location = new System.Drawing.Point(17, 182);
            this.cbfornecedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbfornecedor.Name = "cbfornecedor";
            this.cbfornecedor.Size = new System.Drawing.Size(675, 28);
            this.cbfornecedor.TabIndex = 3;
            this.cbfornecedor.ValueMember = "NomeFantasia";
            this.cbfornecedor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // txtvalorvenda
            // 
            this.txtvalorvenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "ValorVenda", true));
            this.txtvalorvenda.Location = new System.Drawing.Point(575, 251);
            this.txtvalorvenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtvalorvenda.Name = "txtvalorvenda";
            this.txtvalorvenda.Size = new System.Drawing.Size(117, 26);
            this.txtvalorvenda.TabIndex = 7;
            this.txtvalorvenda.TextChanged += new System.EventHandler(this.txtvalorvenda_TextChanged);
            this.txtvalorvenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalorvenda_KeyPress);
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.Location = new System.Drawing.Point(18, 23);
            this.txtpesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.Size = new System.Drawing.Size(205, 26);
            this.txtpesquisar.TabIndex = 5;
            // 
            // btnpesq
            // 
            this.btnpesq.Location = new System.Drawing.Point(234, 23);
            this.btnpesq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnpesq.Name = "btnpesq";
            this.btnpesq.Size = new System.Drawing.Size(112, 32);
            this.btnpesq.TabIndex = 6;
            this.btnpesq.Text = "Pesquisar";
            this.btnpesq.UseVisualStyleBackColor = true;
            this.btnpesq.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // fornecedoresItemsBindingSource
            // 
            this.fornecedoresItemsBindingSource.DataMember = "FornecedoresItems";
            this.fornecedoresItemsBindingSource.DataSource = this.fornecedoresBindingSource;
            // 
            // txtvalorcusto
            // 
            this.txtvalorcusto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "ValorCusto", true));
            this.txtvalorcusto.Location = new System.Drawing.Point(441, 251);
            this.txtvalorcusto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtvalorcusto.Name = "txtvalorcusto";
            this.txtvalorcusto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtvalorcusto.Size = new System.Drawing.Size(117, 26);
            this.txtvalorcusto.TabIndex = 6;
            this.txtvalorcusto.Tag = "";
            this.txtvalorcusto.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtvalorcusto_MaskInputRejected);
            this.txtvalorcusto.TextChanged += new System.EventHandler(this.txtvalorcusto_TextChanged_1);
            this.txtvalorcusto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtvalorcusto_KeyDown);
            this.txtvalorcusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalorcusto_KeyPress_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtvalorcusto);
            this.groupBox1.Controls.Add(fornecedorLabel);
            this.groupBox1.Controls.Add(codPropLabel);
            this.groupBox1.Controls.Add(this.txtproduto);
            this.groupBox1.Controls.Add(this.CodProp);
            this.groupBox1.Controls.Add(this.txtvalorvenda);
            this.groupBox1.Controls.Add(this.txtcod);
            this.groupBox1.Controls.Add(produtoLabel);
            this.groupBox1.Controls.Add(valorVendaLabel1);
            this.groupBox1.Controls.Add(codigoLabel);
            this.groupBox1.Controls.Add(this.txtmarca);
            this.groupBox1.Controls.Add(valorCustoLabel1);
            this.groupBox1.Controls.Add(marcaLabel);
            this.groupBox1.Controls.Add(this.cbfornecedor);
            this.groupBox1.Controls.Add(this.txtquantidade);
            this.groupBox1.Controls.Add(quantidadeLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(696, 294);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // CodProp
            // 
            this.CodProp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "CodProp", true));
            this.CodProp.Location = new System.Drawing.Point(191, 47);
            this.CodProp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CodProp.Name = "CodProp";
            this.CodProp.Size = new System.Drawing.Size(309, 26);
            this.CodProp.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(lblpesq);
            this.panel1.Controls.Add(this.txtpesquisar);
            this.panel1.Controls.Add(this.btnpesq);
            this.panel1.Location = new System.Drawing.Point(18, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 55);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(label1);
            this.panel2.Controls.Add(this.txtcodprop);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Location = new System.Drawing.Point(374, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 55);
            this.panel2.TabIndex = 26;
            // 
            // txtcodprop
            // 
            this.txtcodprop.Location = new System.Drawing.Point(18, 23);
            this.txtcodprop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcodprop.Name = "txtcodprop";
            this.txtcodprop.Size = new System.Drawing.Size(182, 26);
            this.txtcodprop.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(206, 22);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 32);
            this.button4.TabIndex = 8;
            this.button4.Text = "Pesquisar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_2);
            // 
            // fillBycodpropToolStrip
            // 
            this.fillBycodpropToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codPropToolStripLabel,
            this.codPropToolStripTextBox,
            this.fillBycodpropToolStripButton});
            this.fillBycodpropToolStrip.Location = new System.Drawing.Point(0, 38);
            this.fillBycodpropToolStrip.Name = "fillBycodpropToolStrip";
            this.fillBycodpropToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.fillBycodpropToolStrip.Size = new System.Drawing.Size(736, 38);
            this.fillBycodpropToolStrip.TabIndex = 27;
            this.fillBycodpropToolStrip.Text = "fillBycodpropToolStrip";
            this.fillBycodpropToolStrip.Visible = false;
            // 
            // codPropToolStripLabel
            // 
            this.codPropToolStripLabel.Name = "codPropToolStripLabel";
            this.codPropToolStripLabel.Size = new System.Drawing.Size(57, 35);
            this.codPropToolStripLabel.Text = "CodProp:";
            // 
            // codPropToolStripTextBox
            // 
            this.codPropToolStripTextBox.Name = "codPropToolStripTextBox";
            this.codPropToolStripTextBox.Size = new System.Drawing.Size(148, 38);
            // 
            // fillBycodpropToolStripButton
            // 
            this.fillBycodpropToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBycodpropToolStripButton.Name = "fillBycodpropToolStripButton";
            this.fillBycodpropToolStripButton.Size = new System.Drawing.Size(84, 35);
            this.fillBycodpropToolStripButton.Text = "FillBycodprop";
            this.fillBycodpropToolStripButton.Click += new System.EventHandler(this.fillBycodpropToolStripButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 101);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(710, 333);
            this.tabControl1.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(702, 300);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Descrição";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cFOPComboBox);
            this.tabPage2.Controls.Add(cSOSNLabel);
            this.tabPage2.Controls.Add(this.cSOSNComboBox);
            this.tabPage2.Controls.Add(this.cSTComboBox);
            this.tabPage2.Controls.Add(iPILabel);
            this.tabPage2.Controls.Add(this.iPITextBox);
            this.tabPage2.Controls.Add(iCMSLabel);
            this.tabPage2.Controls.Add(this.iCMSTextBox);
            this.tabPage2.Controls.Add(cFOPLabel);
            this.tabPage2.Controls.Add(cSTLabel);
            this.tabPage2.Controls.Add(nCMLabel);
            this.tabPage2.Controls.Add(this.nCMTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(702, 300);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fiscal";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cSOSNComboBox
            // 
            this.cSOSNComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "CSOSN", true));
            this.cSOSNComboBox.FormattingEnabled = true;
            this.cSOSNComboBox.Items.AddRange(new object[] {
            "101\r - Tributada pelo Simples Nacional com permissão de crédito",
            "102\r - Tributada pelo Simples Nacional sem permissão de crédito",
            "103\r - Isenção do ICMS no Simples Nacional para faixa de receita bruta ",
            "201\r - Tributada pelo Simples Nacional com permissão de crédito e com cobrança do" +
                " ICMS por substituição tributária",
            "202\r - Tributada pelo Simples Nacional sem permissão de crédito e com cobrança do" +
                " ICMS por substituição tributária",
            "203 - Isenção do ICMS no Simples Nacional para faixa de receita bruta e com cobra" +
                "nça do ICMS por substituição tributária",
            "300\r - Imune",
            "400\r - Não tributada pelo Simples Nacional ",
            "500\r - ICMS cobrado anteriormente por substituição tributária (substituído) ou po" +
                "r antecipação ",
            "900\r - Outros"});
            this.cSOSNComboBox.Location = new System.Drawing.Point(338, 115);
            this.cSOSNComboBox.Name = "cSOSNComboBox";
            this.cSOSNComboBox.Size = new System.Drawing.Size(294, 28);
            this.cSOSNComboBox.TabIndex = 3;
            // 
            // cSTComboBox
            // 
            this.cSTComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "CST", true));
            this.cSTComboBox.FormattingEnabled = true;
            this.cSTComboBox.Items.AddRange(new object[] {
            "000 Tributada integralmente",
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "010 Tributada e com cobrança do ICMS por substituição tributária",
            "110",
            "210",
            "310",
            "410",
            "510",
            "610",
            "710",
            "020 Com redução da base de cálculo",
            "120",
            "220",
            "320",
            "420",
            "520",
            "620",
            "720",
            "030 Isenta ou não-tributada e com cobrança do ICMS por substituição tributária",
            "130",
            "230",
            "330",
            "430",
            "530",
            "630",
            "730",
            "040 Isenta",
            "140",
            "240",
            "340",
            "440",
            "540",
            "640",
            "740",
            "041 Não-tributada",
            "141",
            "241",
            "341",
            "441",
            "541",
            "641",
            "741",
            "050 Suspensão",
            "150",
            "250",
            "350",
            "450",
            "550",
            "650",
            "750",
            "051 Diferimento",
            "151",
            "251",
            "351",
            "451",
            "551",
            "651",
            "751",
            "060 ICMS cobrado anteriormente por substituição tributária",
            "160",
            "260",
            "360",
            "460",
            "560",
            "660",
            "760"});
            this.cSTComboBox.Location = new System.Drawing.Point(35, 115);
            this.cSTComboBox.Name = "cSTComboBox";
            this.cSTComboBox.Size = new System.Drawing.Size(273, 28);
            this.cSTComboBox.TabIndex = 2;
            // 
            // iPITextBox
            // 
            this.iPITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "IPI", true));
            this.iPITextBox.Location = new System.Drawing.Point(208, 249);
            this.iPITextBox.Name = "iPITextBox";
            this.iPITextBox.Size = new System.Drawing.Size(100, 26);
            this.iPITextBox.TabIndex = 6;
            // 
            // iCMSTextBox
            // 
            this.iCMSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "ICMS", true));
            this.iCMSTextBox.Location = new System.Drawing.Point(35, 249);
            this.iCMSTextBox.Name = "iCMSTextBox";
            this.iCMSTextBox.Size = new System.Drawing.Size(100, 26);
            this.iCMSTextBox.TabIndex = 5;
            // 
            // nCMTextBox
            // 
            this.nCMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "NCM", true));
            this.nCMTextBox.Location = new System.Drawing.Point(32, 43);
            this.nCMTextBox.Name = "nCMTextBox";
            this.nCMTextBox.Size = new System.Drawing.Size(242, 26);
            this.nCMTextBox.TabIndex = 1;
            // 
            // cFOPComboBox
            // 
            this.cFOPComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "CFOP", true));
            this.cFOPComboBox.FormattingEnabled = true;
            this.cFOPComboBox.Items.AddRange(new object[] {
            "1.100 - COMPRAS PARA INDUSTRIALIZAÇÃO, COMERCIALIZAÇÃO OU PRESTAÇÃO DE SERVIÇOS ",
            "1.101 - Compra para industrialização ou produção rural ",
            "1.102 - Compra para comercialização ",
            "1.111 - Compra para industrialização de mercadoria recebida anteriormente em cons" +
                "ignação industrial ",
            "1.113 - Compra para comercialização, de mercadoria recebida anteriormente em cons" +
                "ignação mercantil ",
            "1.116 - Compra para industrialização ou produção rural originada de encomenda par" +
                "a recebimento futuro ",
            "1.117 - Compra para comercialização originada de encomenda para recebimento futur" +
                "o ",
            "1.118 - Compra de mercadoria para comercialização pelo adquirente originário, ent" +
                "regue pelo vendedor remetente ao destinatário, em venda à ordem ",
            "1.120 - Compra para industrialização, em venda à ordem, já recebida do vendedor r" +
                "emetente ",
            "1.121 - Compra para comercialização, em venda à ordem, já recebida do vendedor re" +
                "metente ",
            "1.122 - Compra para industrialização em que a mercadoria foi remetida pelo fornec" +
                "edor ao industrializador sem transitar pelo estabelecimento adquirente ",
            "1.124 - Industrialização efetuada por outra empresa ",
            "1.125 - Industrialização efetuada por outra empresa quando a mercadoria remetida " +
                "para utilização no processo de industrialização não transitou pelo estabelecimen" +
                "to adquirente da mercadoria ",
            "1.126 - compras para utilização na prestação de serviços sujeitas ao ICMS ",
            "1.128 - compras para utilização na prestação de serviços sujeitas ao ISSQN ",
            "1.150 - TRANSFERÊNCIAS PARA INDUSTRIALIZAÇÃO, COMERCIALIZAÇÃO OU PRESTAÇÃO DE SER" +
                "VIÇOS ",
            "1.151 - Transferência para industrialização ou produção rural ",
            "1.152 - Transferência para comercialização ",
            "1.153 - Transferência de energia elétrica para distribuição ",
            "1.154 - Transferência para utilização na prestação de serviço ",
            "1.200 - DEVOLUÇÕES DE VENDAS DE PRODUÇÃO PRÓPRIA, DE TERCEIROS OU ANULAÇÕES DE VA" +
                "LORES ",
            "1.201 - Devolução de venda de produção do estabelecimento ",
            "1.202 - Devolução de venda de mercadoria adquirida ou recebida de terceiros ",
            "1.203 - Devolução de venda de produção do estabelecimento, destinada à Zona Franc" +
                "a de Manaus ou Áreas de Livre Comércio ",
            "1.204 - Devolução de venda de mercadoria adquirida ou recebida de terceiros, dest" +
                "inada à Zona Franca de Manaus ou Áreas de Livre Comércio ",
            "1.205 - Anulação de valor relativo à prestação de serviço de comunicação ",
            "1.206 - Anulação de valor relativo à prestação de serviço de transporte ",
            "1.207 - Anulação de valor relativo à venda de energia elétrica ",
            "1.208 - Devolução de produção do estabelecimento, remetida em transferência ",
            "1.209 - Devolução de mercadoria adquirida ou recebida de terceiros, remetida em t" +
                "ransferência ",
            "1.250 - COMPRAS DE ENERGIA ELÉTRICA ",
            "1.251 - Compra de energia elétrica para distribuição ou comercialização ",
            "1.252 - Compra de energia elétrica por estabelecimento industrial ",
            "1.253 - Compra de energia elétrica por estabelecimento comercial ",
            "1.254 - Compra de energia elétrica por estabelecimento prestador de serviço de tr" +
                "ansporte ",
            "1.255 - Compra de energia elétrica por estabelecimento prestador de serviço de co" +
                "municação ",
            "1.256 - Compra de energia elétrica por estabelecimento de produtor rural ",
            "1.257 - Compra de energia elétrica para consumo por demanda contratada ",
            "1.300 - AQUISIÇÕES DE SERVIÇOS DE COMUNICAÇÃO ",
            "1.301 - Aquisição de serviço de comunicação para execução de serviço da mesma nat" +
                "ureza ",
            "1.302 - Aquisição de serviço de comunicação por estabelecimento industrial ",
            "1.303 - Aquisição de serviço de comunicação por estabelecimento comercial ",
            "1.304 - Aquisição de serviço de comunicação por estabelecimento de prestador de s" +
                "erviço de transporte ",
            "1.305 - Aquisição de serviço de comunicação por estabelecimento de geradora ou de" +
                " distribuidora de energia elétrica 1.306 - Aquisição de serviço de comunicação p" +
                "or estabelecimento de produtor rural ",
            "1.350 - AQUISIÇÕES DE SERVIÇOS DE TRANSPORTE ",
            "1.351 - Aquisição de serviço de transporte para execução de serviço da mesma natu" +
                "reza ",
            "1.352 - Aquisição de serviço de transporte por estabelecimento industrial ",
            "1.353 - Aquisição de serviço de transporte por estabelecimento comercial ",
            "1.354 - Aquisição de serviço de transporte por estabelecimento de prestador de se" +
                "rviço de comunicação ",
            "1.355 - Aquisição de serviço de transporte por estabelecimento de geradora ou de " +
                "distribuidora de energia elétrica ",
            "1.356 - Aquisição de serviço de transporte por estabelecimento de produtor rural " +
                "",
            "1.360 - Aquisição de serviço de transporte por contribuinte substituto em relação" +
                " ao serviço de transporte ",
            "1.400 - ENTRADAS DE MERCADORIAS SUJEITAS AO REGIME DE SUBSTITUIÇÃO TRIBUTÁRIA ",
            "1.401 - Compra para industrialização ou produção rural em operação com mercadoria" +
                " sujeita ao regime de substituição tributária ",
            "1.403 - Compra para comercialização em operação com mercadoria sujeita ao regime " +
                "de substituição tributária ",
            "1.406 - Compra de bem para o ativo imobilizado cuja mercadoria está sujeita ao re" +
                "gime de substituição tributária ",
            "1.407 - Compra de mercadoria para uso ou consumo cuja mercadoria está sujeita ao " +
                "regime de substituição tributária ",
            "1.408 - Transferência para industrialização ou produção rural em operação com mer" +
                "cadoria sujeita ao regime de substituição tributária ",
            "1.409 - Transferência para comercialização em operação com mercadoria sujeita ao " +
                "regime de substituição tributária ",
            "1.410 - Devolução de venda de produção do estabelecimento em operação com produto" +
                " sujeito ao regime de substituição tributária ",
            "1.411 - Devolução de venda de mercadoria adquirida ou recebida de terceiros em op" +
                "eração com mercadoria sujeita ao regime de substituição tributária ",
            "1.414 - Retorno de produção do estabelecimento, remetida para venda fora do estab" +
                "elecimento em operação com produto sujeito ao regime de substituição tributária " +
                "",
            "1.415 - Retorno de mercadoria adquirida ou recebida de terceiros, remetida para v" +
                "enda fora do estabelecimento em operação com mercadoria sujeita ao regime de sub" +
                "stituição tributária ",
            "1.450 - SISTEMAS DE INTEGRAÇÃO ",
            "1.451 - Retorno de animal do estabelecimento produtor ",
            "1.452 - Retorno de insumo não utilizado na produção",
            "1.500 - ENTRADAS DE MERCADORIAS REMETIDAS COM FIM ESPECÍFICO DE EXPORTAÇÃO E EVEN" +
                "TUAIS DEVOLUÇÕES ",
            "1.501 - Entrada de mercadoria recebida com fim específico de exportação ",
            "1.503 - Entrada decorrente de devolução de produto remetido com fim específico de" +
                " exportação, de produção do estabelecimento ",
            "1.504 - Entrada decorrente de devolução de mercadoria remetida com fim específico" +
                " de exportação, adquirida ou recebida de terceiros ",
            "1.505 - Entrada decorrente de devolução simbólica de mercadorias remetidas para f" +
                "ormação de lote de exportação, de produtos industrializados ou produzidos pelo p" +
                "róprio estabelecimento ",
            "1.506 - Entrada decorrente de devolução simbólica de mercadorias, adquiridas ou r" +
                "ecebidas de terceiros, remetidas para formação de lote de exportação ",
            "1.550 - OPERAÇÕES COM BENS DE ATIVO IMOBILIZADO E MATERIAIS PARA USO OU CONSUMO ",
            "1.551 - Compra de bem para o ativo imobilizado ",
            "1.552 - Transferência de bem do ativo imobilizado ",
            "1.553 - Devolução de venda de bem do ativo imobilizado ",
            "1.554 - Retorno de bem do ativo imobilizado remetido para uso fora do estabelecim" +
                "ento ",
            "1.555 - Entrada de bem do ativo imobilizado de terceiro, remetido para uso no est" +
                "abelecimento ",
            "1.556 - Compra de material para uso ou consumo ",
            "1.557 - Transferência de material para uso ou consumo ",
            "1.600 - CRÉDITOS E RESSARCIMENTOS DE ICMS ",
            "1.601 - Recebimento, por transferência, de crédito de ICMS ",
            "1.602 - Recebimento, por transferência, de saldo credor de ICMS de outro estabele" +
                "cimento da mesma empresa, para compensação de saldo devedor de ICMS ",
            "1.603 - Ressarcimento de ICMS retido por substituição tributária 1.604 - Lançamen" +
                "to do crédito relativo à compra de bem para o ativo imobilizado ",
            "1.605 - Recebimento, por transferência, de saldo devedor de ICMS de outro estabel" +
                "ecimento da mesma empresa ",
            "1.652 - Compra de combustível ou lubrificante para comercialização ",
            "1.653 - Compra de combustível ou lubrificante por consumidor ou usuário final ",
            "1.658 - Transferência de combustível e lubrificante para industrialização ",
            "1.659 - Transferência de combustível e lubrificante para comercialização ",
            "1.660 - Devolução de venda de combustível ou lubrificante destinado à industriali" +
                "zação subseqüente ",
            "1.661 - Devolução de venda de combustível ou lubrificante destinado à comercializ" +
                "ação ",
            "1.662 - Devolução de venda de combustível ou lubrificante destinado a consumidor " +
                "ou usuário final ",
            "1.663 - Entrada de combustível ou lubrificante para armazenagem ",
            "1.664 - Retorno de combustível ou lubrificante remetido para armazenagem ",
            "1.900 - OUTRAS ENTRADAS DE MERCADORIAS OU AQUISIÇÕES DE SERVIÇOS ",
            "1.901 - Entrada para industrialização por encomenda",
            "1.902 - Retorno de mercadoria remetida para industrialização por encomenda ",
            "1.903 - Entrada de mercadoria remetida para industrialização e não aplicada no re" +
                "ferido processo ",
            "1.904 - Retorno de remessa para venda fora do estabelecimento ",
            "1.905 - Entrada de mercadoria recebida para depósito em depósito fechado ou armaz" +
                "ém geral ",
            "1.906 - Retorno de mercadoria remetida para depósito fechado ou armazém geral ",
            "1.907 - Retorno simbólico de mercadoria remetida para depósito fechado ou armazém" +
                " geral ",
            "1.908 - Entrada de bem por conta de contrato de comodato ",
            "1.909 - Retorno de bem remetido por conta de contrato de comodato ",
            "1.910 - Entrada de bonificação, doação ou brinde ",
            "1.911 - Entrada de amostra grátis ",
            "1.912 - Entrada de mercadoria ou bem recebido para demonstração ",
            "1.913 - Retorno de mercadoria ou bem remetido para demonstração ",
            "1.914 - Retorno de mercadoria ou bem remetido para exposição ou feira ",
            "1.915 - Entrada de mercadoria ou bem recebido para conserto ou reparo ",
            "1.916 - Retorno de mercadoria ou bem remetido para conserto ou reparo ",
            "1.917 - Entrada de mercadoria recebida em consignação mercantil ou industrial ",
            "1.918 - Devolução de mercadoria remetida em consignação mercantil ou industrial ",
            "1.919 - Devolução simbólica de mercadoria vendida ou utilizada em processo indust" +
                "rial, remetida anteriormente em consignação mercantil ou industrial ",
            "1.920 - Entrada de vasilhame ou sacaria ",
            "1.921 - Retorno de vasilhame ou sacaria ",
            "1.922 - Lançamento efetuado a título de simples faturamento decorrente de compra " +
                "para recebimento futuro ",
            "1.923 - Entrada de mercadoria recebida do vendedor remetente, em venda à ordem ",
            "1.924 - Entrada para industrialização por conta e ordem do adquirente da mercador" +
                "ia, quando esta não transitar pelo estabelecimento do adquirente ",
            "1.925 - Retorno de mercadoria remetida para industrialização por conta e ordem do" +
                " adquirente da mercadoria, quando esta não transitar pelo estabelecimento do adq" +
                "uirente ",
            "1.926 - Lançamento efetuado a título de reclassificação de mercadoria decorrente " +
                "de formação de kit ou de sua desagregação ",
            resources.GetString("cFOPComboBox.Items"),
            "1.932 - Aquisição de serviço de transporte iniciado em unidade da Federação diver" +
                "sa daquela onde inscrito o prestador ",
            "1.933 - Aquisição de serviço tributado pelo ISSQN ",
            "1.949 - Outra entrada de mercadoria ou prestação de serviço não especificada ",
            "2.000 - ENTRADAS OU AQUISIÇÕES DE SERVIÇOS DE OUTROS ESTADOS ",
            "2.100 - COMPRAS PARA INDUSTRIALIZAÇÃO, COMERCIALIZAÇÃO OU PRESTAÇÃO DE SERVIÇOS ",
            "2.101 - Compra para industrialização ou produção rural ",
            "2.102 - Compra para comercialização ",
            "2.111 - Compra para industrialização de mercadoria recebida anteriormente em cons" +
                "ignação industrial ",
            "2.113 - Compra para comercialização, de mercadoria recebida anteriormente em cons" +
                "ignação mercantil ",
            "2.116 - Compra para industrialização ou produção rural originada de encomenda par" +
                "a recebimento futuro ",
            "2.117 - Compra para comercialização originada de encomenda para recebimento futur" +
                "o ",
            "2.118 - Compra de mercadoria para comercialização pelo adquirente originário, ent" +
                "regue pelo vendedor remetente ao destinatário, em venda à ordem ",
            "2.120 - Compra para industrialização, em venda à ordem, já recebida do vendedor r" +
                "emetente 2.121 - Compra para comercialização, em venda à ordem, já recebida do v" +
                "endedor remetente ",
            "2.122 - Compra para industrialização em que a mercadoria foi remetida pelo fornec" +
                "edor ao industrializador sem transitar pelo estabelecimento adquirente ",
            "2.124 - Industrialização efetuada por outra empresa",
            "2.125 - Industrialização efetuada por outra empresa quando a mercadoria remetida " +
                "para utilização no processo de industrialização não transitou pelo estabelecimen" +
                "to adquirente da mercadoria ",
            "2.126 - Compra para utilização na prestação de serviço ",
            "2.150 - TRANSFERÊNCIAS PARA INDUSTRIALIZAÇÃO, COMERCIALIZAÇÃO OU PRESTAÇÃO DE SER" +
                "VIÇOS ",
            "2.151 - Transferência para industrialização ou produção rural ",
            "2.152 - Transferência para comercialização ",
            "2.153 - Transferência de energia elétrica para distribuição ",
            "2.154 - Transferência para utilização na prestação de serviço ",
            "2.200 - DEVOLUÇÕES DE VENDAS DE PRODUÇÃO PRÓPRIA, DE TERCEIROS OU ANULAÇÕES DE VA" +
                "LORES ",
            "2.201 - Devolução de venda de produção do estabelecimento ",
            "2.202 - Devolução de venda de mercadoria adquirida ou recebida de terceiros ",
            "2.203 - Devolução de venda de produção do estabelecimento, destinada à Zona Franc" +
                "a de Manaus ou Áreas de Livre Comércio ",
            "2.204 - Devolução de venda de mercadoria adquirida ou recebida de terceiros, dest" +
                "inada à Zona Franca de Manaus ou Áreas de Livre Comércio ",
            "2.205 - Anulação de valor relativo à prestação de serviço de comunicação ",
            "2.206 - Anulação de valor relativo à prestação de serviço de transporte ",
            "2.207 - Anulação de valor relativo à venda de energia elétrica ",
            "2.208 - Devolução de produção do estabelecimento, remetida em transferência ",
            "2.209 - Devolução de mercadoria adquirida ou recebida de terceiros, remetida em t" +
                "ransferência ",
            "2.250 - COMPRAS DE ENERGIA ELÉTRICA ",
            "2.251 - Compra de energia elétrica para distribuição ou comercialização ",
            "2.252 - Compra de energia elétrica por estabelecimento industrial ",
            "2.253 - Compra de energia elétrica por estabelecimento comercial ",
            "2.254 - Compra de energia elétrica por estabelecimento prestador de serviço de tr" +
                "ansporte ",
            "2.255 - Compra de energia elétrica por estabelecimento prestador de serviço de co" +
                "municação ",
            "2.256 - Compra de energia elétrica por estabelecimento de produtor rural ",
            "2.257 - Compra de energia elétrica para consumo por demanda contratada ",
            "2.300 - AQUISIÇÕES DE SERVIÇOS DE COMUNICAÇÃO ",
            "2.301 - Aquisição de serviço de comunicação para execução de serviço da mesma nat" +
                "ureza ",
            "2.302 - Aquisição de serviço de comunicação por estabelecimento industrial ",
            "2.303 - Aquisição de serviço de comunicação por estabelecimento comercial ",
            "2.304 - Aquisição de serviço de comunicação por estabelecimento de prestador de s" +
                "erviço de transporte ",
            "2.305 - Aquisição de serviço de comunicação por estabelecimento de geradora ou de" +
                " distribuidora de energia elétrica ",
            "2.306 - Aquisição de serviço de comunicação por estabelecimento de produtor rural" +
                " ",
            "2.351 - Aquisição de serviço de transporte para execução de serviço da mesma natu" +
                "reza ",
            "2.352 - Aquisição de serviço de transporte por estabelecimento industrial ",
            "2.353 - Aquisição de serviço de transporte por estabelecimento comercial ",
            "2.354 - Aquisição de serviço de transporte por estabelecimento de prestador de se" +
                "rviço de comunicação ",
            "2.355 - Aquisição de serviço de transporte por estabelecimento de geradora ou de " +
                "distribuidora de energia elétrica ",
            "2.356 - Aquisição de serviço de transporte por estabelecimento de produtor rural " +
                "",
            "2.400 - ENTRADAS DE MERCADORIAS SUJEITAS AO REGIME DE SUBSTITUIÇÃO TRIBUTÁRIA ",
            "2.401 - Compra para industrialização ou produção rural em operação com mercadoria" +
                " sujeita ao regime desubstituição tributária ",
            "2.403 - Compra para comercialização em operação com mercadoria sujeita ao regime " +
                "de substituição tributária ",
            "2.406 - Compra de bem para o ativo imobilizado cuja mercadoria está sujeita ao re" +
                "gime de substituição tributária ",
            "2.407 - Compra de mercadoria para uso ou consumo cuja mercadoria está sujeita ao " +
                "regime de substituição tributária ",
            "2.408 - Transferência para industrialização ou produção rural em operação com mer" +
                "cadoria sujeita ao regime de substituição tributária ",
            "2.409 - Transferência para comercialização em operação com mercadoria sujeita ao " +
                "regime de substituição tributária ",
            "2.410 - Devolução de venda de produção do estabelecimento em operação com produto" +
                " sujeito ao regime desubstituição tributária ",
            "2.411 - Devolução de venda de mercadoria adquirida ou recebida de terceiros em op" +
                "eração com mercadoria sujeita ao regime de substituição tributária ",
            "2.414 - Retorno de produção do estabelecimento, remetida para venda fora do estab" +
                "elecimento em operação com produto sujeito ao regime de substituição tributária " +
                "",
            "2.415 - Retorno de mercadoria adquirida ou recebida de terceiros, remetida para v" +
                "enda fora do estabelecimento em operação com mercadoria sujeita ao regime de sub" +
                "stituição tributária ",
            "2.500 - ENTRADAS DE MERCADORIAS REMETIDAS COM FIM ESPECÍFICO DE EXPORTAÇÃO E EVEN" +
                "TUAIS DEVOLUÇÕES ",
            "2.501 - Entrada de mercadoria recebida com fim específico de exportação ",
            "2.503 - Entrada decorrente de devolução de produto remetido com fim específico de" +
                " exportação, de produção do estabelecimento ",
            "2.504 - Entrada decorrente de devolução de mercadoria remetida com fim específico" +
                " de exportação, adquirida ou recebida de terceiros ",
            "2.505 - Entrada decorrente de devolução simbólica de mercadorias remetidas para f" +
                "ormação de lote de exportação, de produtos industrializados ou produzidos pelo p" +
                "róprio estabelecimento ",
            "2.506 - Entrada decorrente de devolução simbólica de mercadorias, adquiridas ou r" +
                "ecebidas de terceiros, remetidas para formação de lote de exportação ",
            "2.550 - OPERAÇÕES COM BENS DE ATIVO IMOBILIZADO E MATERIAIS PARA USO OU CONSUMO ",
            "2.551 - Compra de bem para o ativo imobilizado ",
            "2.552 - Transferência de bem do ativo imobilizado ",
            "2.553 - Devolução de venda de bem do ativo imobilizado ",
            "2.554 - Retorno de bem do ativo imobilizado remetido para uso fora do estabelecim" +
                "ento ",
            "2.555 - Entrada de bem do ativo imobilizado de terceiro, remetido para uso no est" +
                "abelecimento ",
            "2.556 - Compra de material para uso ou consumo ",
            "2.557 - Transferência de material para uso ou consumo ",
            "2.600 - CRÉDITOS E RESSARCIMENTOS DE ICMS ",
            "2.603 - Ressarcimento de ICMS retido por substituição tributária ",
            "2.651 - Compra de combustível ou lubrificante para industrialização subseqüente ",
            "2.652 - Compra de combustível ou lubrificante para comercialização ",
            "2.653 - Compra de combustível ou lubrificante por consumidor ou usuário final ",
            "2.658 - Transferência de combustível e lubrificante para industrialização ",
            "2.659 - Transferência de combustível e lubrificante para comercialização ",
            "2.660 - Devolução de venda de combustível ou lubrificante destinado à industriali" +
                "zação subseqüente ",
            "2.661 - Devolução de venda de combustível ou lubrificante destinado à comercializ" +
                "ação ",
            "2.662 - Devolução de venda de combustível ou lubrificante destinado a consumidor " +
                "ou usuário final ",
            "2.663 - Entrada de combustível ou lubrificante para armazenagem ",
            "2.664 - Retorno de combustível ou lubrificante remetido para armazenagem ",
            "2.900 - OUTRAS ENTRADAS DE MERCADORIAS OU AQUISIÇÕES DE SERVIÇOS ",
            "2.901 - Entrada para industrialização por encomenda",
            "2.902 - Retorno de mercadoria remetida para industrialização por encomenda ",
            "2.903 - Entrada de mercadoria remetida para industrialização e não aplicada no re" +
                "ferido processo ",
            "2.904 - Retorno de remessa para venda fora do estabelecimento ",
            "2.905 - Entrada de mercadoria recebida para depósito em depósito fechado ou armaz" +
                "ém geral ",
            "2.906 - Retorno de mercadoria remetida para depósito fechado ou armazém geral ",
            "2.907 - Retorno simbólico de mercadoria remetida para depósito fechado ou armazém" +
                " geral ",
            "2.908 - Entrada de bem por conta de contrato de comodato ",
            "2.909 - Retorno de bem remetido por conta de contrato de comodato ",
            "2.910 - Entrada de bonificação, doação ou brinde ",
            "2.911 - Entrada de amostra grátis ",
            "2.912 - Entrada de mercadoria ou bem recebido para demonstração ",
            "2.913 - Retorno de mercadoria ou bem remetido para demonstração ",
            "2.914 - Retorno de mercadoria ou bem remetido para exposição ou feira ",
            "2.915 - Entrada de mercadoria ou bem recebido para conserto ou reparo ",
            "2.916 - Retorno de mercadoria ou bem remetido para conserto ou reparo ",
            "2.917 - Entrada de mercadoria recebida em consignação mercantil ou industrial ",
            "2.918 - Devolução de mercadoria remetida em consignação mercantil ou industrial ",
            "2.919 - Devolução simbólica de mercadoria vendida ou utilizada em processo indust" +
                "rial, remetida anteriormente em consignação mercantil ou industrial ",
            "2.920 - Entrada de vasilhame ou sacaria ",
            "2.921 - Retorno de vasilhame ou sacaria ",
            "2.922 - Lançamento efetuado a título de simples faturamento decorrente de compra " +
                "para recebimento futuro ",
            "2.923 - Entrada de mercadoria recebida do vendedor remetente, em venda à ordem ",
            "2.924 - Entrada para industrialização por conta e ordem do adquirente da mercador" +
                "ia, quando esta não transitar pelo estabelecimento do adquirente ",
            "2.925 - Retorno de mercadoria remetida para industrialização por conta e ordem do" +
                " adquirente da mercadoria, quando esta não transitar pelo estabelecimento do adq" +
                "uirente ",
            resources.GetString("cFOPComboBox.Items1"),
            "2.932 - Aquisição de serviço de transporte iniciado em unidade da Federação diver" +
                "sa daquela onde inscrito o prestador ",
            "2.933 - Aquisição de serviço tributado pelo ISSQN ",
            "2.949 - Outra entrada de mercadoria ou prestação de serviço não especificado ",
            "3.000 - ENTRADAS OU AQUISIÇÕES DE SERVIÇOS DO EXTERIOR ",
            "3.100 - COMPRAS PARA INDUSTRIALIZAÇÃO, COMERCIALIZAÇÃO OU PRESTAÇÃO DE SERVIÇOS ",
            "3.101 - Compra para industrialização ou produção rural ",
            "3.102 - Compra para comercialização ",
            "3.126 - Compra para utilização na prestação de serviço ",
            "3.127 - Compra para industrialização sob o regime de \"drawback\" ",
            "3.200 - DEVOLUÇÕES DE VENDAS DE PRODUÇÃO PRÓPRIA, DE TERCEIROS OU ANULAÇÕES DE VA" +
                "LORES ",
            "3.201 - Devolução de venda de produção do estabelecimento ",
            "3.202 - Devolução de venda de mercadoria adquirida ou recebida de terceiros ",
            "3.205 - Anulação de valor relativo à prestação de serviço de comunicação ",
            "3.206 - Anulação de valor relativo à prestação de serviço de transporte ",
            "3.207 - Anulação de valor relativo à venda de energia elétrica ",
            "3.211 - Devolução de venda de produção do estabelecimento sob o regime de \"drawba" +
                "ck\" ",
            "3.250 - COMPRAS DE ENERGIA ELÉTRICA ",
            "3.251 - Compra de energia elétrica para distribuição ou comercialização ",
            "3.300 - AQUISIÇÕES DE SERVIÇOS DE COMUNICAÇÃO ",
            "3.301 - Aquisição de serviço de comunicação para execução de serviço da mesma nat" +
                "ureza ",
            "3.350 - AQUISIÇÕES DE SERVIÇOS DE TRANSPORTE ",
            "3.351 - Aquisição de serviço de transporte para execução de serviço da mesma natu" +
                "reza ",
            "3.352 - Aquisição de serviço de transporte por estabelecimento industrial ",
            "3.353 - Aquisição de serviço de transporte por estabelecimento comercial ",
            "3.354 - Aquisição de serviço de transporte por estabelecimento de prestador de se" +
                "rviço de comunicação ",
            "3.355 - Aquisição de serviço de transporte por estabelecimento de geradora ou de " +
                "distribuidora de energia elétrica ",
            "3.356 - Aquisição de serviço de transporte por estabelecimento de produtor rural " +
                "",
            "3.500 - ENTRADAS DE MERCADORIAS REMETIDAS COM FIM ESPECÍFICO DE EXPORTAÇÃO E EVEN" +
                "TUAIS DEVOLUÇÕES ",
            "3.503 - Devolução de mercadoria exportada que tenha sido recebida com fim específ" +
                "ico de exportação ",
            "3.550 - OPERAÇÕES COM BENS DE ATIVO IMOBILIZADO E MATERIAIS PARA USO OU CONSUMO ",
            "3.551 - Compra de bem para o ativo imobilizado ",
            "3.553 - Devolução de venda de bem do ativo imobilizado ",
            "3.556 - Compra de material para uso ou consumo ",
            "3.651 - Compra de combustível ou lubrificante para industrialização subseqüente ",
            "3.652 - Compra de combustível ou lubrificante para comercialização ",
            "3.653 - Compra de combustível ou lubrificante por consumidor ou usuário final ",
            "3.900 - OUTRAS ENTRADAS DE MERCADORIAS OU AQUISIÇÕES DE SERVIÇOS ",
            "3.930 - Lançamento efetuado a título de entrada de bem sob amparo de regime espec" +
                "ial aduaneiro de admissão temporária ",
            "3.949 - Outra entrada de mercadoria ou prestação de serviço não especificado ",
            "5.000 - SAÍDAS OU PRESTAÇÕES DE SERVIÇOS PARA O ESTADO ",
            "5.100 - VENDAS DE PRODUÇÃO PRÓPRIA OU DE TERCEIROS ",
            "5.101 - Venda de produção do estabelecimento ",
            "5.102 - Venda de mercadoria adquirida ou recebida de terceiros ",
            "5.103 - Venda de produção do estabelecimento, efetuada fora do estabelecimento ",
            "5.104 - Venda de mercadoria adquirida ou recebida de terceiros, efetuada fora do " +
                "estabelecimento ",
            "5.105 - Venda de produção do estabelecimento que não deva por ele transitar ",
            "5.106 - Venda de mercadoria adquirida ou recebida de terceiros, que não deva por " +
                "ele transitar ",
            "5.109 - Venda de produção do estabelecimento, destinada à Zona Franca de Manaus o" +
                "u Áreas de Livre Comércio ",
            "5.110 - Venda de mercadoria adquirida ou recebida de terceiros, destinada à Zona " +
                "Franca de Manaus ou Áreas de Livre Comércio ",
            "5.111 - Venda de produção do estabelecimento remetida anteriormente em consignaçã" +
                "o industrial ",
            "5.112 - Venda de mercadoria adquirida ou recebida de terceiros remetida anteriorm" +
                "ente em consignação industrial ",
            "5.113 - Venda de produção do estabelecimento remetida anteriormente em consignaçã" +
                "o mercantil ",
            "5.114 - Venda de mercadoria adquirida ou recebida de terceiros remetida anteriorm" +
                "ente em consignação mercantil ",
            "5.115 - Venda de mercadoria adquirida ou recebida de terceiros, recebida anterior" +
                "mente em consignação mercantil ",
            "5.116 - Venda de produção do estabelecimento originada de encomenda para entrega " +
                "futura ",
            "5.117 - Venda de mercadoria adquirida ou recebida de terceiros, originada de enco" +
                "menda para entrega futura ",
            "5.118 - Venda de produção do estabelecimento entregue ao destinatário por conta e" +
                " ordem do adquirente originário, em venda à ordem ",
            "5.119 - Venda de mercadoria adquirida ou recebida de terceiros entregue ao destin" +
                "atário por conta e ordem do adquirente originário, em venda à ordem ",
            "5.120 - Venda de mercadoria adquirida ou recebida de terceiros entregue ao destin" +
                "atário pelo vendedor remetente, Em venda à ordem ",
            "5.122 - Venda de produção do estabelecimento remetida para industrialização, por " +
                "conta e ordem do adquirente, sem transitar pelo estabelecimento do adquirente ",
            "5.123 - Venda de mercadoria adquirida ou recebida de terceiros remetida para indu" +
                "strialização, por conta e ordem do adquirente, sem transitar pelo estabeleciment" +
                "o do adquirente ",
            "5.124 - Industrialização efetuada para outra empresa ",
            "5.125 - Industrialização efetuada para outra empresa quando a mercadoria recebida" +
                " para utilização no processo de industrialização não transitar pelo estabelecime" +
                "nto adquirente da mercadoria ",
            "5.150 - TRANSFERÊNCIAS DE PRODUÇÃO PRÓPRIA OU DE TERCEIROS ",
            "5.151 - Transferência de produção do estabelecimento ",
            "5.152 - Transferência de mercadoria adquirida ou recebida de terceiros ",
            "5.153 - Transferência de energia elétrica ",
            "5.155 - Transferência de produção do estabelecimento, que não deva por ele transi" +
                "tar ",
            "5.156 - Transferência de mercadoria adquirida ou recebida de terceiros, que não d" +
                "eva por ele transitar",
            "5.200 - DEVOLUÇÕES DE COMPRAS PARA INDUSTRIALIZAÇÃO, COMERCIALIZAÇÃO OU ANULAÇÕES" +
                " DE VALORES ",
            "5.201 - Devolução de compra para industrialização ou produção rural ",
            "5.202 - Devolução de compra para comercialização ",
            "5.205 - Anulação de valor relativo a aquisição de serviço de comunicação ",
            "5.206 - Anulação de valor relativo a aquisição de serviço de transporte ",
            "5.207 - Anulação de valor relativo à compra de energia elétrica ",
            "5.208 - Devolução de mercadoria recebida em transferência para industrialização o" +
                "u produção rural ",
            "5.209 - Devolução de mercadoria recebida em transferência para comercialização ",
            "5.210 - Devolução de compra para utilização na prestação de serviço sujeitas ao I" +
                "CMS ou ISSQN ",
            "5.250 - VENDAS DE ENERGIA ELÉTRICA ",
            "5.251 - Venda de energia elétrica para distribuição ou comercialização ",
            "5.252 - Venda de energia elétrica para estabelecimento industrial ",
            "5.253 - Venda de energia elétrica para estabelecimento comercial ",
            "5.254 - Venda de energia elétrica para estabelecimento prestador de serviço de tr" +
                "ansporte ",
            "5.255 - Venda de energia elétrica para estabelecimento prestador de serviço de co" +
                "municação ",
            "5.256 - Venda de energia elétrica para estabelecimento de produtor rural ",
            "5.257 - Venda de energia elétrica para consumo por demanda contratada ",
            "5.258 - Venda de energia elétrica a não contribuinte ",
            "5.300 - PRESTAÇÕES DE SERVIÇOS DE COMUNICAÇÃO ",
            "5.301 - Prestação de serviço de comunicação para execução de serviço da mesma nat" +
                "ureza ",
            "5.302 - Prestação de serviço de comunicação a estabelecimento industrial ",
            "5.303 - Prestação de serviço de comunicação a estabelecimento comercial ",
            "5.304 - Prestação de serviço de comunicação a estabelecimento de prestador de ser" +
                "viço de transporte ",
            "5.305 - Prestação de serviço de comunicação a estabelecimento de geradora ou de d" +
                "istribuidora de energia elétrica ",
            "5.306 - Prestação de serviço de comunicação a estabelecimento de produtor rural ",
            "5.307 - Prestação de serviço de comunicação a não contribuinte ",
            "5.350 - PRESTAÇÕES DE SERVIÇOS DE TRANSPORTE ",
            "5.351 - Prestação de serviço de transporte para execução de serviço da mesma natu" +
                "reza ",
            "5.352 - Prestação de serviço de transporte a estabelecimento industrial ",
            "5.353 - Prestação de serviço de transporte a estabelecimento comercial ",
            "5.354 - Prestação de serviço de transporte a estabelecimento de prestador de serv" +
                "iço de comunicação ",
            "5.355 - Prestação de serviço de transporte a estabelecimento de geradora ou de di" +
                "stribuidora de energia elétrica ",
            "5.356 - Prestação de serviço de transporte a estabelecimento de produtor rural ",
            "5.357 - Prestação de serviço de transporte a não contribuinte ",
            "5.359 - Prestação de serviço de transporte a contribuinte ou a não contribuinte q" +
                "uando a mercadoria transportada está dispensada de emissão de nota fiscal ",
            "5.360 - Prestação de serviço de transporte a contribuinte substituto em relação a" +
                "o serviço de transporte ",
            "5.400 - SAÍDAS DE MERCADORIAS SUJEITAS AO REGIME DE SUBSTITUIÇÃO TRIBUTÁRIA ",
            "5.401 - Venda de produção do estabelecimento em operação com produto sujeito ao r" +
                "egime de substituiçãotributária, na condição de contribuinte substituto ",
            "5.402 - Venda de produção do estabelecimento de produto sujeito ao regime de subs" +
                "tituição tributária, em operação entre contribuintes substitutos do mesmo produt" +
                "o ",
            "5.403 - Venda de mercadoria adquirida ou recebida de terceiros em operação com me" +
                "rcadoria sujeita ao regime de substituição tributária, na condição de contribuin" +
                "te substituto ",
            "5.405 - Venda de mercadoria adquirida ou recebida de terceiros em operação com me" +
                "rcadoria sujeita ao regime de substituição tributária, na condição de contribuin" +
                "te substituído ",
            "5.408 - Transferência de produção do estabelecimento em operação com produto suje" +
                "ito ao regime de substituição tributária ",
            "5.409 - Transferência de mercadoria adquirida ou recebida de terceiros em operaçã" +
                "o com mercadoria sujeita ao regime de substituição tributária ",
            "5.410 - Devolução de compra para industrialização ou produção rural em operação c" +
                "om mercadoria sujeita ao regime de substituição tributária ",
            "5.411 - Devolução de compra para comercialização em operação com mercadoria sujei" +
                "ta ao regime de substituição tributária ",
            "5.412 - Devolução de bem do ativo imobilizado, em operação com mercadoria sujeita" +
                " ao regime de substituição tributária ",
            "5.413 - Devolução de mercadoria destinada ao uso ou consumo, em operação com merc" +
                "adoria sujeita ao regime de substituição tributária ",
            "5.414 - Remessa de produção do estabelecimento para venda fora do estabelecimento" +
                " em operação com produto sujeito ao regime de substituição tributária ",
            "5.415 - Remessa de mercadoria adquirida ou recebida de terceiros para venda fora " +
                "do estabelecimento, em operação com mercadoria sujeita ao regime de substituição" +
                " tributária ",
            "5.450 - SISTEMAS DE INTEGRAÇÃO ",
            "5.451 - Remessa de animal e de insumo para estabelecimento produtor ",
            "5.500 - REMESSAS COM FIM ESPECÍFICO DE EXPORTAÇÃO E EVENTUAIS DEVOLUÇÕES ",
            "5.501 - Remessa de produção do estabelecimento, com fim específico de exportação " +
                "5.502 - Remessa de mercadoria adquirida "});
            this.cFOPComboBox.Location = new System.Drawing.Point(35, 179);
            this.cFOPComboBox.Name = "cFOPComboBox";
            this.cFOPComboBox.Size = new System.Drawing.Size(597, 28);
            this.cFOPComboBox.TabIndex = 4;
            // 
            // frmCadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 512);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.fillBycodpropToolStrip);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.itemsBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmCadastroProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.frmCadastroProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.simplebaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingNavigator)).EndInit();
            this.itemsBindingNavigator.ResumeLayout(false);
            this.itemsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresItemsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.fillBycodpropToolStrip.ResumeLayout(false);
            this.fillBycodpropToolStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private simplebaseDataSet simplebaseDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private simplebaseDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private simplebaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator itemsBindingNavigator;
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
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.TextBox txtproduto;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cbfornecedor;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private simplebaseDataSetTableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter;
        private System.Windows.Forms.TextBox txtvalorvenda;
        private System.Windows.Forms.TextBox txtpesquisar;
        private System.Windows.Forms.Button btnpesq;
        private System.Windows.Forms.BindingSource fornecedoresItemsBindingSource;
        private System.Windows.Forms.MaskedTextBox txtvalorcusto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox CodProp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtcodprop;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStrip fillBycodpropToolStrip;
        private System.Windows.Forms.ToolStripLabel codPropToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox codPropToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBycodpropToolStripButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox iPITextBox;
        private System.Windows.Forms.TextBox iCMSTextBox;
        private System.Windows.Forms.TextBox nCMTextBox;
        private System.Windows.Forms.ComboBox cSTComboBox;
        private System.Windows.Forms.ComboBox cSOSNComboBox;
        private System.Windows.Forms.ComboBox cFOPComboBox;
    }
}