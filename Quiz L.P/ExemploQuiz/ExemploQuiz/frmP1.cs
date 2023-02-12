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
    public partial class frmP1 : Form
    {
        public frmP1()
        {
            InitializeComponent();
        }

        private void btProx_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="Rocky Balboa" || textBox1.Text=="rocky balboa" || textBox1.Text=="Rocky")
            {

                MessageBox.Show("Certa Resposta");
                //VariaveisGlobais.Pontuacao = VariaveisGlobais.Pontuacao + 10; ou
                VariaveisGlobais.Pontuacao += 10;

            }
            else
            {
                MessageBox.Show("Resposta Errada");
                VariaveisGlobais.Pontuacao -= 5;
            }
            frmP2 Prox = new frmP2();
            Prox.ShowDialog();
            this.Close();




        }
    }
}
