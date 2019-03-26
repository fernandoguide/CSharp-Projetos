using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace simplestock
{
    public partial class frmVendasExcluidas : Form
    {
        public frmVendasExcluidas()
        {
            InitializeComponent();
        }

        private void vendasExcluidasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendasExcluidasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.simplebaseDataSet);

        }

        private void frmVendasExcluidas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'simplebaseDataSet.VendasExcluidas' table. You can move, or remove it, as needed.
            this.vendasExcluidasTableAdapter.Fill(this.simplebaseDataSet.VendasExcluidas);

        }
    }
}
