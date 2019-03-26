namespace simplestock
{
    partial class frmConsultaVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaVendas));
            this.simplebaseDataSet = new simplestock.simplebaseDataSet();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaTableAdapter = new simplestock.simplebaseDataSetTableAdapters.VendaTableAdapter();
            this.tableAdapterManager = new simplestock.simplebaseDataSetTableAdapters.TableAdapterManager();
            this.produtoVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoVendaTableAdapter = new simplestock.simplebaseDataSetTableAdapters.ProdutoVendaTableAdapter();
            this.fillByConsultaVendaPorCodigoToolStrip = new System.Windows.Forms.ToolStrip();
            this.codigoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.codigoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByConsultaVendaPorCodigoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.vendasExcluidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pnsenha = new System.Windows.Forms.Panel();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txtsenhadel = new System.Windows.Forms.TextBox();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionariosTableAdapter = new simplestock.simplebaseDataSetTableAdapters.FuncionariosTableAdapter();
            this.senhamestreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.senhamestreTableAdapter = new simplestock.simplebaseDataSetTableAdapters.SenhamestreTableAdapter();
            this.vendasExcluidasTableAdapter = new simplestock.simplebaseDataSetTableAdapters.VendasExcluidasTableAdapter();
            this.tbptotalpro = new System.Windows.Forms.TabPage();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.produtoVendaDataGridView = new System.Windows.Forms.DataGridView();
            this.IdVendaDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProdutotab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVQuant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpinfo = new System.Windows.Forms.TabPage();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.vendaDataGridView = new System.Windows.Forms.DataGridView();
            this.DGVCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTotalVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpprod = new System.Windows.Forms.TabControl();
            this.btnvendasexcluidas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.simplebaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoVendaBindingSource)).BeginInit();
            this.fillByConsultaVendaPorCodigoToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendasExcluidasBindingSource)).BeginInit();
            this.pnsenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senhamestreBindingSource)).BeginInit();
            this.tbptotalpro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoVendaDataGridView)).BeginInit();
            this.tbpinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendaDataGridView)).BeginInit();
            this.tbpprod.SuspendLayout();
            this.SuspendLayout();
            // 
            // simplebaseDataSet
            // 
            this.simplebaseDataSet.DataSetName = "simplebaseDataSet";
            this.simplebaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "Venda";
            this.vendaBindingSource.DataSource = this.simplebaseDataSet;
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
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.EntradaProdTableAdapter = null;
            this.tableAdapterManager.EntradaTableAdapter = null;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.FuncionariosTableAdapter = null;
            this.tableAdapterManager.ImagensTableAdapter = null;
            this.tableAdapterManager.ItemsTableAdapter = null;
            this.tableAdapterManager.ProdutoVendaTableAdapter = null;
            this.tableAdapterManager.SenhamestreTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = simplestock.simplebaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendasExcluidasTableAdapter = null;
            this.tableAdapterManager.VendaTableAdapter = this.vendaTableAdapter;
            // 
            // produtoVendaBindingSource
            // 
            this.produtoVendaBindingSource.DataMember = "ProdutoVenda";
            this.produtoVendaBindingSource.DataSource = this.simplebaseDataSet;
            // 
            // produtoVendaTableAdapter
            // 
            this.produtoVendaTableAdapter.ClearBeforeFill = true;
            // 
            // fillByConsultaVendaPorCodigoToolStrip
            // 
            this.fillByConsultaVendaPorCodigoToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByConsultaVendaPorCodigoToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codigoToolStripLabel,
            this.codigoToolStripTextBox,
            this.fillByConsultaVendaPorCodigoToolStripButton});
            this.fillByConsultaVendaPorCodigoToolStrip.Location = new System.Drawing.Point(0, 31);
            this.fillByConsultaVendaPorCodigoToolStrip.Name = "fillByConsultaVendaPorCodigoToolStrip";
            this.fillByConsultaVendaPorCodigoToolStrip.Size = new System.Drawing.Size(258, 25);
            this.fillByConsultaVendaPorCodigoToolStrip.TabIndex = 7;
            this.fillByConsultaVendaPorCodigoToolStrip.Text = "fillByConsultaVendaPorCodigoToolStrip";
            // 
            // codigoToolStripLabel
            // 
            this.codigoToolStripLabel.Name = "codigoToolStripLabel";
            this.codigoToolStripLabel.Size = new System.Drawing.Size(82, 22);
            this.codigoToolStripLabel.Text = "Código Venda";
            // 
            // codigoToolStripTextBox
            // 
            this.codigoToolStripTextBox.Name = "codigoToolStripTextBox";
            this.codigoToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.codigoToolStripTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigoToolStripTextBox_KeyPress);
            this.codigoToolStripTextBox.Click += new System.EventHandler(this.codigoToolStripTextBox_Click_1);
            this.codigoToolStripTextBox.TextChanged += new System.EventHandler(this.codigoToolStripTextBox_TextChanged);
            // 
            // fillByConsultaVendaPorCodigoToolStripButton
            // 
            this.fillByConsultaVendaPorCodigoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByConsultaVendaPorCodigoToolStripButton.Name = "fillByConsultaVendaPorCodigoToolStripButton";
            this.fillByConsultaVendaPorCodigoToolStripButton.Size = new System.Drawing.Size(62, 22);
            this.fillByConsultaVendaPorCodigoToolStripButton.Text = "Consultar";
            this.fillByConsultaVendaPorCodigoToolStripButton.Click += new System.EventHandler(this.fillByConsultaVendaPorCodigoToolStripButton_Click);
            // 
            // vendasExcluidasBindingSource
            // 
            this.vendasExcluidasBindingSource.DataMember = "VendasExcluidas";
            this.vendasExcluidasBindingSource.DataSource = this.simplebaseDataSet;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(447, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Deletar Venda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnsenha
            // 
            this.pnsenha.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnsenha.Controls.Add(this.lblsenha);
            this.pnsenha.Controls.Add(this.txtsenhadel);
            this.pnsenha.Location = new System.Drawing.Point(193, 16);
            this.pnsenha.Name = "pnsenha";
            this.pnsenha.Size = new System.Drawing.Size(126, 48);
            this.pnsenha.TabIndex = 10;
            this.pnsenha.Visible = false;
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(12, 1);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(94, 13);
            this.lblsenha.TabIndex = 1;
            this.lblsenha.Text = "Senha do Gerente";
            // 
            // txtsenhadel
            // 
            this.txtsenhadel.Location = new System.Drawing.Point(15, 15);
            this.txtsenhadel.Name = "txtsenhadel";
            this.txtsenhadel.PasswordChar = '•';
            this.txtsenhadel.Size = new System.Drawing.Size(100, 20);
            this.txtsenhadel.TabIndex = 0;
            this.txtsenhadel.TextChanged += new System.EventHandler(this.txtsenhadel_TextChanged);
            this.txtsenhadel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsenhadel_KeyPress);
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "Funcionarios";
            this.funcionariosBindingSource.DataSource = this.simplebaseDataSet;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // senhamestreBindingSource
            // 
            this.senhamestreBindingSource.DataMember = "Senhamestre";
            this.senhamestreBindingSource.DataSource = this.simplebaseDataSet;
            // 
            // senhamestreTableAdapter
            // 
            this.senhamestreTableAdapter.ClearBeforeFill = true;
            // 
            // vendasExcluidasTableAdapter
            // 
            this.vendasExcluidasTableAdapter.ClearBeforeFill = true;
            // 
            // tbptotalpro
            // 
            this.tbptotalpro.AutoScroll = true;
            this.tbptotalpro.Controls.Add(this.bindingNavigator1);
            this.tbptotalpro.Controls.Add(this.produtoVendaDataGridView);
            this.tbptotalpro.Location = new System.Drawing.Point(4, 22);
            this.tbptotalpro.Name = "tbptotalpro";
            this.tbptotalpro.Padding = new System.Windows.Forms.Padding(3);
            this.tbptotalpro.Size = new System.Drawing.Size(550, 0);
            this.tbptotalpro.TabIndex = 1;
            this.tbptotalpro.Text = "Produtos";
            this.tbptotalpro.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.produtoVendaBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(545, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.Visible = false;
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click_1);
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
            // produtoVendaDataGridView
            // 
            this.produtoVendaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.produtoVendaDataGridView.AutoGenerateColumns = false;
            this.produtoVendaDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.produtoVendaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtoVendaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVendaDGV,
            this.IdProdutotab,
            this.dataGridViewTextBoxColumn15,
            this.DGVQuant,
            this.DGVTValor,
            this.IdItem});
            this.produtoVendaDataGridView.DataSource = this.produtoVendaBindingSource;
            this.produtoVendaDataGridView.Location = new System.Drawing.Point(3, 3);
            this.produtoVendaDataGridView.Name = "produtoVendaDataGridView";
            this.produtoVendaDataGridView.ReadOnly = true;
            this.produtoVendaDataGridView.Size = new System.Drawing.Size(544, 265);
            this.produtoVendaDataGridView.TabIndex = 0;
            // 
            // IdVendaDGV
            // 
            this.IdVendaDGV.DataPropertyName = "IdVenda";
            this.IdVendaDGV.HeaderText = "IdVenda";
            this.IdVendaDGV.Name = "IdVendaDGV";
            this.IdVendaDGV.ReadOnly = true;
            this.IdVendaDGV.Width = 50;
            // 
            // IdProdutotab
            // 
            this.IdProdutotab.DataPropertyName = "IdProduto";
            this.IdProdutotab.HeaderText = "IdProduto";
            this.IdProdutotab.Name = "IdProdutotab";
            this.IdProdutotab.ReadOnly = true;
            this.IdProdutotab.Width = 50;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn15.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 200;
            // 
            // DGVQuant
            // 
            this.DGVQuant.DataPropertyName = "Quantidade";
            this.DGVQuant.HeaderText = "Quantidade";
            this.DGVQuant.Name = "DGVQuant";
            this.DGVQuant.ReadOnly = true;
            // 
            // DGVTValor
            // 
            this.DGVTValor.DataPropertyName = "Valor";
            this.DGVTValor.HeaderText = "Valor";
            this.DGVTValor.Name = "DGVTValor";
            this.DGVTValor.ReadOnly = true;
            // 
            // IdItem
            // 
            this.IdItem.DataPropertyName = "IdItem";
            this.IdItem.HeaderText = "IdItem";
            this.IdItem.Name = "IdItem";
            this.IdItem.ReadOnly = true;
            this.IdItem.Visible = false;
            this.IdItem.Width = 50;
            // 
            // tbpinfo
            // 
            this.tbpinfo.AutoScroll = true;
            this.tbpinfo.Controls.Add(this.bindingNavigator2);
            this.tbpinfo.Controls.Add(this.vendaDataGridView);
            this.tbpinfo.Location = new System.Drawing.Point(4, 22);
            this.tbpinfo.Name = "tbpinfo";
            this.tbpinfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpinfo.Size = new System.Drawing.Size(550, 1);
            this.tbpinfo.TabIndex = 0;
            this.tbpinfo.Text = "Informações";
            this.tbpinfo.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator2.BindingSource = this.vendaBindingSource;
            this.bindingNavigator2.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator2.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigator2.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator2.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator2.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator2.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator2.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator2.Size = new System.Drawing.Size(545, 25);
            this.bindingNavigator2.TabIndex = 1;
            this.bindingNavigator2.Text = "bindingNavigator2";
            this.bindingNavigator2.Visible = false;
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            this.bindingNavigatorDeleteItem1.Click += new System.EventHandler(this.bindingNavigatorDeleteItem1_Click);
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // vendaDataGridView
            // 
            this.vendaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.vendaDataGridView.AutoGenerateColumns = false;
            this.vendaDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.vendaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVCodigo,
            this.DGVCliente,
            this.DGVData,
            this.DGVVendedor,
            this.DGVTotalVenda});
            this.vendaDataGridView.DataSource = this.vendaBindingSource;
            this.vendaDataGridView.Location = new System.Drawing.Point(3, 3);
            this.vendaDataGridView.MultiSelect = false;
            this.vendaDataGridView.Name = "vendaDataGridView";
            this.vendaDataGridView.ReadOnly = true;
            this.vendaDataGridView.Size = new System.Drawing.Size(544, 1);
            this.vendaDataGridView.TabIndex = 0;
            // 
            // DGVCodigo
            // 
            this.DGVCodigo.DataPropertyName = "Codigo";
            this.DGVCodigo.HeaderText = "Codigo";
            this.DGVCodigo.Name = "DGVCodigo";
            this.DGVCodigo.ReadOnly = true;
            // 
            // DGVCliente
            // 
            this.DGVCliente.DataPropertyName = "Cliente";
            this.DGVCliente.HeaderText = "Cliente";
            this.DGVCliente.Name = "DGVCliente";
            this.DGVCliente.ReadOnly = true;
            // 
            // DGVData
            // 
            this.DGVData.DataPropertyName = "Data";
            this.DGVData.HeaderText = "Data";
            this.DGVData.Name = "DGVData";
            this.DGVData.ReadOnly = true;
            // 
            // DGVVendedor
            // 
            this.DGVVendedor.DataPropertyName = "Vendedor";
            this.DGVVendedor.HeaderText = "Vendedor";
            this.DGVVendedor.Name = "DGVVendedor";
            this.DGVVendedor.ReadOnly = true;
            // 
            // DGVTotalVenda
            // 
            this.DGVTotalVenda.DataPropertyName = "TotalVenda";
            this.DGVTotalVenda.HeaderText = "TotalVenda";
            this.DGVTotalVenda.Name = "DGVTotalVenda";
            this.DGVTotalVenda.ReadOnly = true;
            // 
            // tbpprod
            // 
            this.tbpprod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbpprod.Controls.Add(this.tbpinfo);
            this.tbpprod.Controls.Add(this.tbptotalpro);
            this.tbpprod.Location = new System.Drawing.Point(0, 70);
            this.tbpprod.Name = "tbpprod";
            this.tbpprod.SelectedIndex = 0;
            this.tbpprod.Size = new System.Drawing.Size(558, 27);
            this.tbpprod.TabIndex = 8;
            this.tbpprod.Tag = "";
            // 
            // btnvendasexcluidas
            // 
            this.btnvendasexcluidas.Location = new System.Drawing.Point(447, 45);
            this.btnvendasexcluidas.Name = "btnvendasexcluidas";
            this.btnvendasexcluidas.Size = new System.Drawing.Size(104, 41);
            this.btnvendasexcluidas.TabIndex = 11;
            this.btnvendasexcluidas.Text = "Consultar Vendas Excluidas";
            this.btnvendasexcluidas.UseVisualStyleBackColor = true;
            this.btnvendasexcluidas.Click += new System.EventHandler(this.btnvendasexcluidas_Click);
            // 
            // frmConsultaVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(558, 97);
            this.Controls.Add(this.btnvendasexcluidas);
            this.Controls.Add(this.pnsenha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbpprod);
            this.Controls.Add(this.fillByConsultaVendaPorCodigoToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Vendas";
            this.Load += new System.EventHandler(this.frmConsultaVendas_Load);
            this.TextChanged += new System.EventHandler(this.frmConsultaVendas_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.simplebaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoVendaBindingSource)).EndInit();
            this.fillByConsultaVendaPorCodigoToolStrip.ResumeLayout(false);
            this.fillByConsultaVendaPorCodigoToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendasExcluidasBindingSource)).EndInit();
            this.pnsenha.ResumeLayout(false);
            this.pnsenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senhamestreBindingSource)).EndInit();
            this.tbptotalpro.ResumeLayout(false);
            this.tbptotalpro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoVendaDataGridView)).EndInit();
            this.tbpinfo.ResumeLayout(false);
            this.tbpinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendaDataGridView)).EndInit();
            this.tbpprod.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private simplebaseDataSet simplebaseDataSet;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private simplebaseDataSetTableAdapters.VendaTableAdapter vendaTableAdapter;
        private simplebaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource produtoVendaBindingSource;
        private simplebaseDataSetTableAdapters.ProdutoVendaTableAdapter produtoVendaTableAdapter;
        private System.Windows.Forms.ToolStrip fillByConsultaVendaPorCodigoToolStrip;
        private System.Windows.Forms.ToolStripLabel codigoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox codigoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByConsultaVendaPorCodigoToolStripButton;
        private System.Windows.Forms.Panel pnsenha;
        private System.Windows.Forms.TextBox txtsenhadel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private simplebaseDataSetTableAdapters.FuncionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.BindingSource senhamestreBindingSource;
        private simplebaseDataSetTableAdapters.SenhamestreTableAdapter senhamestreTableAdapter;
        private System.Windows.Forms.BindingSource vendasExcluidasBindingSource;
        private simplebaseDataSetTableAdapters.VendasExcluidasTableAdapter vendasExcluidasTableAdapter;
        private System.Windows.Forms.TabPage tbptotalpro;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private System.Windows.Forms.DataGridView produtoVendaDataGridView;
        private System.Windows.Forms.TabPage tbpinfo;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.DataGridView vendaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVData;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTotalVenda;
        private System.Windows.Forms.TabControl tbpprod;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVendaDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProdutotab;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVQuant;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdItem;
        private System.Windows.Forms.Button btnvendasexcluidas;
    }
}