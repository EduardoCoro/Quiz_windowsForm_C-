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
    public partial class Resultcs : Form
    {
        public Resultcs()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            lbl1.Text= " "+ VariaveisGlobais.certas;
        }
        private void lbl2_Click(object sender, EventArgs e)
        {
            lbl2.Text =" "+ VariaveisGlobais.erradas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Resultcs_Load(object sender, EventArgs e)
        {

        }
    }
}
