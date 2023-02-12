namespace Prj_Menu
{
    partial class Ad_Sub
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
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbSub = new System.Windows.Forms.RadioButton();
            this.rdbAd = new System.Windows.Forms.RadioButton();
            this.btCal = new System.Windows.Forms.Button();
            this.btLimp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(103, 16);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 20);
            this.txtN1.TabIndex = 1;
            this.txtN1.TextChanged += new System.EventHandler(this.txtN1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "1° Número";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "2° Número";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(103, 43);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 20);
            this.txtN2.TabIndex = 2;
            this.txtN2.TextChanged += new System.EventHandler(this.txtN2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.rdbSub);
            this.groupBox1.Controls.Add(this.rdbAd);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(47, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 88);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções de Calculos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdbSub
            // 
            this.rdbSub.AutoSize = true;
            this.rdbSub.Location = new System.Drawing.Point(56, 45);
            this.rdbSub.Name = "rdbSub";
            this.rdbSub.Size = new System.Drawing.Size(88, 20);
            this.rdbSub.TabIndex = 4;
            this.rdbSub.TabStop = true;
            this.rdbSub.Text = "Subtração";
            this.rdbSub.UseVisualStyleBackColor = true;
            // 
            // rdbAd
            // 
            this.rdbAd.AutoSize = true;
            this.rdbAd.Location = new System.Drawing.Point(56, 19);
            this.rdbAd.Name = "rdbAd";
            this.rdbAd.Size = new System.Drawing.Size(69, 20);
            this.rdbAd.TabIndex = 3;
            this.rdbAd.TabStop = true;
            this.rdbAd.Text = "Adição";
            this.rdbAd.UseVisualStyleBackColor = true;
            this.rdbAd.CheckedChanged += new System.EventHandler(this.rdbAd_CheckedChanged);
            // 
            // btCal
            // 
            this.btCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCal.Location = new System.Drawing.Point(103, 192);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(74, 23);
            this.btCal.TabIndex = 0;
            this.btCal.Text = "Calcular";
            this.btCal.UseVisualStyleBackColor = true;
            this.btCal.Click += new System.EventHandler(this.btCal_Click);
            // 
            // btLimp
            // 
            this.btLimp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimp.Location = new System.Drawing.Point(15, 227);
            this.btLimp.Name = "btLimp";
            this.btLimp.Size = new System.Drawing.Size(75, 23);
            this.btLimp.TabIndex = 5;
            this.btLimp.Text = "Limpar";
            this.btLimp.UseVisualStyleBackColor = true;
            this.btLimp.Click += new System.EventHandler(this.btLimp_Click);
            // 
            // Ad_Sub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(265, 268);
            this.Controls.Add(this.btLimp);
            this.Controls.Add(this.btCal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtN1);
            this.Name = "Ad_Sub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adição/Subtração";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbSub;
        private System.Windows.Forms.RadioButton rdbAd;
        private System.Windows.Forms.Button btCal;
        private System.Windows.Forms.Button btLimp;
    }
}