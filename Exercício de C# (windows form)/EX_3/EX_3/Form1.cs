using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1,R;
            n1 = double.Parse(txt.Text);

            R = n1 * 2;
            MessageBox.Show("O dobro é : " + R, "Dobro do valor", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n2, R;
            n2 = double.Parse(txt.Text);

            R = n2 * 3;
            MessageBox.Show("O triplo é : " + R, "Triplo do Número", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double n3, R;
            n3 = double.Parse(txt.Text);

            R = n3 +1;
            MessageBox.Show("O sucessor é : " + R, "Sucessor do valor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double n4, R;
            n4 = double.Parse(txt.Text);

            R = n4 -1;
            MessageBox.Show("O antecessor é :  " + R, "Antecessor do valor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt.Clear();

        }
    }
}
