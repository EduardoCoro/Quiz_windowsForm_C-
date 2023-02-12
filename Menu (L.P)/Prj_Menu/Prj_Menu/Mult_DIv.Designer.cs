namespace Prj_Menu
{
    partial class Mult_Div
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbMult = new System.Windows.Forms.RadioButton();
            this.rdbDiv = new System.Windows.Forms.RadioButton();
            this.btCal = new System.Windows.Forms.Button();
            this.btLimp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "1° Número ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "2° Número";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(130, 6);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 20);
            this.txtN1.TabIndex = 1;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(130, 30);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 20);
            this.txtN2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDiv);
            this.groupBox1.Controls.Add(this.rdbMult);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(65, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 85);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções de Calculos";
            // 
            // rdbMult
            // 
            this.rdbMult.AutoSize = true;
            this.rdbMult.Location = new System.Drawing.Point(37, 19);
            this.rdbMult.Name = "rdbMult";
            this.rdbMult.Size = new System.Drawing.Size(105, 20);
            this.rdbMult.TabIndex = 3;
            this.rdbMult.TabStop = true;
            this.rdbMult.Text = "Multiplicação";
            this.rdbMult.UseVisualStyleBackColor = true;
            // 
            // rdbDiv
            // 
            this.rdbDiv.AutoSize = true;
            this.rdbDiv.Location = new System.Drawing.Point(37, 52);
            this.rdbDiv.Name = "rdbDiv";
            this.rdbDiv.Size = new System.Drawing.Size(72, 20);
            this.rdbDiv.TabIndex = 4;
            this.rdbDiv.TabStop = true;
            this.rdbDiv.Text = "Divisão";
            this.rdbDiv.UseVisualStyleBackColor = true;
            this.rdbDiv.CheckedChanged += new System.EventHandler(this.rdbDiv_CheckedChanged);
            // 
            // btCal
            // 
            this.btCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCal.Location = new System.Drawing.Point(102, 186);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(69, 26);
            this.btCal.TabIndex = 0;
            this.btCal.Text = "Calcular";
            this.btCal.UseVisualStyleBackColor = true;
            this.btCal.Click += new System.EventHandler(this.btCal_Click);
            // 
            // btLimp
            // 
            this.btLimp.Location = new System.Drawing.Point(12, 227);
            this.btLimp.Name = "btLimp";
            this.btLimp.Size = new System.Drawing.Size(75, 23);
            this.btLimp.TabIndex = 5;
            this.btLimp.Text = "Limpar";
            this.btLimp.UseVisualStyleBackColor = true;
            this.btLimp.Click += new System.EventHandler(this.btLimp_Click);
            // 
            // Mult_Div
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btLimp);
            this.Controls.Add(this.btCal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mult_Div";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiplicação/Divisão";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDiv;
        private System.Windows.Forms.RadioButton rdbMult;
        private System.Windows.Forms.Button btCal;
        private System.Windows.Forms.Button btLimp;
    }
}