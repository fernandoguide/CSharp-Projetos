namespace simplestock
{
    partial class frmRelatorioProdutosVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioProdutosVenda));
            this.ProdutoVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simplebaseDataSet = new simplestock.simplebaseDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProdutoVendaTableAdapter = new simplestock.simplebaseDataSetTableAdapters.ProdutoVendaTableAdapter();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.lblnumvenda = new System.Windows.Forms.Label();
            this.fillByFiltrarporidvendaToolStrip = new System.Windows.Forms.ToolStrip();
            this.idVendaToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idVendaToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByFiltrarporidvendaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.VendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VendaTableAdapter = new simplestock.simplebaseDataSetTableAdapters.VendaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simplebaseDataSet)).BeginInit();
            this.fillByFiltrarporidvendaToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProdutoVendaBindingSource
            // 
            this.ProdutoVendaBindingSource.DataMember = "ProdutoVenda";
            this.ProdutoVendaBindingSource.DataSource = this.simplebaseDataSet;
            // 
            // simplebaseDataSet
            // 
            this.simplebaseDataSet.DataSetName = "simplebaseDataSet";
            this.simplebaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "RltProdutosVenda";
            reportDataSource1.Value = this.ProdutoVendaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "simplestock.RelatorioProdutosVenda.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(633, 340);
            this.reportViewer1.TabIndex = 0;
            // 
            // ProdutoVendaTableAdapter
            // 
            this.ProdutoVendaTableAdapter.ClearBeforeFill = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(157, 24);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 1;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(12, 26);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(136, 20);
            this.txtFiltrar.TabIndex = 2;
            // 
            // lblnumvenda
            // 
            this.lblnumvenda.AutoSize = true;
            this.lblnumvenda.Location = new System.Drawing.Point(9, 10);
            this.lblnumvenda.Name = "lblnumvenda";
            this.lblnumvenda.Size = new System.Drawing.Size(132, 13);
            this.lblnumvenda.TabIndex = 3;
            this.lblnumvenda.Text = "Digite o Número da Venda";
            // 
            // fillByFiltrarporidvendaToolStrip
            // 
            this.fillByFiltrarporidvendaToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idVendaToolStripLabel,
            this.idVendaToolStripTextBox,
            this.fillByFiltrarporidvendaToolStripButton});
            this.fillByFiltrarporidvendaToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByFiltrarporidvendaToolStrip.Name = "fillByFiltrarporidvendaToolStrip";
            this.fillByFiltrarporidvendaToolStrip.Size = new System.Drawing.Size(633, 25);
            this.fillByFiltrarporidvendaToolStrip.TabIndex = 4;
            this.fillByFiltrarporidvendaToolStrip.Text = "fillByFiltrarporidvendaToolStrip";
            this.fillByFiltrarporidvendaToolStrip.Visible = false;
            // 
            // idVendaToolStripLabel
            // 
            this.idVendaToolStripLabel.Name = "idVendaToolStripLabel";
            this.idVendaToolStripLabel.Size = new System.Drawing.Size(53, 22);
            this.idVendaToolStripLabel.Text = "IdVenda:";
            // 
            // idVendaToolStripTextBox
            // 
            this.idVendaToolStripTextBox.Name = "idVendaToolStripTextBox";
            this.idVendaToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByFiltrarporidvendaToolStripButton
            // 
            this.fillByFiltrarporidvendaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByFiltrarporidvendaToolStripButton.Name = "fillByFiltrarporidvendaToolStripButton";
            this.fillByFiltrarporidvendaToolStripButton.Size = new System.Drawing.Size(129, 22);
            this.fillByFiltrarporidvendaToolStripButton.Text = "FillByFiltrarporidvenda";
            this.fillByFiltrarporidvendaToolStripButton.Click += new System.EventHandler(this.fillByFiltrarporidvendaToolStripButton_Click);
            // 
            // VendaBindingSource
            // 
            this.VendaBindingSource.DataMember = "Venda";
            this.VendaBindingSource.DataSource = this.simplebaseDataSet;
            // 
            // VendaTableAdapter
            // 
            this.VendaTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioProdutosVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 400);
            this.Controls.Add(this.fillByFiltrarporidvendaToolStrip);
            this.Controls.Add(this.lblnumvenda);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRelatorioProdutosVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Produtos por Venda";
            this.Load += new System.EventHandler(this.frmRelatorioProdutosVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simplebaseDataSet)).EndInit();
            this.fillByFiltrarporidvendaToolStrip.ResumeLayout(false);
            this.fillByFiltrarporidvendaToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VendaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProdutoVendaBindingSource;
        private simplebaseDataSet simplebaseDataSet;
        private simplebaseDataSetTableAdapters.ProdutoVendaTableAdapter ProdutoVendaTableAdapter;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Label lblnumvenda;
        private System.Windows.Forms.ToolStrip fillByFiltrarporidvendaToolStrip;
        private System.Windows.Forms.ToolStripLabel idVendaToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idVendaToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByFiltrarporidvendaToolStripButton;
        private System.Windows.Forms.BindingSource VendaBindingSource;
        private simplebaseDataSetTableAdapters.VendaTableAdapter VendaTableAdapter;
    }
}