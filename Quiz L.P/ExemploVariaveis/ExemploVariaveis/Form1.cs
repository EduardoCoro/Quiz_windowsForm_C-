using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExemploVariaveis
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void formulário1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm2 novoForm = new frm2();
            novoForm.ShowDialog();


        }

        private void formulário2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm3 novoForm = new frm3();
            novoForm.ShowDialog();
        }
    }
}
