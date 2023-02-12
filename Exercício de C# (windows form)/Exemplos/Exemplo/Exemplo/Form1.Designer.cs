namespace Exemplo
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
            this.btOk = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lstEstado = new System.Windows.Forms.ListBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblQTD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(117, 158);
            this.btOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(112, 35);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "SP",
            "MG",
            "RJ",
            "PR"});
            this.cbEstado.Location = new System.Drawing.Point(80, 237);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(180, 28);
            this.cbEstado.TabIndex = 1;
            // 
            // lstEstado
            // 
            this.lstEstado.FormattingEnabled = true;
            this.lstEstado.ItemHeight = 20;
            this.lstEstado.Location = new System.Drawing.Point(352, 27);
            this.lstEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstEstado.Name = "lstEstado";
            this.lstEstado.Size = new System.Drawing.Size(331, 404);
            this.lstEstado.TabIndex = 2;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(80, 46);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(148, 26);
            this.txtCidade.TabIndex = 3;
            // 
            // lblQTD
            // 
            this.lblQTD.AutoSize = true;
            this.lblQTD.Location = new System.Drawing.Point(380, 454);
            this.lblQTD.Name = "lblQTD";
            this.lblQTD.Size = new System.Drawing.Size(51, 20);
            this.lblQTD.TabIndex = 4;
            this.lblQTD.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 478);
            this.Controls.Add(this.lblQTD);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lstEstado);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.btOk);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.ListBox lstEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblQTD;
    }
}

