using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex_08_05_2015
{
    public partial class fmrPrincipal : Form
    {
        public fmrPrincipal()
        {
            InitializeComponent();
        }

        private void bt_Inicio_Click(object sender, EventArgs e)
        {
            fmr1 Prox = new fmr1();
            Prox.ShowDialog();
        }
    }
}
