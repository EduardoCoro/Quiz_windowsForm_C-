using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prj_Menu
{
    public partial class frmCal : Form
    {
        public frmCal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adiçãoSubtraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ad_Sub form = new Ad_Sub();
            form.ShowDialog();
        }

        private void multiplicaçãoDivisãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mult_Div form = new Mult_Div();
            form.ShowDialog();
        }
    }
}
