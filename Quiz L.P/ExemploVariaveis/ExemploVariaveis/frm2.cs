﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExemploVariaveis
{
    public partial class frm2 : Form
    {

     

        public frm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


            VariaveisGlobais.Nome = textBox1.Text;


            label1.Text = VariaveisGlobais.Nome;



        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(VariaveisGlobais.Nome);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm3 form = new frm3();
           form.ShowDialog();
        }
    }
}
