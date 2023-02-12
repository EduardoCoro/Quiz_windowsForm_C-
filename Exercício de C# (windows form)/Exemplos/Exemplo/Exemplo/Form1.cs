using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {

            if (cbEstado.Text =="SP")
            {
                lstEstado.Items.Add(txtCidade.Text + " SP" );    
            }
            else
            {
                lstEstado.Items.Add(txtCidade.Text + "Não é SP, então cai fora");
            }

            lblQTD.Text = lstEstado.Items.Count.ToString();



        }
    }
}
