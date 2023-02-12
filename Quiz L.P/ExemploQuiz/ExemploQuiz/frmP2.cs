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
    public partial class frmP2 : Form
    {
        public frmP2()
        {
            InitializeComponent();
        }

        private void brFinalizar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="branco" || textBox1.Text=="Branco")
            {

                MessageBox.Show("Certa Resposta");
                //VariaveisGlobais.Pontuacao = VariaveisGlobais.Pontuacao + 10; ou
                VariaveisGlobais.Pontuacao += 10;

            }
            else
            {
                MessageBox.Show("VC é burrro pra krl");
                VariaveisGlobais.Pontuacao -= 5;
            }
            this.Close();
        }
    }
}
