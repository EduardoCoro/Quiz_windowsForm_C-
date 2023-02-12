using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class CadCidade : Form
    {
        public CadCidade()
        {
            InitializeComponent();
        }

        private void cidadesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cidadesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._farmacia_mdfDataSet);

        }

        private void CadCidade_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_farmacia_mdfDataSet.Cidades' table. You can move, or remove it, as needed.
            this.cidadesTableAdapter.Fill(this._farmacia_mdfDataSet.Cidades);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            cidadesBindingSource.CancelEdit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Preencha os campos!");
        }
    }
}
