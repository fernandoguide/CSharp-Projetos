namespace simplestock
{
    partial class frmRelatorioVendas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioVendas));
            this.VendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simplebaseDataSet = new simplestock.simplebaseDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpinicial = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.fillByFiltrarDataToolStrip = new System.Windows.Forms.ToolStrip();
            this.dataToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.dataToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByFiltrarDataToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fillByDatafinalxInicialToolStrip = new System.Windows.Forms.ToolStrip();
            this.dataToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dataToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.data1ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.data1ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByDatafinalxInicialToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtfiltrarcliente = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.txtfiltrarvendedor = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.fillBydataevendedorToolStrip = new System.Windows.Forms.ToolStrip();
            this.dataToolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dataToolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.vendedorToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.vendedorToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillBydataevendedorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByFiltrarVendedoToolStrip = new System.Windows.Forms.ToolStrip();
            this.vendedorToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.vendedorToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByFiltrarVendedoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByFiltroClienteToolStrip = new System.Windows.Forms.ToolStrip();
            this.clienteToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.clienteToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByFiltroClienteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.VendaTableAdapter = new simplestock.simplebaseDataSetTableAdapters.VendaTableAdapter();
            this.tableAdapterManager = new simplestock.simplebaseDataSetTableAdapters.TableAdapterManager();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new simplestock.simplebaseDataSetTableAdapters.ClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simplebaseDataSet)).BeginInit();
            this.fillByFiltrarDataToolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.fillByDatafinalxInicialToolStrip.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.fillBydataevendedorToolStrip.SuspendLayout();
            this.fillByFiltrarVendedoToolStrip.SuspendLayout();
            this.fillByFiltroClienteToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VendaBindingSource
            // 
            this.VendaBindingSource.DataMember = "Venda";
            this.VendaBindingSource.DataSource = this.simplebaseDataSet;
            // 
            // simplebaseDataSet
            // 
            this.simplebaseDataSet.DataSetName = "simplebaseDataSet";
            this.simplebaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "relatoriovendas";
            reportDataSource1.Value = this.VendaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "simplestock.RelatorioVendas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(710, 466);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtpinicial
            // 
            this.dtpinicial.Location = new System.Drawing.Point(7, 17);
            this.dtpinicial.Name = "dtpinicial";
            this.dtpinicial.Size = new System.Drawing.Size(159, 20);
            this.dtpinicial.TabIndex = 1;
            this.dtpinicial.Value = new System.DateTime(2014, 8, 12, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fillByFiltrarDataToolStrip
            // 
            this.fillByFiltrarDataToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripLabel,
            this.dataToolStripTextBox,
            this.fillByFiltrarDataToolStripButton});
            this.fillByFiltrarDataToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByFiltrarDataToolStrip.Name = "fillByFiltrarDataToolStrip";
            this.fillByFiltrarDataToolStrip.Size = new System.Drawing.Size(706, 25);
            this.fillByFiltrarDataToolStrip.TabIndex = 6;
            this.fillByFiltrarDataToolStrip.Text = "fillByFiltrarDataToolStrip";
            this.fillByFiltrarDataToolStrip.Visible = false;
            // 
            // dataToolStripLabel
            // 
            this.dataToolStripLabel.Name = "dataToolStripLabel";
            this.dataToolStripLabel.Size = new System.Drawing.Size(34, 22);
            this.dataToolStripLabel.Text = "Data:";
            // 
            // dataToolStripTextBox
            // 
            this.dataToolStripTextBox.Name = "dataToolStripTextBox";
            this.dataToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByFiltrarDataToolStripButton
            // 
            this.fillByFiltrarDataToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByFiltrarDataToolStripButton.Name = "fillByFiltrarDataToolStripButton";
            this.fillByFiltrarDataToolStripButton.Size = new System.Drawing.Size(93, 22);
            this.fillByFiltrarDataToolStripButton.Text = "FillByFiltrarData";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 466);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(710, 69);
            this.panel2.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(710, 69);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dtpinicial);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(702, 43);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filtro por Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.fillByDatafinalxInicialToolStrip);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(843, 43);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data Inicial x Data Final";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fillByDatafinalxInicialToolStrip
            // 
            this.fillByDatafinalxInicialToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByDatafinalxInicialToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripLabel1,
            this.dataToolStripTextBox1,
            this.data1ToolStripLabel,
            this.data1ToolStripTextBox,
            this.fillByDatafinalxInicialToolStripButton});
            this.fillByDatafinalxInicialToolStrip.Location = new System.Drawing.Point(5, 9);
            this.fillByDatafinalxInicialToolStrip.Name = "fillByDatafinalxInicialToolStrip";
            this.fillByDatafinalxInicialToolStrip.Size = new System.Drawing.Size(387, 25);
            this.fillByDatafinalxInicialToolStrip.TabIndex = 11;
            this.fillByDatafinalxInicialToolStrip.Text = "fillByDatafinalxInicialToolStrip";
            // 
            // dataToolStripLabel1
            // 
            this.dataToolStripLabel1.Name = "dataToolStripLabel1";
            this.dataToolStripLabel1.Size = new System.Drawing.Size(68, 22);
            this.dataToolStripLabel1.Text = "Data Inicial:";
            // 
            // dataToolStripTextBox1
            // 
            this.dataToolStripTextBox1.Name = "dataToolStripTextBox1";
            this.dataToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // data1ToolStripLabel
            // 
            this.data1ToolStripLabel.Name = "data1ToolStripLabel";
            this.data1ToolStripLabel.Size = new System.Drawing.Size(62, 22);
            this.data1ToolStripLabel.Text = "Data Final:";
            // 
            // data1ToolStripTextBox
            // 
            this.data1ToolStripTextBox.Name = "data1ToolStripTextBox";
            this.data1ToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByDatafinalxInicialToolStripButton
            // 
            this.fillByDatafinalxInicialToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByDatafinalxInicialToolStripButton.Name = "fillByDatafinalxInicialToolStripButton";
            this.fillByDatafinalxInicialToolStripButton.Size = new System.Drawing.Size(41, 22);
            this.fillByDatafinalxInicialToolStripButton.Text = "Filtrar";
            this.fillByDatafinalxInicialToolStripButton.Click += new System.EventHandler(this.fillByDatafinalxInicialToolStripButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtfiltrarcliente);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(843, 43);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Por Cliente";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtfiltrarcliente
            // 
            this.txtfiltrarcliente.Location = new System.Drawing.Point(9, 17);
            this.txtfiltrarcliente.Name = "txtfiltrarcliente";
            this.txtfiltrarcliente.Size = new System.Drawing.Size(159, 20);
            this.txtfiltrarcliente.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Filtrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.txtfiltrarvendedor);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(843, 43);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Por Vendedor";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(173, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Filtrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtfiltrarvendedor
            // 
            this.txtfiltrarvendedor.Location = new System.Drawing.Point(8, 19);
            this.txtfiltrarvendedor.Name = "txtfiltrarvendedor";
            this.txtfiltrarvendedor.Size = new System.Drawing.Size(159, 20);
            this.txtfiltrarvendedor.TabIndex = 6;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.fillBydataevendedorToolStrip);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(843, 43);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Data + Vendedor";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // fillBydataevendedorToolStrip
            // 
            this.fillBydataevendedorToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillBydataevendedorToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripLabel2,
            this.dataToolStripTextBox2,
            this.vendedorToolStripLabel1,
            this.vendedorToolStripTextBox1,
            this.fillBydataevendedorToolStripButton});
            this.fillBydataevendedorToolStrip.Location = new System.Drawing.Point(3, 3);
            this.fillBydataevendedorToolStrip.Name = "fillBydataevendedorToolStrip";
            this.fillBydataevendedorToolStrip.Size = new System.Drawing.Size(837, 37);
            this.fillBydataevendedorToolStrip.TabIndex = 11;
            this.fillBydataevendedorToolStrip.Text = "fillBydataevendedorToolStrip";
            this.fillBydataevendedorToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fillBydataevendedorToolStrip_ItemClicked);
            // 
            // dataToolStripLabel2
            // 
            this.dataToolStripLabel2.Name = "dataToolStripLabel2";
            this.dataToolStripLabel2.Size = new System.Drawing.Size(34, 34);
            this.dataToolStripLabel2.Text = "Data:";
            // 
            // dataToolStripTextBox2
            // 
            this.dataToolStripTextBox2.Name = "dataToolStripTextBox2";
            this.dataToolStripTextBox2.Size = new System.Drawing.Size(100, 37);
            // 
            // vendedorToolStripLabel1
            // 
            this.vendedorToolStripLabel1.Name = "vendedorToolStripLabel1";
            this.vendedorToolStripLabel1.Size = new System.Drawing.Size(61, 34);
            this.vendedorToolStripLabel1.Text = "Vendedor:";
            // 
            // vendedorToolStripTextBox1
            // 
            this.vendedorToolStripTextBox1.Name = "vendedorToolStripTextBox1";
            this.vendedorToolStripTextBox1.Size = new System.Drawing.Size(100, 37);
            // 
            // fillBydataevendedorToolStripButton
            // 
            this.fillBydataevendedorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBydataevendedorToolStripButton.Name = "fillBydataevendedorToolStripButton";
            this.fillBydataevendedorToolStripButton.Size = new System.Drawing.Size(41, 34);
            this.fillBydataevendedorToolStripButton.Text = "Filtrar";
            this.fillBydataevendedorToolStripButton.Click += new System.EventHandler(this.fillBydataevendedorToolStripButton_Click);
            // 
            // fillByFiltrarVendedoToolStrip
            // 
            this.fillByFiltrarVendedoToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendedorToolStripLabel,
            this.vendedorToolStripTextBox,
            this.fillByFiltrarVendedoToolStripButton});
            this.fillByFiltrarVendedoToolStrip.Location = new System.Drawing.Point(0, 69);
            this.fillByFiltrarVendedoToolStrip.Name = "fillByFiltrarVendedoToolStrip";
            this.fillByFiltrarVendedoToolStrip.Size = new System.Drawing.Size(706, 25);
            this.fillByFiltrarVendedoToolStrip.TabIndex = 9;
            this.fillByFiltrarVendedoToolStrip.Text = "fillByFiltrarVendedoToolStrip";
            this.fillByFiltrarVendedoToolStrip.Visible = false;
            // 
            // vendedorToolStripLabel
            // 
            this.vendedorToolStripLabel.Name = "vendedorToolStripLabel";
            this.vendedorToolStripLabel.Size = new System.Drawing.Size(61, 22);
            this.vendedorToolStripLabel.Text = "Vendedor:";
            // 
            // vendedorToolStripTextBox
            // 
            this.vendedorToolStripTextBox.Name = "vendedorToolStripTextBox";
            this.vendedorToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByFiltrarVendedoToolStripButton
            // 
            this.fillByFiltrarVendedoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByFiltrarVendedoToolStripButton.Name = "fillByFiltrarVendedoToolStripButton";
            this.fillByFiltrarVendedoToolStripButton.Size = new System.Drawing.Size(116, 22);
            this.fillByFiltrarVendedoToolStripButton.Text = "FillByFiltrarVendedo";
            this.fillByFiltrarVendedoToolStripButton.Click += new System.EventHandler(this.fillByFiltrarVendedoToolStripButton_Click);
            // 
            // fillByFiltroClienteToolStrip
            // 
            this.fillByFiltroClienteToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripLabel,
            this.clienteToolStripTextBox,
            this.fillByFiltroClienteToolStripButton});
            this.fillByFiltroClienteToolStrip.Location = new System.Drawing.Point(0, 48);
            this.fillByFiltroClienteToolStrip.Name = "fillByFiltroClienteToolStrip";
            this.fillByFiltroClienteToolStrip.Size = new System.Drawing.Size(706, 25);
            this.fillByFiltroClienteToolStrip.TabIndex = 10;
            this.fillByFiltroClienteToolStrip.Text = "fillByFiltroClienteToolStrip";
            this.fillByFiltroClienteToolStrip.Visible = false;
            // 
            // clienteToolStripLabel
            // 
            this.clienteToolStripLabel.Name = "clienteToolStripLabel";
            this.clienteToolStripLabel.Size = new System.Drawing.Size(47, 22);
            this.clienteToolStripLabel.Text = "Cliente:";
            // 
            // clienteToolStripTextBox
            // 
            this.clienteToolStripTextBox.Name = "clienteToolStripTextBox";
            this.clienteToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByFiltroClienteToolStripButton
            // 
            this.fillByFiltroClienteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByFiltroClienteToolStripButton.Name = "fillByFiltroClienteToolStripButton";
            this.fillByFiltroClienteToolStripButton.Size = new System.Drawing.Size(103, 22);
            this.fillByFiltroClienteToolStripButton.Text = "FillByFiltroCliente";
            this.fillByFiltroClienteToolStripButton.Click += new System.EventHandler(this.fillByFiltroClienteToolStripButton_Click_1);
            // 
            // VendaTableAdapter
            // 
            this.VendaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AcessoOpTableAdapter = null;
            this.tableAdapterManager.AcessoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CadEmpresaTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.simplebaseDataSet;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 531);
            this.Controls.Add(this.fillByFiltrarVendedoToolStrip);
            this.Controls.Add(this.fillByFiltroClienteToolStrip);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fillByFiltrarDataToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRelatorioVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio de Vendas";
            this.Load += new System.EventHandler(this.frmRelatorioVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simplebaseDataSet)).EndInit();
            this.fillByFiltrarDataToolStrip.ResumeLayout(false);
            this.fillByFiltrarDataToolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.fillByDatafinalxInicialToolStrip.ResumeLayout(false);
            this.fillByDatafinalxInicialToolStrip.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.fillBydataevendedorToolStrip.ResumeLayout(false);
            this.fillBydataevendedorToolStrip.PerformLayout();
            this.fillByFiltrarVendedoToolStrip.ResumeLayout(false);
            this.fillByFiltrarVendedoToolStrip.PerformLayout();
            this.fillByFiltroClienteToolStrip.ResumeLayout(false);
            this.fillByFiltroClienteToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VendaBindingSource;
        private simplebaseDataSet simplebaseDataSet;
        private simplebaseDataSetTableAdapters.VendaTableAdapter VendaTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpinicial;
        private System.Windows.Forms.Button button1;
        private simplebaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillByFiltrarDataToolStrip;
        private System.Windows.Forms.ToolStripLabel dataToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox dataToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByFiltrarDataToolStripButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtfiltrarvendedor;
        private System.Windows.Forms.TextBox txtfiltrarcliente;
        private System.Windows.Forms.ToolStrip fillByFiltrarVendedoToolStrip;
        private System.Windows.Forms.ToolStripLabel vendedorToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox vendedorToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByFiltrarVendedoToolStripButton;
        private System.Windows.Forms.ToolStrip fillByFiltroClienteToolStrip;
        private System.Windows.Forms.ToolStripLabel clienteToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox clienteToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByFiltroClienteToolStripButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private simplebaseDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.ToolStrip fillByDatafinalxInicialToolStrip;
        private System.Windows.Forms.ToolStripLabel dataToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox dataToolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel data1ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox data1ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByDatafinalxInicialToolStripButton;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ToolStrip fillBydataevendedorToolStrip;
        private System.Windows.Forms.ToolStripLabel dataToolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox dataToolStripTextBox2;
        private System.Windows.Forms.ToolStripLabel vendedorToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox vendedorToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillBydataevendedorToolStripButton;
    }
}