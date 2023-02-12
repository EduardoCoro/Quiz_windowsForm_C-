using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex_idade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double idade,nasc;
            nasc = double.Parse(txtnasc.Text);
            idade=2015 - nasc;

            if (cbsexo.Text == "Masculino")
            {
                lsthomens.Items.Add(txtnome.Text + " - " + idade + " anos");
            }
            else
            {
                lstmulher.Items.Add(txtnome.Text + " - " + idade + " anos");
            }

            lblhomens.Text = lsthomens.Items.Count.ToString();
            lblmulher.Text = lstmulher.Items.Count.ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtnome.Clear();
            txtnasc.Clear();
            cbsexo.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lsthomens.Items.Clear();
            lstmulher.Items.Clear();
            lblhomens.Text = "";
            lblmulher.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" 'X'é para fechar, 'vassoura' é para limpar os registros, 'tabela' limpar a lista.","Informações",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
