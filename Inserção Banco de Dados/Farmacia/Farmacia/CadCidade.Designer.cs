namespace Farmacia
{
    partial class CadCidade
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cid_codLabel;
            System.Windows.Forms.Label cid_nomeLabel;
            System.Windows.Forms.Label cid_UFLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadCidade));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cid_codTextBox = new System.Windows.Forms.TextBox();
            this.cidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._farmacia_mdfDataSet = new Farmacia._farmacia_mdfDataSet();
            this.cid_nomeTextBox = new System.Windows.Forms.TextBox();
            this.cid_UFComboBox = new System.Windows.Forms.ComboBox();
            this.cidadesTableAdapter = new Farmacia._farmacia_mdfDataSetTableAdapters.CidadesTableAdapter();
            this.tableAdapterManager = new Farmacia._farmacia_mdfDataSetTableAdapters.TableAdapterManager();
            this.cidadesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cidadesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            cid_codLabel = new System.Windows.Forms.Label();
            cid_nomeLabel = new System.Windows.Forms.Label();
            cid_UFLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._farmacia_mdfDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingNavigator)).BeginInit();
            this.cidadesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // cid_codLabel
            // 
            cid_codLabel.AutoSize = true;
            cid_codLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cid_codLabel.Location = new System.Drawing.Point(29, 69);
            cid_codLabel.Name = "cid_codLabel";
            cid_codLabel.Size = new System.Drawing.Size(74, 20);
            cid_codLabel.TabIndex = 0;
            cid_codLabel.Text = "Cid cod:";
            // 
            // cid_nomeLabel
            // 
            cid_nomeLabel.AutoSize = true;
            cid_nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cid_nomeLabel.Location = new System.Drawing.Point(29, 95);
            cid_nomeLabel.Name = "cid_nomeLabel";
            cid_nomeLabel.Size = new System.Drawing.Size(89, 20);
            cid_nomeLabel.TabIndex = 2;
            cid_nomeLabel.Text = "Cid nome:";
            // 
            // cid_UFLabel
            // 
            cid_UFLabel.AutoSize = true;
            cid_UFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cid_UFLabel.Location = new System.Drawing.Point(29, 121);
            cid_UFLabel.Name = "cid_UFLabel";
            cid_UFLabel.Size = new System.Drawing.Size(69, 20);
            cid_UFLabel.TabIndex = 4;
            cid_UFLabel.Text = "Cid UF:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(cid_codLabel);
            this.groupBox1.Controls.Add(this.cid_codTextBox);
            this.groupBox1.Controls.Add(cid_nomeLabel);
            this.groupBox1.Controls.Add(this.cid_nomeTextBox);
            this.groupBox1.Controls.Add(cid_UFLabel);
            this.groupBox1.Controls.Add(this.cid_UFComboBox);
            this.groupBox1.Location = new System.Drawing.Point(37, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // cid_codTextBox
            // 
            this.cid_codTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cidadesBindingSource, "Cid_cod", true));
            this.cid_codTextBox.Enabled = false;
            this.cid_codTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cid_codTextBox.Location = new System.Drawing.Point(115, 63);
            this.cid_codTextBox.Name = "cid_codTextBox";
            this.cid_codTextBox.Size = new System.Drawing.Size(44, 26);
            this.cid_codTextBox.TabIndex = 1;
            // 
            // cidadesBindingSource
            // 
            this.cidadesBindingSource.DataMember = "Cidades";
            this.cidadesBindingSource.DataSource = this._farmacia_mdfDataSet;
            // 
            // _farmacia_mdfDataSet
            // 
            this._farmacia_mdfDataSet.DataSetName = "_farmacia_mdfDataSet";
            this._farmacia_mdfDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cid_nomeTextBox
            // 
            this.cid_nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cidadesBindingSource, "Cid_nome", true));
            this.cid_nomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cid_nomeTextBox.Location = new System.Drawing.Point(115, 92);
            this.cid_nomeTextBox.Name = "cid_nomeTextBox";
            this.cid_nomeTextBox.Size = new System.Drawing.Size(121, 26);
            this.cid_nomeTextBox.TabIndex = 3;
            // 
            // cid_UFComboBox
            // 
            this.cid_UFComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cidadesBindingSource, "Cid_UF", true));
            this.cid_UFComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cid_UFComboBox.FormattingEnabled = true;
            this.cid_UFComboBox.Items.AddRange(new object[] {
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA ",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cid_UFComboBox.Location = new System.Drawing.Point(115, 118);
            this.cid_UFComboBox.Name = "cid_UFComboBox";
            this.cid_UFComboBox.Size = new System.Drawing.Size(44, 28);
            this.cid_UFComboBox.TabIndex = 5;
            // 
            // cidadesTableAdapter
            // 
            this.cidadesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CidadesTableAdapter = this.cidadesTableAdapter;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.funcionarioTableAdapter = null;
            this.tableAdapterManager.itens_vendaTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Farmacia._farmacia_mdfDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendasTableAdapter = null;
            // 
            // cidadesBindingNavigator
            // 
            this.cidadesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cidadesBindingNavigator.BindingSource = this.cidadesBindingSource;
            this.cidadesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cidadesBindingNavigator.DeleteItem = null;
            this.cidadesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.cidadesBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.cidadesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cidadesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cidadesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cidadesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cidadesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cidadesBindingNavigator.Name = "cidadesBindingNavigator";
            this.cidadesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cidadesBindingNavigator.Size = new System.Drawing.Size(367, 25);
            this.cidadesBindingNavigator.TabIndex = 1;
            this.cidadesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cidadesBindingNavigatorSaveItem
            // 
            this.cidadesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cidadesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cidadesBindingNavigatorSaveItem.Image")));
            this.cidadesBindingNavigatorSaveItem.Name = "cidadesBindingNavigatorSaveItem";
            this.cidadesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cidadesBindingNavigatorSaveItem.Text = "Save Data";
            this.cidadesBindingNavigatorSaveItem.Click += new System.EventHandler(this.cidadesBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CadCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 340);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cidadesBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Name = "CadCidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadCidade";
            this.Load += new System.EventHandler(this.CadCidade_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._farmacia_mdfDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingNavigator)).EndInit();
            this.cidadesBindingNavigator.ResumeLayout(false);
            this.cidadesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private _farmacia_mdfDataSet _farmacia_mdfDataSet;
        private System.Windows.Forms.BindingSource cidadesBindingSource;
        private _farmacia_mdfDataSetTableAdapters.CidadesTableAdapter cidadesTableAdapter;
        private _farmacia_mdfDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cidadesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cidadesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cid_codTextBox;
        private System.Windows.Forms.TextBox cid_nomeTextBox;
        private System.Windows.Forms.ComboBox cid_UFComboBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button button1;
    }
}