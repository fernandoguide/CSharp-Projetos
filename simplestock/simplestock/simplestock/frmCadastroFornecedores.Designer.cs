namespace simplestock
{
    partial class frmCadastroFornecedores
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
            System.Windows.Forms.Label razaoSocialLabel;
            System.Windows.Forms.Label nomeFantasiaLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label uFLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label cNPJLabel1;
            System.Windows.Forms.Label rGLabel;
            System.Windows.Forms.Label numLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label siteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroFornecedores));
            this.simplebaseDataSet = new simplestock.simplebaseDataSet();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedoresTableAdapter = new simplestock.simplebaseDataSetTableAdapters.FornecedoresTableAdapter();
            this.tableAdapterManager = new simplestock.simplebaseDataSetTableAdapters.TableAdapterManager();
            this.txtrazaosocial = new System.Windows.Forms.TextBox();
            this.txtnomefantasia = new System.Windows.Forms.TextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txtuf = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtcnpj = new System.Windows.Forms.MaskedTextBox();
            this.txttelefone = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsite = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.Cadastro = new System.Windows.Forms.GroupBox();
            this.txtrg = new System.Windows.Forms.TextBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fornecedoresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.tsbtndelete = new System.Windows.Forms.ToolStripButton();
            this.txtpesquisar2 = new System.Windows.Forms.Button();
            this.txtpesquisar = new System.Windows.Forms.TextBox();
            razaoSocialLabel = new System.Windows.Forms.Label();
            nomeFantasiaLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            uFLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            cNPJLabel1 = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            numLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            siteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.simplebaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingNavigator)).BeginInit();
            this.fornecedoresBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // razaoSocialLabel
            // 
            razaoSocialLabel.AutoSize = true;
            razaoSocialLabel.Location = new System.Drawing.Point(9, 31);
            razaoSocialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            razaoSocialLabel.Name = "razaoSocialLabel";
            razaoSocialLabel.Size = new System.Drawing.Size(107, 20);
            razaoSocialLabel.TabIndex = 3;
            razaoSocialLabel.Text = "Razao Social:";
            razaoSocialLabel.Click += new System.EventHandler(this.razaoSocialLabel_Click);
            // 
            // nomeFantasiaLabel
            // 
            nomeFantasiaLabel.AutoSize = true;
            nomeFantasiaLabel.Location = new System.Drawing.Point(9, 91);
            nomeFantasiaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeFantasiaLabel.Name = "nomeFantasiaLabel";
            nomeFantasiaLabel.Size = new System.Drawing.Size(121, 20);
            nomeFantasiaLabel.TabIndex = 5;
            nomeFantasiaLabel.Text = "Nome Fantasia:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(9, 32);
            enderecoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(82, 20);
            enderecoLabel.TabIndex = 7;
            enderecoLabel.Text = "Endereco:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(9, 152);
            cidadeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(63, 20);
            cidadeLabel.TabIndex = 9;
            cidadeLabel.Text = "Cidade:";
            cidadeLabel.Click += new System.EventHandler(this.cidadeLabel_Click);
            // 
            // uFLabel
            // 
            uFLabel.AutoSize = true;
            uFLabel.Location = new System.Drawing.Point(672, 152);
            uFLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            uFLabel.Name = "uFLabel";
            uFLabel.Size = new System.Drawing.Size(35, 20);
            uFLabel.TabIndex = 11;
            uFLabel.Text = "UF:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(14, 272);
            telefoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(75, 20);
            telefoneLabel.TabIndex = 13;
            telefoneLabel.Text = "Telefone:";
            telefoneLabel.Click += new System.EventHandler(this.telefoneLabel_Click);
            // 
            // cNPJLabel1
            // 
            cNPJLabel1.AutoSize = true;
            cNPJLabel1.Location = new System.Drawing.Point(9, 151);
            cNPJLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cNPJLabel1.Name = "cNPJLabel1";
            cNPJLabel1.Size = new System.Drawing.Size(53, 20);
            cNPJLabel1.TabIndex = 20;
            cNPJLabel1.Text = "CNPJ:";
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.Location = new System.Drawing.Point(232, 151);
            rGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(108, 20);
            rGLabel.TabIndex = 0;
            rGLabel.Text = "Ins. Est. / RG:";
            // 
            // numLabel
            // 
            numLabel.AutoSize = true;
            numLabel.Location = new System.Drawing.Point(668, 32);
            numLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            numLabel.Name = "numLabel";
            numLabel.Size = new System.Drawing.Size(46, 20);
            numLabel.TabIndex = 0;
            numLabel.Text = "Num:";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(9, 92);
            bairroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(55, 20);
            bairroLabel.TabIndex = 2;
            bairroLabel.Text = "Bairro:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(195, 272);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 22;
            emailLabel.Text = "Email:";
            // 
            // siteLabel
            // 
            siteLabel.AutoSize = true;
            siteLabel.Location = new System.Drawing.Point(14, 212);
            siteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            siteLabel.Name = "siteLabel";
            siteLabel.Size = new System.Drawing.Size(41, 20);
            siteLabel.TabIndex = 23;
            siteLabel.Text = "Site:";
            // 
            // simplebaseDataSet
            // 
            this.simplebaseDataSet.DataSetName = "simplebaseDataSet";
            this.simplebaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.ItemsTableAdapter = null;
            this.tableAdapterManager.ProdutoVendaTableAdapter = null;
            this.tableAdapterManager.SenhamestreTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = simplestock.simplebaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendasExcluidasTableAdapter = null;
            this.tableAdapterManager.VendaTableAdapter = null;
            // 
            // txtrazaosocial
            // 
            this.txtrazaosocial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "RazaoSocial", true));
            this.txtrazaosocial.Location = new System.Drawing.Point(14, 55);
            this.txtrazaosocial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtrazaosocial.Name = "txtrazaosocial";
            this.txtrazaosocial.Size = new System.Drawing.Size(732, 26);
            this.txtrazaosocial.TabIndex = 1;
            // 
            // txtnomefantasia
            // 
            this.txtnomefantasia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "NomeFantasia", true));
            this.txtnomefantasia.Location = new System.Drawing.Point(14, 115);
            this.txtnomefantasia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnomefantasia.Name = "txtnomefantasia";
            this.txtnomefantasia.Size = new System.Drawing.Size(732, 26);
            this.txtnomefantasia.TabIndex = 2;
            // 
            // txtendereco
            // 
            this.txtendereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Endereco", true));
            this.txtendereco.Location = new System.Drawing.Point(14, 57);
            this.txtendereco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(628, 26);
            this.txtendereco.TabIndex = 1;
            // 
            // txtcidade
            // 
            this.txtcidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Cidade", true));
            this.txtcidade.Location = new System.Drawing.Point(14, 177);
            this.txtcidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(632, 26);
            this.txtcidade.TabIndex = 4;
            // 
            // txtuf
            // 
            this.txtuf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "UF", true));
            this.txtuf.Location = new System.Drawing.Point(676, 177);
            this.txtuf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtuf.Name = "txtuf";
            this.txtuf.Size = new System.Drawing.Size(68, 26);
            this.txtuf.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 635);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 635);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 54);
            this.button2.TabIndex = 4;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(430, 635);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 54);
            this.button3.TabIndex = 5;
            this.button3.Text = "Alterar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(644, 635);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 54);
            this.button5.TabIndex = 6;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtcnpj
            // 
            this.txtcnpj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "CNPJ", true));
            this.txtcnpj.Location = new System.Drawing.Point(14, 175);
            this.txtcnpj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcnpj.Mask = "00.000.000/0000-00";
            this.txtcnpj.Name = "txtcnpj";
            this.txtcnpj.Size = new System.Drawing.Size(198, 26);
            this.txtcnpj.TabIndex = 3;
            // 
            // txttelefone
            // 
            this.txttelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Telefone", true));
            this.txttelefone.Location = new System.Drawing.Point(18, 297);
            this.txttelefone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttelefone.Mask = "(99) 0000-0000";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(148, 26);
            this.txttelefone.TabIndex = 7;
            this.txttelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txttelefone_MaskInputRejected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(siteLabel);
            this.groupBox1.Controls.Add(this.txtsite);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txttelefone);
            this.groupBox1.Controls.Add(bairroLabel);
            this.groupBox1.Controls.Add(this.txtbairro);
            this.groupBox1.Controls.Add(numLabel);
            this.groupBox1.Controls.Add(this.txtnum);
            this.groupBox1.Controls.Add(telefoneLabel);
            this.groupBox1.Controls.Add(cidadeLabel);
            this.groupBox1.Controls.Add(this.txtcidade);
            this.groupBox1.Controls.Add(enderecoLabel);
            this.groupBox1.Controls.Add(this.txtuf);
            this.groupBox1.Controls.Add(this.txtendereco);
            this.groupBox1.Controls.Add(uFLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 278);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(774, 348);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contato";
            // 
            // txtsite
            // 
            this.txtsite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Site", true));
            this.txtsite.Location = new System.Drawing.Point(18, 237);
            this.txtsite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsite.Name = "txtsite";
            this.txtsite.Size = new System.Drawing.Size(430, 26);
            this.txtsite.TabIndex = 6;
            // 
            // txtemail
            // 
            this.txtemail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Email", true));
            this.txtemail.Location = new System.Drawing.Point(200, 297);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(546, 26);
            this.txtemail.TabIndex = 8;
            // 
            // txtbairro
            // 
            this.txtbairro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Bairro", true));
            this.txtbairro.Location = new System.Drawing.Point(14, 117);
            this.txtbairro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(632, 26);
            this.txtbairro.TabIndex = 3;
            // 
            // txtnum
            // 
            this.txtnum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Num", true));
            this.txtnum.Location = new System.Drawing.Point(672, 57);
            this.txtnum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(73, 26);
            this.txtnum.TabIndex = 2;
            // 
            // Cadastro
            // 
            this.Cadastro.Controls.Add(rGLabel);
            this.Cadastro.Controls.Add(this.txtrg);
            this.Cadastro.Controls.Add(cNPJLabel1);
            this.Cadastro.Controls.Add(this.txtnomefantasia);
            this.Cadastro.Controls.Add(this.txtcnpj);
            this.Cadastro.Controls.Add(nomeFantasiaLabel);
            this.Cadastro.Controls.Add(this.txtrazaosocial);
            this.Cadastro.Controls.Add(razaoSocialLabel);
            this.Cadastro.Location = new System.Drawing.Point(12, 49);
            this.Cadastro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cadastro.Size = new System.Drawing.Size(774, 220);
            this.Cadastro.TabIndex = 24;
            this.Cadastro.TabStop = false;
            this.Cadastro.Text = "Cadastro";
            // 
            // txtrg
            // 
            this.txtrg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "RG", true));
            this.txtrg.Location = new System.Drawing.Point(237, 175);
            this.txtrg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(242, 26);
            this.txtrg.TabIndex = 4;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 22);
            this.bindingNavigatorCountItem.Text = "DE {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // fornecedoresBindingNavigator
            // 
            this.fornecedoresBindingNavigator.AddNewItem = null;
            this.fornecedoresBindingNavigator.BindingSource = this.fornecedoresBindingSource;
            this.fornecedoresBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fornecedoresBindingNavigator.CountItemFormat = "DE {0}";
            this.fornecedoresBindingNavigator.DeleteItem = this.tsbtndelete;
            this.fornecedoresBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.tsbtndelete});
            this.fornecedoresBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fornecedoresBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fornecedoresBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fornecedoresBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fornecedoresBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fornecedoresBindingNavigator.Name = "fornecedoresBindingNavigator";
            this.fornecedoresBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.fornecedoresBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fornecedoresBindingNavigator.Size = new System.Drawing.Size(801, 25);
            this.fornecedoresBindingNavigator.TabIndex = 0;
            this.fornecedoresBindingNavigator.Text = "bindingNavigator1";
            // 
            // tsbtndelete
            // 
            this.tsbtndelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtndelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtndelete.Image")));
            this.tsbtndelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtndelete.Name = "tsbtndelete";
            this.tsbtndelete.Size = new System.Drawing.Size(23, 22);
            this.tsbtndelete.Text = "Excluir";
            this.tsbtndelete.Click += new System.EventHandler(this.tsbtndelete_Click);
            // 
            // txtpesquisar2
            // 
            this.txtpesquisar2.Location = new System.Drawing.Point(634, 6);
            this.txtpesquisar2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpesquisar2.Name = "txtpesquisar2";
            this.txtpesquisar2.Size = new System.Drawing.Size(124, 32);
            this.txtpesquisar2.TabIndex = 2;
            this.txtpesquisar2.Text = "Pesquisar";
            this.txtpesquisar2.UseVisualStyleBackColor = true;
            this.txtpesquisar2.Click += new System.EventHandler(this.txtpesquisar2_Click);
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.Location = new System.Drawing.Point(366, 6);
            this.txtpesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.Size = new System.Drawing.Size(258, 26);
            this.txtpesquisar.TabIndex = 1;
            this.txtpesquisar.Text = "Nome do Fornecedor";
            // 
            // frmCadastroFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 694);
            this.Controls.Add(this.txtpesquisar2);
            this.Controls.Add(this.txtpesquisar);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fornecedoresBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cadastro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmCadastroFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedores";
            this.Load += new System.EventHandler(this.frmCadastroFornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.simplebaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Cadastro.ResumeLayout(false);
            this.Cadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingNavigator)).EndInit();
            this.fornecedoresBindingNavigator.ResumeLayout(false);
            this.fornecedoresBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private simplebaseDataSet simplebaseDataSet;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private simplebaseDataSetTableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter;
        private simplebaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtrazaosocial;
        private System.Windows.Forms.TextBox txtnomefantasia;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.TextBox txtuf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MaskedTextBox txtcnpj;
        private System.Windows.Forms.MaskedTextBox txttelefone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Cadastro;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtrg;
        private System.Windows.Forms.TextBox txtsite;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingNavigator fornecedoresBindingNavigator;
        private System.Windows.Forms.ToolStripButton tsbtndelete;
        private System.Windows.Forms.Button txtpesquisar2;
        private System.Windows.Forms.TextBox txtpesquisar;
    }
}