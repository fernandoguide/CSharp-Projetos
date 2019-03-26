namespace simplestock
{
    partial class frmAbrirVenda
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodvend = new System.Windows.Forms.TextBox();
            this.simplebaseDataSet = new simplestock.simplebaseDataSet();
            this.produtoVendaTableAdapter = new simplestock.simplebaseDataSetTableAdapters.ProdutoVendaTableAdapter();
            this.produtoVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new simplestock.simplebaseDataSetTableAdapters.TableAdapterManager();
            this.fillByfiltroToolStrip = new System.Windows.Forms.ToolStrip();
            this.idVendaToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idVendaToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByfiltroToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simplebaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoVendaBindingSource)).BeginInit();
            this.fillByfiltroToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtcodvend);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Código da Venda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insira o Cód + Enter";
            // 
            // txtcodvend
            // 
            this.txtcodvend.Location = new System.Drawing.Point(6, 19);
            this.txtcodvend.Name = "txtcodvend";
            this.txtcodvend.Size = new System.Drawing.Size(83, 20);
            this.txtcodvend.TabIndex = 0;
            this.txtcodvend.TextChanged += new System.EventHandler(this.txtcodvend_TextChanged);
            this.txtcodvend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // simplebaseDataSet
            // 
            this.simplebaseDataSet.DataSetName = "simplebaseDataSet";
            this.simplebaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoVendaTableAdapter
            // 
            this.produtoVendaTableAdapter.ClearBeforeFill = true;
            // 
            // produtoVendaBindingSource
            // 
            this.produtoVendaBindingSource.DataMember = "ProdutoVenda";
            this.produtoVendaBindingSource.DataSource = this.simplebaseDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            // fillByfiltroToolStrip
            // 
            this.fillByfiltroToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idVendaToolStripLabel,
            this.idVendaToolStripTextBox,
            this.fillByfiltroToolStripButton});
            this.fillByfiltroToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByfiltroToolStrip.Name = "fillByfiltroToolStrip";
            this.fillByfiltroToolStrip.Size = new System.Drawing.Size(115, 25);
            this.fillByfiltroToolStrip.TabIndex = 1;
            this.fillByfiltroToolStrip.Text = "fillByfiltroToolStrip";
            this.fillByfiltroToolStrip.Visible = false;
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
            this.idVendaToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fillByfiltroToolStripButton
            // 
            this.fillByfiltroToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByfiltroToolStripButton.Name = "fillByfiltroToolStripButton";
            this.fillByfiltroToolStripButton.Size = new System.Drawing.Size(64, 19);
            this.fillByfiltroToolStripButton.Text = "FillByfiltro";
            this.fillByfiltroToolStripButton.Click += new System.EventHandler(this.fillByfiltroToolStripButton_Click);
            // 
            // frmAbrirVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(103, 61);
            this.Controls.Add(this.fillByfiltroToolStrip);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAbrirVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abrir Venda";
            this.Load += new System.EventHandler(this.frmAbrirVenda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simplebaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoVendaBindingSource)).EndInit();
            this.fillByfiltroToolStrip.ResumeLayout(false);
            this.fillByfiltroToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtcodvend;
        private simplebaseDataSet simplebaseDataSet;
        private System.Windows.Forms.BindingSource produtoVendaBindingSource;
        private simplebaseDataSetTableAdapters.ProdutoVendaTableAdapter produtoVendaTableAdapter;
        private simplebaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillByfiltroToolStrip;
        private System.Windows.Forms.ToolStripLabel idVendaToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idVendaToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByfiltroToolStripButton;
    }
}