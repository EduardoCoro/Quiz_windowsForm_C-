namespace ExemploQuiz
{
    partial class frmP2
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
            this.brFinalizar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qual a cor do cavalo branco de Napoleão?";
            // 
            // brFinalizar
            // 
            this.brFinalizar.Location = new System.Drawing.Point(118, 192);
            this.brFinalizar.Name = "brFinalizar";
            this.brFinalizar.Size = new System.Drawing.Size(75, 23);
            this.brFinalizar.TabIndex = 1;
            this.brFinalizar.Text = "Finalizar";
            this.brFinalizar.UseVisualStyleBackColor = true;
            this.brFinalizar.Click += new System.EventHandler(this.brFinalizar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // frmP2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 408);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.brFinalizar);
            this.Controls.Add(this.label1);
            this.Name = "frmP2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmP2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button brFinalizar;
        private System.Windows.Forms.TextBox textBox1;
    }
}