namespace simplestock
{
    partial class frmCadastroClientes
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label ruaLabel;
            System.Windows.Forms.Label numLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label cEPLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label uFLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label rGLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroClientes));
            this.simplebaseDataSet = new simplestock.simplebaseDataSet();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new simplestock.simplebaseDataSetTableAdapters.ClientesTableAdapter();
            this.tableAdapterManager = new simplestock.simplebaseDataSetTableAdapters.TableAdapterManager();
            this.clientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnexcluir = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtrua = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txtuf = new System.Windows.Forms.TextBox();
            this.txtrg = new System.Windows.Forms.TextBox();
            this.btnnovo = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.txttel = new System.Windows.Forms.MaskedTextBox();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtpesquisar2 = new System.Windows.Forms.Button();
            this.txtpesquisar = new System.Windows.Forms.TextBox();
            codigoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            ruaLabel = new System.Windows.Forms.Label();
            numLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            cEPLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            uFLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.simplebaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingNavigator)).BeginInit();
            this.clientesBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(18, 52);
            codigoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(63, 20);
            codigoLabel.TabIndex = 1;
            codigoLabel.Text = "Codigo:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(4, 25);
            nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(55, 20);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // ruaLabel
            // 
            ruaLabel.AutoSize = true;
            ruaLabel.Location = new System.Drawing.Point(3, 32);
            ruaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ruaLabel.Name = "ruaLabel";
            ruaLabel.Size = new System.Drawing.Size(43, 20);
            ruaLabel.TabIndex = 5;
            ruaLabel.Text = "Rua:";
            // 
            // numLabel
            // 
            numLabel.AutoSize = true;
            numLabel.Location = new System.Drawing.Point(458, 25);
            numLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            numLabel.Name = "numLabel";
            numLabel.Size = new System.Drawing.Size(46, 20);
            numLabel.TabIndex = 7;
            numLabel.Text = "Num:";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(4, 91);
            bairroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(55, 20);
            bairroLabel.TabIndex = 9;
            bairroLabel.Text = "Bairro:";
            // 
            // cEPLabel
            // 
            cEPLabel.AutoSize = true;
            cEPLabel.Location = new System.Drawing.Point(4, 211);
            cEPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cEPLabel.Name = "cEPLabel";
            cEPLabel.Size = new System.Drawing.Size(45, 20);
            cEPLabel.TabIndex = 11;
            cEPLabel.Text = "CEP:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(4, 151);
            cidadeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(63, 20);
            cidadeLabel.TabIndex = 13;
            cidadeLabel.Text = "Cidade:";
            // 
            // uFLabel
            // 
            uFLabel.AutoSize = true;
            uFLabel.Location = new System.Drawing.Point(458, 151);
            uFLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            uFLabel.Name = "uFLabel";
            uFLabel.Size = new System.Drawing.Size(35, 20);
            uFLabel.TabIndex = 15;
            uFLabel.Text = "UF:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(129, 211);
            telefoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(75, 20);
            telefoneLabel.TabIndex = 17;
            telefoneLabel.Text = "Telefone:";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(4, 89);
            cPFLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(44, 20);
            cPFLabel.TabIndex = 19;
            cPFLabel.Text = "CPF:";
            cPFLabel.Click += new System.EventHandler(this.cPFLabel_Click);
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.Location = new System.Drawing.Point(261, 89);
            rGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(38, 20);
            rGLabel.TabIndex = 21;
            rGLabel.Text = "RG:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(270, 211);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 32;
            emailLabel.Text = "Email:";
            // 
            // simplebaseDataSet
            // 
            this.simplebaseDataSet.DataSetName = "simplebaseDataSet";
            this.simplebaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.simplebaseDataSet;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.FuncionariosTableAdapter = null;
            this.tableAdapterManager.ImagensTableAdapter = null;
            this.tableAdapterManager.ItemsTableAdapter = null;
            this.tableAdapterManager.ProdutoVendaTableAdapter = null;
            this.tableAdapterManager.SenhamestreTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = simplestock.simplebaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendasExcluidasTableAdapter = null;
            this.tableAdapterManager.VendaTableAdapter = null;
            // 
            // clientesBindingNavigator
            // 
            this.clientesBindingNavigator.AddNewItem = null;
            this.clientesBindingNavigator.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clientesBindingNavigator.BindingSource = this.clientesBindingSource;
            this.clientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientesBindingNavigator.CountItemFormat = "DE {0}";
            this.clientesBindingNavigator.DeleteItem = this.tsbtnexcluir;
            this.clientesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.tsbtnexcluir});
            this.clientesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientesBindingNavigator.Name = "clientesBindingNavigator";
            this.clientesBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.clientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientesBindingNavigator.Size = new System.Drawing.Size(586, 25);
            this.clientesBindingNavigator.TabIndex = 0;
            this.clientesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 22);
            this.bindingNavigatorCountItem.Text = "DE {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // tsbtnexcluir
            // 
            this.tsbtnexcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnexcluir.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnexcluir.Image")));
            this.tsbtnexcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnexcluir.Name = "tsbtnexcluir";
            this.tsbtnexcluir.Size = new System.Drawing.Size(23, 22);
            this.tsbtnexcluir.Text = "Excluir";
            this.tsbtnexcluir.Click += new System.EventHandler(this.tsbtnexcluir_Click);
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
            this.txtcod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Codigo", true));
            this.txtcod.Location = new System.Drawing.Point(105, 48);
            this.txtcod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcod.Name = "txtcod";
            this.txtcod.ReadOnly = true;
            this.txtcod.Size = new System.Drawing.Size(91, 26);
            this.txtcod.TabIndex = 1;
            // 
            // txtnome
            // 
            this.txtnome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Nome", true));
            this.txtnome.Location = new System.Drawing.Point(9, 49);
            this.txtnome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(534, 26);
            this.txtnome.TabIndex = 1;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // txtrua
            // 
            this.txtrua.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Rua", true));
            this.txtrua.Location = new System.Drawing.Point(9, 55);
            this.txtrua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtrua.Name = "txtrua";
            this.txtrua.Size = new System.Drawing.Size(404, 26);
            this.txtrua.TabIndex = 1;
            // 
            // txtnum
            // 
            this.txtnum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Num", true));
            this.txtnum.Location = new System.Drawing.Point(462, 55);
            this.txtnum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(85, 26);
            this.txtnum.TabIndex = 2;
            // 
            // txtbairro
            // 
            this.txtbairro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Bairro", true));
            this.txtbairro.Location = new System.Drawing.Point(8, 115);
            this.txtbairro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(404, 26);
            this.txtbairro.TabIndex = 3;
            // 
            // txtcidade
            // 
            this.txtcidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Cidade", true));
            this.txtcidade.Location = new System.Drawing.Point(9, 175);
            this.txtcidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(404, 26);
            this.txtcidade.TabIndex = 4;
            // 
            // txtuf
            // 
            this.txtuf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "UF", true));
            this.txtuf.Location = new System.Drawing.Point(462, 175);
            this.txtuf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtuf.Name = "txtuf";
            this.txtuf.Size = new System.Drawing.Size(85, 26);
            this.txtuf.TabIndex = 5;
            // 
            // txtrg
            // 
            this.txtrg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "RG", true));
            this.txtrg.Location = new System.Drawing.Point(266, 114);
            this.txtrg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(277, 26);
            this.txtrg.TabIndex = 3;
            // 
            // btnnovo
            // 
            this.btnnovo.Location = new System.Drawing.Point(9, 568);
            this.btnnovo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(122, 62);
            this.btnnovo.TabIndex = 4;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(153, 568);
            this.btnsalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(122, 62);
            this.btnsalvar.TabIndex = 5;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(303, 568);
            this.btnalterar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(122, 62);
            this.btnalterar.TabIndex = 6;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(450, 568);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(122, 62);
            this.btncancelar.TabIndex = 7;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtcpf
            // 
            this.txtcpf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "CPF", true));
            this.txtcpf.Location = new System.Drawing.Point(9, 114);
            this.txtcpf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcpf.Mask = "000.000.000-00";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(211, 26);
            this.txtcpf.TabIndex = 2;
            // 
            // txttel
            // 
            this.txttel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Telefone", true));
            this.txttel.Location = new System.Drawing.Point(134, 235);
            this.txttel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttel.Mask = "(99) 0000-0000";
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(130, 26);
            this.txttel.TabIndex = 7;
            // 
            // txtcep
            // 
            this.txtcep.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "CEP", true));
            this.txtcep.Location = new System.Drawing.Point(9, 235);
            this.txtcep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcep.Mask = "00000-999";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(114, 26);
            this.txtcep.TabIndex = 6;
            // 
            // txtemail
            // 
            this.txtemail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Email", true));
            this.txtemail.Location = new System.Drawing.Point(274, 235);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(272, 26);
            this.txtemail.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttel);
            this.groupBox1.Controls.Add(telefoneLabel);
            this.groupBox1.Controls.Add(this.txtcep);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(cEPLabel);
            this.groupBox1.Controls.Add(this.txtcidade);
            this.groupBox1.Controls.Add(uFLabel);
            this.groupBox1.Controls.Add(this.txtnum);
            this.groupBox1.Controls.Add(numLabel);
            this.groupBox1.Controls.Add(ruaLabel);
            this.groupBox1.Controls.Add(this.txtuf);
            this.groupBox1.Controls.Add(this.txtrua);
            this.groupBox1.Controls.Add(cidadeLabel);
            this.groupBox1.Controls.Add(this.txtbairro);
            this.groupBox1.Controls.Add(bairroLabel);
            this.groupBox1.Location = new System.Drawing.Point(9, 263);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(562, 295);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contato";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(rGLabel);
            this.groupBox2.Controls.Add(this.txtcpf);
            this.groupBox2.Controls.Add(this.txtrg);
            this.groupBox2.Controls.Add(cPFLabel);
            this.groupBox2.Controls.Add(nomeLabel);
            this.groupBox2.Controls.Add(this.txtnome);
            this.groupBox2.Location = new System.Drawing.Point(14, 88);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(558, 154);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastro";
            // 
            // txtpesquisar2
            // 
            this.txtpesquisar2.Location = new System.Drawing.Point(447, 48);
            this.txtpesquisar2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpesquisar2.Name = "txtpesquisar2";
            this.txtpesquisar2.Size = new System.Drawing.Size(124, 32);
            this.txtpesquisar2.TabIndex = 3;
            this.txtpesquisar2.Text = "Pesquisar";
            this.txtpesquisar2.UseVisualStyleBackColor = true;
            this.txtpesquisar2.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.Location = new System.Drawing.Point(231, 48);
            this.txtpesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.Size = new System.Drawing.Size(205, 26);
            this.txtpesquisar.TabIndex = 2;
            this.txtpesquisar.Text = "Nome do Cliente";
            // 
            // frmCadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 640);
            this.Controls.Add(this.txtpesquisar2);
            this.Controls.Add(this.txtpesquisar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.clientesBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmCadastroClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.frmCadastroClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.simplebaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingNavigator)).EndInit();
            this.clientesBindingNavigator.ResumeLayout(false);
            this.clientesBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private simplebaseDataSet simplebaseDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private simplebaseDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private simplebaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clientesBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtrua;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.TextBox txtuf;
        private System.Windows.Forms.TextBox txtrg;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.MaskedTextBox txttel;
        private System.Windows.Forms.MaskedTextBox txtcep;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripButton tsbtnexcluir;
        private System.Windows.Forms.Button txtpesquisar2;
        private System.Windows.Forms.TextBox txtpesquisar;
    }
}