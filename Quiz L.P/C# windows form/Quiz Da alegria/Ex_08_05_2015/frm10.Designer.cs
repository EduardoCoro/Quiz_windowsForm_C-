namespace Ex_08_05_2015
{
    partial class frm10
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
            this.btFinal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btFinal
            // 
            this.btFinal.Location = new System.Drawing.Point(323, 415);
            this.btFinal.Name = "btFinal";
            this.btFinal.Size = new System.Drawing.Size(105, 36);
            this.btFinal.TabIndex = 0;
            this.btFinal.Text = "Finalizar";
            this.btFinal.UseVisualStyleBackColor = true;
            this.btFinal.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb4);
            this.groupBox1.Controls.Add(this.rb3);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Location = new System.Drawing.Point(43, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 143);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alternativas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(41, 104);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(251, 17);
            this.rb4.TabIndex = 8;
            this.rb4.TabStop = true;
            this.rb4.Text = "Não tem solução o jeito é deixar ser o mundinho";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rb3.Location = new System.Drawing.Point(41, 81);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(291, 17);
            this.rb3.TabIndex = 0;
            this.rb3.TabStop = true;
            this.rb3.Text = "Uma única palavra \"Deus\" com ele você soluciona tudo";
            this.rb3.UseVisualStyleBackColor = false;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(41, 56);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(318, 17);
            this.rb2.TabIndex = 0;
            this.rb2.TabStop = true;
            this.rb2.Text = "Os pais são os responsáveis com isso e conseguirá solucionar";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(41, 33);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(113, 17);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "Cuidar da sua vida";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 64);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hoje no mundo tudo acontece de ruim e os jovens estão entrando \r\nna onda do alcol" +
                "ismo, sexualismo e também no mundo \r\ndas drogas.\r\n                              " +
                "  Qual a solução para isso?  ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frm10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 483);
            this.ControlBox = false;
            this.Controls.Add(this.btFinal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "10° Décima e Última Pergunta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFinal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Label label1;
    }
}