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
    public partial class Mult_Div : Form
    {
        public Mult_Div()
        {
            InitializeComponent();
        }

        private void btCal_Click(object sender, EventArgs e)
        {
            double n1, n2, result;
            if (txtN1.Text == "" || txtN2.Text == "")
            {
                MessageBox.Show("Digite os valores!");
            }
            else
            {
                n1 = double.Parse(txtN1.Text);

                n2 = double.Parse(txtN2.Text);


                if (rdbMult.Checked == true)
                {
                    result = n1 * n2;
                    MessageBox.Show("O resultado é: " + result);
                }
                else if (rdbDiv.Checked == true)
                {
                    if (n2 == 0)
                    {
                        MessageBox.Show("Digite um valor!");
                    }
                    else
                    {
                        result = n1 / n2;
                        MessageBox.Show("O resultado é: " + result);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione uma opção!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btLimp_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = "";
        }

        private void rdbDiv_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}