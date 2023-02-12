namespace Ex_08_05_2015
{
    partial class Resultcs
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPont = new System.Windows.Forms.Label();
            this.bt1 = new System.Windows.Forms.Button();
            this.lblAcerto = new System.Windows.Forms.Label();
            this.lblErro = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Ex_08_05_2015.Properties.Resources.p;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 244);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Questões certas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Questões erradas:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPont
            // 
            this.lblPont.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPont.Location = new System.Drawing.Point(289, 369);
            this.lblPont.Name = "lblPont";
            this.lblPont.Size = new System.Drawing.Size(66, 26);
            this.lblPont.TabIndex = 3;
            this.lblPont.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(380, 432);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(92, 38);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "Jogar Novamente";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAcerto
            // 
            this.lblAcerto.AutoSize = true;
            this.lblAcerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcerto.Location = new System.Drawing.Point(289, 290);
            this.lblAcerto.Name = "lblAcerto";
            this.lblAcerto.Size = new System.Drawing.Size(0, 24);
            this.lblAcerto.TabIndex = 4;
            this.lblAcerto.Click += new System.EventHandler(this.lblAcerto_Click);
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.Location = new System.Drawing.Point(289, 330);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 24);
            this.lblErro.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pontuação:";
            // 
            // Resultcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 483);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.lblAcerto);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.lblPont);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Resultcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório do Quiz -   Parabéns por jogar";
            this.Load += new System.EventHandler(this.Resultcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPont;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Label lblAcerto;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Label label3;
    }
}