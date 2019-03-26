namespace simplestock
{
    partial class frmImpressaoVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImpressaoVenda));
            this.ProdutoVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simplebaseDataSet = new simplestock.simplebaseDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProdutoVendaTableAdapter = new simplestock.simplebaseDataSetTableAdapters.ProdutoVendaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simplebaseDataSet)).BeginInit();
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
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "venda";
            reportDataSource1.Value = this.ProdutoVendaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "simplestock.rltVenda.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(949, 539);
            this.reportViewer1.TabIndex = 0;
            // 
            // ProdutoVendaTableAdapter
            // 
            this.ProdutoVendaTableAdapter.ClearBeforeFill = true;
            // 
            // frmImpressaoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 539);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmImpressaoVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impressão Venda";
            this.Load += new System.EventHandler(this.frmImpressaoVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simplebaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProdutoVendaBindingSource;
        private simplebaseDataSet simplebaseDataSet;
        private simplebaseDataSetTableAdapters.ProdutoVendaTableAdapter ProdutoVendaTableAdapter;
    }
}