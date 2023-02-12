using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExemploQuiz
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {

            VariaveisGlobais.Pontuacao = 0;
            frmP1 form = new frmP1();
            form.ShowDialog();
            lblPontuacao.Text = "Sua pontuação foi: " + VariaveisGlobais.Pontuacao.ToString();


        }
    }
}
