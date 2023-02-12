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
            bt1.Text= "Você acertou: " + VariaveisGlobais.certas.ToString();
        }
        private void lbl2_Click(object sender, EventArgs e)
        {
            bt1.Text ="Você errou: "+ VariaveisGlobais.erradas.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Resultcs_Load(object sender, EventArgs e)
        {
            lblAcerto.Text = VariaveisGlobais.certas.ToString();
            lblErro.Text = VariaveisGlobais.erradas.ToString();
            lblPont.Text = VariaveisGlobais.pontos.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblAcerto_Click(object sender, EventArgs e)
        {

        }
    }
}
