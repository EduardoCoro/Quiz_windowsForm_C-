namespace Prj_Menu
{
    partial class frmCal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ad_Sub = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicaçãoDivisãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(467, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculosToolStripMenuItem
            // 
            this.calculosToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.calculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ad_Sub,
            this.multiplicaçãoDivisãoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.calculosToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.calculosToolStripMenuItem.Name = "calculosToolStripMenuItem";
            this.calculosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.calculosToolStripMenuItem.Text = "Calculos";
            // 
            // Ad_Sub
            // 
            this.Ad_Sub.Name = "Ad_Sub";
            this.Ad_Sub.Size = new System.Drawing.Size(189, 22);
            this.Ad_Sub.Text = "Adição/Subtração";
            this.Ad_Sub.Click += new System.EventHandler(this.adiçãoSubtraçãoToolStripMenuItem_Click);
            // 
            // multiplicaçãoDivisãoToolStripMenuItem
            // 
            this.multiplicaçãoDivisãoToolStripMenuItem.Name = "multiplicaçãoDivisãoToolStripMenuItem";
            this.multiplicaçãoDivisãoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.multiplicaçãoDivisãoToolStripMenuItem.Text = "Multiplicação/Divisão";
            this.multiplicaçãoDivisãoToolStripMenuItem.Click += new System.EventHandler(this.multiplicaçãoDivisãoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(186, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click_1);
            // 
            // frmCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prj_Menu.Properties.Resources.Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 368);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCal";
            this.Text = "Calculos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Ad_Sub;
        private System.Windows.Forms.ToolStripMenuItem multiplicaçãoDivisãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;

    }
}

