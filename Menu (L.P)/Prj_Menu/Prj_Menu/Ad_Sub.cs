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
    public partial class Ad_Sub : Form
    {
        public Ad_Sub()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdbAd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtN1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btCal_Click(object sender, EventArgs e)
        {
            double n1, n2, result;
            if (txtN1.Text == "" || txtN2.Text=="")
            {
                MessageBox.Show("Digite os valores!");
            }
            else
            {
                n1 = double.Parse(txtN1.Text);

                n2 = double.Parse(txtN2.Text);


                if (rdbAd.Checked == true)
                {
                    result = n1 + n2;
                    MessageBox.Show("O resultado é: " + result);
                }
                else if (rdbSub.Checked == true)
                {
                    result = n1 - n2;
                    MessageBox.Show("O resultado é: " + result);
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

        private void txtN2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
