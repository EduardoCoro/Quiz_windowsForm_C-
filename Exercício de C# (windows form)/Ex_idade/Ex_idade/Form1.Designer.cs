namespace Ex_idade
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstmulher = new System.Windows.Forms.ListBox();
            this.lsthomens = new System.Windows.Forms.ListBox();
            this.cbsexo = new System.Windows.Forms.ComboBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtnasc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblhomens = new System.Windows.Forms.Label();
            this.lblmulher = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstmulher
            // 
            this.lstmulher.BackColor = System.Drawing.Color.White;
            this.lstmulher.FormattingEnabled = true;
            this.lstmulher.Location = new System.Drawing.Point(555, 130);
            this.lstmulher.Name = "lstmulher";
            this.lstmulher.Size = new System.Drawing.Size(146, 316);
            this.lstmulher.TabIndex = 8;
            // 
            // lsthomens
            // 
            this.lsthomens.BackColor = System.Drawing.Color.White;
            this.lsthomens.FormattingEnabled = true;
            this.lsthomens.Location = new System.Drawing.Point(347, 130);
            this.lsthomens.Name = "lsthomens";
            this.lsthomens.Size = new System.Drawing.Size(142, 316);
            this.lsthomens.TabIndex = 7;
            // 
            // cbsexo
            // 
            this.cbsexo.FormattingEnabled = true;
            this.cbsexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbsexo.Location = new System.Drawing.Point(125, 206);
            this.cbsexo.Name = "cbsexo";
            this.cbsexo.Size = new System.Drawing.Size(121, 21);
            this.cbsexo.TabIndex = 1;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(125, 160);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 0;
            // 
            // txtnasc
            // 
            this.txtnasc.Location = new System.Drawing.Point(127, 269);
            this.txtnasc.Name = "txtnasc";
            this.txtnasc.Size = new System.Drawing.Size(100, 20);
            this.txtnasc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sexo : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ano de Nascimento:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(125, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "IDADE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.BackgroundImage = global::Ex_idade.Properties.Resources._1428682581_Gnome_Edit_Clear_48;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(205, 472);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 37);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(376, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Homens";
            // 
            // lblhomens
            // 
            this.lblhomens.AutoSize = true;
            this.lblhomens.Location = new System.Drawing.Point(347, 467);
            this.lblhomens.Name = "lblhomens";
            this.lblhomens.Size = new System.Drawing.Size(0, 13);
            this.lblhomens.TabIndex = 12;
            // 
            // lblmulher
            // 
            this.lblmulher.AutoSize = true;
            this.lblmulher.Location = new System.Drawing.Point(562, 471);
            this.lblmulher.Name = "lblmulher";
            this.lblmulher.Size = new System.Drawing.Size(0, 13);
            this.lblmulher.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(589, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mulheres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Khaki;
            this.label6.Location = new System.Drawing.Point(199, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 31);
            this.label6.TabIndex = 16;
            this.label6.Text = "Exercício da idade";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Ex_idade.Properties.Resources._1428683303_media_playlist_clear;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(501, 471);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 33);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Ex_idade.Properties.Resources.delete;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(15, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 30);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(704, 496);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 21);
            this.button5.TabIndex = 17;
            this.button5.Text = "Info";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(744, 521);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblmulher);
            this.Controls.Add(this.lblhomens);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnasc);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.cbsexo);
            this.Controls.Add(this.lsthomens);
            this.Controls.Add(this.lstmulher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "IDADE";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Tomato;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstmulher;
        private System.Windows.Forms.ListBox lsthomens;
        private System.Windows.Forms.ComboBox cbsexo;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtnasc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblhomens;
        private System.Windows.Forms.Label lblmulher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
    }
}

