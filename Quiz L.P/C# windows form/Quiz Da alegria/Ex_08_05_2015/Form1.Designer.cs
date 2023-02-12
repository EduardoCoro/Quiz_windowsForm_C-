namespace Ex_08_05_2015
{
    partial class fmrPrincipal
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
            this.bt_Inicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Inicio
            // 
            this.bt_Inicio.BackColor = System.Drawing.SystemColors.Control;
            this.bt_Inicio.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Inicio.Location = new System.Drawing.Point(122, 142);
            this.bt_Inicio.Name = "bt_Inicio";
            this.bt_Inicio.Size = new System.Drawing.Size(172, 90);
            this.bt_Inicio.TabIndex = 0;
            this.bt_Inicio.Text = "INICIAR";
            this.bt_Inicio.UseVisualStyleBackColor = false;
            this.bt_Inicio.Click += new System.EventHandler(this.bt_Inicio_Click);
            // 
            // fmrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ex_08_05_2015.Properties.Resources.voce_e_organizado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 561);
            this.Controls.Add(this.bt_Inicio);
            this.Name = "fmrPrincipal";
            this.Text = "Quiz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Inicio;
    }
}

