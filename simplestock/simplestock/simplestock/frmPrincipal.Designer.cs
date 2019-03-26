namespace simplestock
{
    partial class frmPrincipal
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
            System.Windows.Forms.Label codAcessoLabel;
            System.Windows.Forms.Label cadastroLabel;
            System.Windows.Forms.Label consultaLabel;
            System.Windows.Forms.Label relatorioLabel;
            System.Windows.Forms.Label configuracoesLabel;
            System.Windows.Forms.Label backupLabel;
            System.Windows.Forms.Label vendaLabel;
            System.Windows.Forms.Label entradaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosDeVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmconfig = new System.Windows.Forms.ToolStripMenuItem();
            this.reimpressãoVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsluser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslnome = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslnivel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnfornecedor = new System.Windows.Forms.ToolStripButton();
            this.tsbtnfuncionarios = new System.Windows.Forms.ToolStripButton();
            this.tsbtnprodutos = new System.Windows.Forms.ToolStripButton();
            this.tsbtnclientes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnConsultaFornecedor = new System.Windows.Forms.ToolStripButton();
            this.tsbtnconsultafuncionarios = new System.Windows.Forms.ToolStripButton();
            this.tsbtnconsultaprodutos = new System.Windows.Forms.ToolStripButton();
            this.tsbtnconsultaclientes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnVendas = new System.Windows.Forms.ToolStripButton();
            this.tsbtnConsVendas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.relogio = new System.Windows.Forms.Timer(this.components);
            this.relogiodig = new System.Windows.Forms.Label();
            this.prelogio = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imgprincTextBox = new System.Windows.Forms.TextBox();
            this.imagensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simplebaseDataSet = new simplestock.simplebaseDataSet();
            this.imagensTableAdapter = new simplestock.simplebaseDataSetTableAdapters.ImagensTableAdapter();
            this.tableAdapterManager = new simplestock.simplebaseDataSetTableAdapters.TableAdapterManager();
            this.imagensBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.imagensBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.picboxlogoempresa = new System.Windows.Forms.PictureBox();
            this.acessoOpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.acessoOpTableAdapter = new simplestock.simplebaseDataSetTableAdapters.AcessoOpTableAdapter();
            this.txtacesso = new System.Windows.Forms.TextBox();
            this.txtcadastro = new System.Windows.Forms.TextBox();
            this.txtconsulta = new System.Windows.Forms.TextBox();
            this.txtrelatorio = new System.Windows.Forms.TextBox();
            this.txtconfiguracoes = new System.Windows.Forms.TextBox();
            this.txtbackup = new System.Windows.Forms.TextBox();
            this.txtvenda = new System.Windows.Forms.TextBox();
            this.txtentrada = new System.Windows.Forms.TextBox();
            this.fillByacessocodToolStrip = new System.Windows.Forms.ToolStrip();
            this.codAcessoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.codAcessoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByacessocodToolStripButton = new System.Windows.Forms.ToolStripButton();
            codAcessoLabel = new System.Windows.Forms.Label();
            cadastroLabel = new System.Windows.Forms.Label();
            consultaLabel = new System.Windows.Forms.Label();
            relatorioLabel = new System.Windows.Forms.Label();
            configuracoesLabel = new System.Windows.Forms.Label();
            backupLabel = new System.Windows.Forms.Label();
            vendaLabel = new System.Windows.Forms.Label();
            entradaLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.prelogio.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simplebaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagensBindingNavigator)).BeginInit();
            this.imagensBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlogoempresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acessoOpBindingSource)).BeginInit();
            this.fillByacessocodToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // codAcessoLabel
            // 
            codAcessoLabel.AutoSize = true;
            codAcessoLabel.Location = new System.Drawing.Point(503, 143);
            codAcessoLabel.Name = "codAcessoLabel";
            codAcessoLabel.Size = new System.Drawing.Size(67, 13);
            codAcessoLabel.TabIndex = 7;
            codAcessoLabel.Text = "Cod Acesso:";
            // 
            // cadastroLabel
            // 
            cadastroLabel.AutoSize = true;
            cadastroLabel.Location = new System.Drawing.Point(503, 169);
            cadastroLabel.Name = "cadastroLabel";
            cadastroLabel.Size = new System.Drawing.Size(52, 13);
            cadastroLabel.TabIndex = 9;
            cadastroLabel.Text = "Cadastro:";
            // 
            // consultaLabel
            // 
            consultaLabel.AutoSize = true;
            consultaLabel.Location = new System.Drawing.Point(503, 195);
            consultaLabel.Name = "consultaLabel";
            consultaLabel.Size = new System.Drawing.Size(51, 13);
            consultaLabel.TabIndex = 11;
            consultaLabel.Text = "Consulta:";
            // 
            // relatorioLabel
            // 
            relatorioLabel.AutoSize = true;
            relatorioLabel.Location = new System.Drawing.Point(503, 221);
            relatorioLabel.Name = "relatorioLabel";
            relatorioLabel.Size = new System.Drawing.Size(52, 13);
            relatorioLabel.TabIndex = 13;
            relatorioLabel.Text = "Relatorio:";
            // 
            // configuracoesLabel
            // 
            configuracoesLabel.AutoSize = true;
            configuracoesLabel.Location = new System.Drawing.Point(503, 247);
            configuracoesLabel.Name = "configuracoesLabel";
            configuracoesLabel.Size = new System.Drawing.Size(78, 13);
            configuracoesLabel.TabIndex = 15;
            configuracoesLabel.Text = "Configuracoes:";
            // 
            // backupLabel
            // 
            backupLabel.AutoSize = true;
            backupLabel.Location = new System.Drawing.Point(503, 273);
            backupLabel.Name = "backupLabel";
            backupLabel.Size = new System.Drawing.Size(47, 13);
            backupLabel.TabIndex = 17;
            backupLabel.Text = "Backup:";
            // 
            // vendaLabel
            // 
            vendaLabel.AutoSize = true;
            vendaLabel.Location = new System.Drawing.Point(503, 299);
            vendaLabel.Name = "vendaLabel";
            vendaLabel.Size = new System.Drawing.Size(41, 13);
            vendaLabel.TabIndex = 19;
            vendaLabel.Text = "Venda:";
            // 
            // entradaLabel
            // 
            entradaLabel.AutoSize = true;
            entradaLabel.Location = new System.Drawing.Point(503, 325);
            entradaLabel.Name = "entradaLabel";
            entradaLabel.Size = new System.Drawing.Size(47, 13);
            entradaLabel.TabIndex = 21;
            entradaLabel.Text = "Entrada:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.opçõesToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(905, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem,
            this.restaurarBackupToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // restaurarBackupToolStripMenuItem
            // 
            this.restaurarBackupToolStripMenuItem.Name = "restaurarBackupToolStripMenuItem";
            this.restaurarBackupToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.restaurarBackupToolStripMenuItem.Text = "Restaurar Backup";
            this.restaurarBackupToolStripMenuItem.Click += new System.EventHandler(this.restaurarBackupToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fornecedoresToolStripMenuItem,
            this.funcionáriosToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.tsbtnfornecedor_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.tsbtnfuncionarios_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.tsbtnprodutos_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.tsbtnclientes_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fornecedoresToolStripMenuItem1,
            this.funcionáriosToolStripMenuItem1,
            this.produtosToolStripMenuItem1,
            this.clientesToolStripMenuItem1});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // fornecedoresToolStripMenuItem1
            // 
            this.fornecedoresToolStripMenuItem1.Name = "fornecedoresToolStripMenuItem1";
            this.fornecedoresToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.fornecedoresToolStripMenuItem1.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem1.Click += new System.EventHandler(this.tsbtnconsfornecedor);
            // 
            // funcionáriosToolStripMenuItem1
            // 
            this.funcionáriosToolStripMenuItem1.Name = "funcionáriosToolStripMenuItem1";
            this.funcionáriosToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.funcionáriosToolStripMenuItem1.Text = "Funcionários";
            this.funcionáriosToolStripMenuItem1.Click += new System.EventHandler(this.tsbtnconsfuncionario);
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.produtosToolStripMenuItem1.Text = "Produtos";
            this.produtosToolStripMenuItem1.Click += new System.EventHandler(this.tsbtnconsproduto);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.tsbtnconscliente);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioDeProdutosToolStripMenuItem,
            this.relatórioDeFuncionáriosToolStripMenuItem,
            this.relatórioDeClientesToolStripMenuItem,
            this.relatórioDeFornecedoresToolStripMenuItem,
            this.relatóriosDeVendaToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // relatórioDeProdutosToolStripMenuItem
            // 
            this.relatórioDeProdutosToolStripMenuItem.Name = "relatórioDeProdutosToolStripMenuItem";
            this.relatórioDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.relatórioDeProdutosToolStripMenuItem.Text = "Relatório de Produtos";
            this.relatórioDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeProdutosToolStripMenuItem_Click);
            // 
            // relatórioDeFuncionáriosToolStripMenuItem
            // 
            this.relatórioDeFuncionáriosToolStripMenuItem.Name = "relatórioDeFuncionáriosToolStripMenuItem";
            this.relatórioDeFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.relatórioDeFuncionáriosToolStripMenuItem.Text = "Relatório de Funcionários";
            this.relatórioDeFuncionáriosToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeFuncionáriosToolStripMenuItem_Click);
            // 
            // relatórioDeClientesToolStripMenuItem
            // 
            this.relatórioDeClientesToolStripMenuItem.Name = "relatórioDeClientesToolStripMenuItem";
            this.relatórioDeClientesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.relatórioDeClientesToolStripMenuItem.Text = "Relatório de Clientes";
            this.relatórioDeClientesToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeClientesToolStripMenuItem_Click);
            // 
            // relatórioDeFornecedoresToolStripMenuItem
            // 
            this.relatórioDeFornecedoresToolStripMenuItem.Name = "relatórioDeFornecedoresToolStripMenuItem";
            this.relatórioDeFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.relatórioDeFornecedoresToolStripMenuItem.Text = "Relatório de Fornecedores";
            this.relatórioDeFornecedoresToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeFornecedoresToolStripMenuItem_Click);
            // 
            // relatóriosDeVendaToolStripMenuItem
            // 
            this.relatóriosDeVendaToolStripMenuItem.Name = "relatóriosDeVendaToolStripMenuItem";
            this.relatóriosDeVendaToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.relatóriosDeVendaToolStripMenuItem.Text = "Relatórios de Venda";
            this.relatóriosDeVendaToolStripMenuItem.Click += new System.EventHandler(this.relatóriosDeVendaToolStripMenuItem_Click);
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmconfig,
            this.reimpressãoVendaToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            this.opçõesToolStripMenuItem.Click += new System.EventHandler(this.opçõesToolStripMenuItem_Click);
            // 
            // tsmconfig
            // 
            this.tsmconfig.Name = "tsmconfig";
            this.tsmconfig.Size = new System.Drawing.Size(183, 22);
            this.tsmconfig.Text = "Configurações";
            this.tsmconfig.Click += new System.EventHandler(this.alterarLogomarcaToolStripMenuItem_Click);
            // 
            // reimpressãoVendaToolStripMenuItem
            // 
            this.reimpressãoVendaToolStripMenuItem.Name = "reimpressãoVendaToolStripMenuItem";
            this.reimpressãoVendaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.reimpressãoVendaToolStripMenuItem.Text = "Reimpressão de Venda";
            this.reimpressãoVendaToolStripMenuItem.Click += new System.EventHandler(this.reimpressãoVendaToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem1});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.sobreToolStripMenuItem.Text = "Ajuda";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem1
            // 
            this.sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            this.sobreToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.sobreToolStripMenuItem1.Text = "Sobre";
            this.sobreToolStripMenuItem1.Click += new System.EventHandler(this.sobreToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.tsluser,
            this.tslnome,
            this.toolStripStatusLabel3,
            this.tslnivel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 576);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(905, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(115, 17);
            this.toolStripStatusLabel1.Text = "Bem Vindo ao Sistema!";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(202, 17);
            this.toolStripStatusLabel2.Text = "                                                                 ";
            // 
            // tsluser
            // 
            this.tsluser.Name = "tsluser";
            this.tsluser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsluser.Size = new System.Drawing.Size(47, 17);
            this.tsluser.Text = "Usuário:";
            this.tsluser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tslnome
            // 
            this.tslnome.Name = "tslnome";
            this.tslnome.Size = new System.Drawing.Size(33, 17);
            this.tslnome.Text = "nome";
            this.tslnome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(86, 17);
            this.toolStripStatusLabel3.Text = "Nível de Acesso:";
            // 
            // tslnivel
            // 
            this.tslnivel.Name = "tslnivel";
            this.tslnivel.Size = new System.Drawing.Size(29, 17);
            this.tslnivel.Text = "nivel";
            this.tslnivel.TextChanged += new System.EventHandler(this.tslnivel_TextChanged);
            this.tslnivel.VisibleChanged += new System.EventHandler(this.tslnivel_VisibleChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(60, 60);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnfornecedor,
            this.tsbtnfuncionarios,
            this.tsbtnprodutos,
            this.tsbtnclientes,
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.tsbtnConsultaFornecedor,
            this.tsbtnconsultafuncionarios,
            this.tsbtnconsultaprodutos,
            this.tsbtnconsultaclientes,
            this.toolStripSeparator3,
            this.tsbtnVendas,
            this.tsbtnConsVendas,
            this.toolStripSeparator2,
            this.tsbtnSair});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(905, 67);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnfornecedor
            // 
            this.tsbtnfornecedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnfornecedor.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnfornecedor.Image")));
            this.tsbtnfornecedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnfornecedor.Name = "tsbtnfornecedor";
            this.tsbtnfornecedor.Size = new System.Drawing.Size(64, 64);
            this.tsbtnfornecedor.Text = "Cadastro de Fornecedores";
            this.tsbtnfornecedor.Click += new System.EventHandler(this.tsbtnfornecedor_Click);
            // 
            // tsbtnfuncionarios
            // 
            this.tsbtnfuncionarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnfuncionarios.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnfuncionarios.Image")));
            this.tsbtnfuncionarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnfuncionarios.Name = "tsbtnfuncionarios";
            this.tsbtnfuncionarios.Size = new System.Drawing.Size(64, 64);
            this.tsbtnfuncionarios.Text = "Cadastro de Funcionários";
            this.tsbtnfuncionarios.Click += new System.EventHandler(this.tsbtnfuncionarios_Click);
            // 
            // tsbtnprodutos
            // 
            this.tsbtnprodutos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnprodutos.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnprodutos.Image")));
            this.tsbtnprodutos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnprodutos.Name = "tsbtnprodutos";
            this.tsbtnprodutos.Size = new System.Drawing.Size(64, 64);
            this.tsbtnprodutos.Text = "Cadastro de Produtos";
            this.tsbtnprodutos.Click += new System.EventHandler(this.tsbtnprodutos_Click);
            // 
            // tsbtnclientes
            // 
            this.tsbtnclientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnclientes.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnclientes.Image")));
            this.tsbtnclientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnclientes.Name = "tsbtnclientes";
            this.tsbtnclientes.Size = new System.Drawing.Size(64, 64);
            this.tsbtnclientes.Text = "Cadastro de Clientes";
            this.tsbtnclientes.Click += new System.EventHandler(this.tsbtnclientes_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 67);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(64, 64);
            this.toolStripButton1.Text = "Entrada de Produtos";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 67);
            // 
            // tsbtnConsultaFornecedor
            // 
            this.tsbtnConsultaFornecedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnConsultaFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnConsultaFornecedor.Image")));
            this.tsbtnConsultaFornecedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConsultaFornecedor.Name = "tsbtnConsultaFornecedor";
            this.tsbtnConsultaFornecedor.Size = new System.Drawing.Size(64, 64);
            this.tsbtnConsultaFornecedor.Text = "Consulta de Fornecedores";
            this.tsbtnConsultaFornecedor.Click += new System.EventHandler(this.tsbtnconsfornecedor);
            // 
            // tsbtnconsultafuncionarios
            // 
            this.tsbtnconsultafuncionarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnconsultafuncionarios.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnconsultafuncionarios.Image")));
            this.tsbtnconsultafuncionarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnconsultafuncionarios.Name = "tsbtnconsultafuncionarios";
            this.tsbtnconsultafuncionarios.Size = new System.Drawing.Size(64, 64);
            this.tsbtnconsultafuncionarios.Text = "Consulta de Funcionários";
            this.tsbtnconsultafuncionarios.Click += new System.EventHandler(this.tsbtnconsfuncionario);
            // 
            // tsbtnconsultaprodutos
            // 
            this.tsbtnconsultaprodutos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnconsultaprodutos.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnconsultaprodutos.Image")));
            this.tsbtnconsultaprodutos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnconsultaprodutos.Name = "tsbtnconsultaprodutos";
            this.tsbtnconsultaprodutos.Size = new System.Drawing.Size(64, 64);
            this.tsbtnconsultaprodutos.Text = "Consulta de Produtos";
            this.tsbtnconsultaprodutos.Click += new System.EventHandler(this.tsbtnconsproduto);
            // 
            // tsbtnconsultaclientes
            // 
            this.tsbtnconsultaclientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnconsultaclientes.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnconsultaclientes.Image")));
            this.tsbtnconsultaclientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnconsultaclientes.Name = "tsbtnconsultaclientes";
            this.tsbtnconsultaclientes.Size = new System.Drawing.Size(64, 64);
            this.tsbtnconsultaclientes.Text = "Consulta de Clientes";
            this.tsbtnconsultaclientes.Click += new System.EventHandler(this.tsbtnconscliente);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 67);
            // 
            // tsbtnVendas
            // 
            this.tsbtnVendas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnVendas.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnVendas.Image")));
            this.tsbtnVendas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnVendas.Name = "tsbtnVendas";
            this.tsbtnVendas.Size = new System.Drawing.Size(64, 64);
            this.tsbtnVendas.Text = "Vendas";
            this.tsbtnVendas.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // tsbtnConsVendas
            // 
            this.tsbtnConsVendas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnConsVendas.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnConsVendas.Image")));
            this.tsbtnConsVendas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConsVendas.Name = "tsbtnConsVendas";
            this.tsbtnConsVendas.Size = new System.Drawing.Size(64, 64);
            this.tsbtnConsVendas.Text = "Consulta Vendas";
            this.tsbtnConsVendas.Click += new System.EventHandler(this.tsbtnConsVendas_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 67);
            // 
            // tsbtnSair
            // 
            this.tsbtnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSair.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSair.Image")));
            this.tsbtnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSair.Name = "tsbtnSair";
            this.tsbtnSair.Size = new System.Drawing.Size(64, 64);
            this.tsbtnSair.Text = "Sair";
            this.tsbtnSair.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "backup";
            this.saveFileDialog1.Filter = "\"Backup Stock (*.backup)|*.backup|All files (*.*)|*.*\"";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "backup";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Backup Stock (*.backup)|*.backup|All files (*.*)|*.*\"";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.BackColor = System.Drawing.Color.White;
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.monthCalendar1.Location = new System.Drawing.Point(2, 124);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.GhostWhite;
            this.monthCalendar1.TitleForeColor = System.Drawing.SystemColors.ControlText;
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.Silver;
            // 
            // relogio
            // 
            this.relogio.Enabled = true;
            this.relogio.Interval = 1000;
            this.relogio.Tick += new System.EventHandler(this.relogio_Tick);
            // 
            // relogiodig
            // 
            this.relogiodig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.relogiodig.AutoSize = true;
            this.relogiodig.BackColor = System.Drawing.Color.White;
            this.relogiodig.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relogiodig.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.relogiodig.Location = new System.Drawing.Point(12, 33);
            this.relogiodig.Name = "relogiodig";
            this.relogiodig.Size = new System.Drawing.Size(154, 44);
            this.relogiodig.TabIndex = 5;
            this.relogiodig.Text = "Relógio";
            this.relogiodig.Click += new System.EventHandler(this.relogiodig_Click);
            // 
            // prelogio
            // 
            this.prelogio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.prelogio.BackColor = System.Drawing.Color.White;
            this.prelogio.Controls.Add(this.groupBox1);
            this.prelogio.Location = new System.Drawing.Point(725, 95);
            this.prelogio.Name = "prelogio";
            this.prelogio.Size = new System.Drawing.Size(180, 481);
            this.prelogio.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.relogiodig);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Location = new System.Drawing.Point(0, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 483);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // imgprincTextBox
            // 
            this.imgprincTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgprincTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imagensBindingSource, "Imgprinc", true));
            this.imgprincTextBox.Location = new System.Drawing.Point(243, 221);
            this.imgprincTextBox.Name = "imgprincTextBox";
            this.imgprincTextBox.Size = new System.Drawing.Size(214, 20);
            this.imgprincTextBox.TabIndex = 6;
            // 
            // imagensBindingSource
            // 
            this.imagensBindingSource.DataMember = "Imagens";
            this.imagensBindingSource.DataSource = this.simplebaseDataSet;
            // 
            // simplebaseDataSet
            // 
            this.simplebaseDataSet.DataSetName = "simplebaseDataSet";
            this.simplebaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imagensTableAdapter
            // 
            this.imagensTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ImagensTableAdapter = this.imagensTableAdapter;
            this.tableAdapterManager.ItemsTableAdapter = null;
            this.tableAdapterManager.ProdutoVendaTableAdapter = null;
            this.tableAdapterManager.SenhamestreTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = simplestock.simplebaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendasExcluidasTableAdapter = null;
            this.tableAdapterManager.VendaTableAdapter = null;
            // 
            // imagensBindingNavigator
            // 
            this.imagensBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.imagensBindingNavigator.BindingSource = this.imagensBindingSource;
            this.imagensBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.imagensBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.imagensBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.imagensBindingNavigatorSaveItem});
            this.imagensBindingNavigator.Location = new System.Drawing.Point(0, 95);
            this.imagensBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.imagensBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.imagensBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.imagensBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.imagensBindingNavigator.Name = "imagensBindingNavigator";
            this.imagensBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.imagensBindingNavigator.Size = new System.Drawing.Size(795, 25);
            this.imagensBindingNavigator.TabIndex = 7;
            this.imagensBindingNavigator.Text = "bindingNavigator1";
            this.imagensBindingNavigator.Visible = false;
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
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
            // imagensBindingNavigatorSaveItem
            // 
            this.imagensBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imagensBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("imagensBindingNavigatorSaveItem.Image")));
            this.imagensBindingNavigatorSaveItem.Name = "imagensBindingNavigatorSaveItem";
            this.imagensBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.imagensBindingNavigatorSaveItem.Text = "Save Data";
            this.imagensBindingNavigatorSaveItem.Click += new System.EventHandler(this.imagensBindingNavigatorSaveItem_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // picboxlogoempresa
            // 
            this.picboxlogoempresa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxlogoempresa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picboxlogoempresa.ImageLocation = "";
            this.picboxlogoempresa.Location = new System.Drawing.Point(0, 94);
            this.picboxlogoempresa.Name = "picboxlogoempresa";
            this.picboxlogoempresa.Size = new System.Drawing.Size(719, 483);
            this.picboxlogoempresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxlogoempresa.TabIndex = 3;
            this.picboxlogoempresa.TabStop = false;
            this.picboxlogoempresa.Click += new System.EventHandler(this.picboxlogoempresa_Click);
            // 
            // acessoOpBindingSource
            // 
            this.acessoOpBindingSource.DataMember = "AcessoOp";
            this.acessoOpBindingSource.DataSource = this.simplebaseDataSet;
            // 
            // acessoOpTableAdapter
            // 
            this.acessoOpTableAdapter.ClearBeforeFill = true;
            // 
            // txtacesso
            // 
            this.txtacesso.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.acessoOpBindingSource, "CodAcesso", true));
            this.txtacesso.Location = new System.Drawing.Point(587, 140);
            this.txtacesso.Name = "txtacesso";
            this.txtacesso.Size = new System.Drawing.Size(69, 20);
            this.txtacesso.TabIndex = 8;
            // 
            // txtcadastro
            // 
            this.txtcadastro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.acessoOpBindingSource, "Cadastro", true));
            this.txtcadastro.Location = new System.Drawing.Point(587, 166);
            this.txtcadastro.Name = "txtcadastro";
            this.txtcadastro.Size = new System.Drawing.Size(69, 20);
            this.txtcadastro.TabIndex = 10;
            // 
            // txtconsulta
            // 
            this.txtconsulta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.acessoOpBindingSource, "Consulta", true));
            this.txtconsulta.Location = new System.Drawing.Point(587, 192);
            this.txtconsulta.Name = "txtconsulta";
            this.txtconsulta.Size = new System.Drawing.Size(69, 20);
            this.txtconsulta.TabIndex = 12;
            // 
            // txtrelatorio
            // 
            this.txtrelatorio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.acessoOpBindingSource, "Relatorio", true));
            this.txtrelatorio.Location = new System.Drawing.Point(587, 218);
            this.txtrelatorio.Name = "txtrelatorio";
            this.txtrelatorio.Size = new System.Drawing.Size(69, 20);
            this.txtrelatorio.TabIndex = 14;
            // 
            // txtconfiguracoes
            // 
            this.txtconfiguracoes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.acessoOpBindingSource, "Configuracoes", true));
            this.txtconfiguracoes.Location = new System.Drawing.Point(587, 244);
            this.txtconfiguracoes.Name = "txtconfiguracoes";
            this.txtconfiguracoes.Size = new System.Drawing.Size(69, 20);
            this.txtconfiguracoes.TabIndex = 16;
            // 
            // txtbackup
            // 
            this.txtbackup.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.acessoOpBindingSource, "Backup", true));
            this.txtbackup.Location = new System.Drawing.Point(587, 270);
            this.txtbackup.Name = "txtbackup";
            this.txtbackup.Size = new System.Drawing.Size(69, 20);
            this.txtbackup.TabIndex = 18;
            // 
            // txtvenda
            // 
            this.txtvenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.acessoOpBindingSource, "Venda", true));
            this.txtvenda.Location = new System.Drawing.Point(587, 296);
            this.txtvenda.Name = "txtvenda";
            this.txtvenda.Size = new System.Drawing.Size(69, 20);
            this.txtvenda.TabIndex = 20;
            // 
            // txtentrada
            // 
            this.txtentrada.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.acessoOpBindingSource, "Entrada", true));
            this.txtentrada.Location = new System.Drawing.Point(587, 322);
            this.txtentrada.Name = "txtentrada";
            this.txtentrada.Size = new System.Drawing.Size(69, 20);
            this.txtentrada.TabIndex = 22;
            // 
            // fillByacessocodToolStrip
            // 
            this.fillByacessocodToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codAcessoToolStripLabel,
            this.codAcessoToolStripTextBox,
            this.fillByacessocodToolStripButton});
            this.fillByacessocodToolStrip.Location = new System.Drawing.Point(0, 95);
            this.fillByacessocodToolStrip.Name = "fillByacessocodToolStrip";
            this.fillByacessocodToolStrip.Size = new System.Drawing.Size(925, 25);
            this.fillByacessocodToolStrip.TabIndex = 23;
            this.fillByacessocodToolStrip.Text = "fillByacessocodToolStrip";
            this.fillByacessocodToolStrip.Visible = false;
            // 
            // codAcessoToolStripLabel
            // 
            this.codAcessoToolStripLabel.Name = "codAcessoToolStripLabel";
            this.codAcessoToolStripLabel.Size = new System.Drawing.Size(64, 22);
            this.codAcessoToolStripLabel.Text = "CodAcesso:";
            // 
            // codAcessoToolStripTextBox
            // 
            this.codAcessoToolStripTextBox.Name = "codAcessoToolStripTextBox";
            this.codAcessoToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByacessocodToolStripButton
            // 
            this.fillByacessocodToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByacessocodToolStripButton.Name = "fillByacessocodToolStripButton";
            this.fillByacessocodToolStripButton.Size = new System.Drawing.Size(85, 22);
            this.fillByacessocodToolStripButton.Text = "FillByacessocod";
            this.fillByacessocodToolStripButton.Click += new System.EventHandler(this.fillByacessocodToolStripButton_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 598);
            this.Controls.Add(this.imagensBindingNavigator);
            this.Controls.Add(this.fillByacessocodToolStrip);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.prelogio);
            this.Controls.Add(this.picboxlogoempresa);
            this.Controls.Add(codAcessoLabel);
            this.Controls.Add(cadastroLabel);
            this.Controls.Add(consultaLabel);
            this.Controls.Add(relatorioLabel);
            this.Controls.Add(configuracoesLabel);
            this.Controls.Add(backupLabel);
            this.Controls.Add(vendaLabel);
            this.Controls.Add(entradaLabel);
            this.Controls.Add(this.txtacesso);
            this.Controls.Add(this.txtcadastro);
            this.Controls.Add(this.txtconsulta);
            this.Controls.Add(this.txtrelatorio);
            this.Controls.Add(this.txtconfiguracoes);
            this.Controls.Add(this.txtbackup);
            this.Controls.Add(this.txtvenda);
            this.Controls.Add(this.txtentrada);
            this.Controls.Add(this.imgprincTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Max Stock";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.prelogio.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simplebaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagensBindingNavigator)).EndInit();
            this.imagensBindingNavigator.ResumeLayout(false);
            this.imagensBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlogoempresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acessoOpBindingSource)).EndInit();
            this.fillByacessocodToolStrip.ResumeLayout(false);
            this.fillByacessocodToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeFornecedoresToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnfornecedor;
        private System.Windows.Forms.ToolStripButton tsbtnfuncionarios;
        private System.Windows.Forms.ToolStripButton tsbtnprodutos;
        private System.Windows.Forms.ToolStripButton tsbtnclientes;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnConsultaFornecedor;
        private System.Windows.Forms.ToolStripButton tsbtnconsultafuncionarios;
        private System.Windows.Forms.ToolStripButton tsbtnconsultaprodutos;
        private System.Windows.Forms.ToolStripButton tsbtnconsultaclientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnVendas;
        private System.Windows.Forms.ToolStripButton tsbtnSair;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarBackupToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem relatóriosDeVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbtnConsVendas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Timer relogio;
        private System.Windows.Forms.Label relogiodig;
        private System.Windows.Forms.Panel prelogio;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private simplebaseDataSet simplebaseDataSet;
        private System.Windows.Forms.BindingSource imagensBindingSource;
        private simplebaseDataSetTableAdapters.ImagensTableAdapter imagensTableAdapter;
        private simplebaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator imagensBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton imagensBindingNavigatorSaveItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ToolStripMenuItem tsmconfig;
        public System.Windows.Forms.PictureBox picboxlogoempresa;
        private System.Windows.Forms.ToolStripMenuItem reimpressãoVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tsluser;
        public System.Windows.Forms.ToolStripStatusLabel tslnome;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.TextBox imgprincTextBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tslnivel;
        private System.Windows.Forms.BindingSource acessoOpBindingSource;
        private simplebaseDataSetTableAdapters.AcessoOpTableAdapter acessoOpTableAdapter;
        private System.Windows.Forms.TextBox txtacesso;
        private System.Windows.Forms.TextBox txtcadastro;
        private System.Windows.Forms.TextBox txtconsulta;
        private System.Windows.Forms.TextBox txtrelatorio;
        private System.Windows.Forms.TextBox txtconfiguracoes;
        private System.Windows.Forms.TextBox txtbackup;
        private System.Windows.Forms.TextBox txtvenda;
        private System.Windows.Forms.TextBox txtentrada;
        private System.Windows.Forms.ToolStrip fillByacessocodToolStrip;
        private System.Windows.Forms.ToolStripLabel codAcessoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox codAcessoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByacessocodToolStripButton;
    }
}