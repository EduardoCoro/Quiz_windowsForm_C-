using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btok_Click(object sender, EventArgs e)
        {
            listnome.Items.Add((listnome.Items.Count + 1) + " - " + textBox1.Text);
            lblnome.Text = listnome.Items.Count.ToString();
            listgame.Items.Add(" " + comboBox1.Text);
            lblgame.Text = listgame.Items.Count.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listnome.Items.Clear();
            listgame.Items.Clear();
            lblgame.Text = "";
            lblnome.Text = "";
        }
    }
}
